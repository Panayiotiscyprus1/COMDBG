/**
 
 * Copyright (c) 2014-2015, Wenhuix, All rights reserved.

 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met:

 * Redistributions of source code must retain the above copyright notice, 
 * this list of conditions and the following disclaimer.

 * Redistributions in binary form must reproduce the above copyright notice, 
 * this list of conditions and the following disclaimer in the documentation 
 * and/or other materials provided with the distribution.

 * Neither the name of COMDBG nor the names of its contributors may 
 * be used to endorse or promote products derived from this software without 
 * specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE 
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF 
 * THE POSSIBILITY OF SUCH DAMAGE.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices.WindowsRuntime;

namespace COMDBG
{
    public interface IView
    {
        void SetController(IController controller);
        //Open serial port event
        void OpenComEvent(Object sender, SerialPortEventArgs e);
        //Close serial port event
        void CloseComEvent(Object sender, SerialPortEventArgs e);
        //Serial port receive data event
        void ComReceiveDataEvent(Object sender, SerialPortEventArgs e);
    }

    public partial class MainForm : Form, IView
    {
        private IController controller;
        private int sendBytesCount = 0;
        private int receiveBytesCount = 0;

        //return length
        public int returnLength;
        //return data
        public String returnData;
        //once
        public int onceLength;
        //to toggle 53-73 byte on change primary address requests
        public int tog = 0;
        //to store last current address f
        public string last;


        public MainForm()
        {
            InitializeComponent();
            InitializeCOMCombox();
            this.statusTimeLabel.Text = System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.toolStripStatusTx.Text = "Sent: 0";
            this.toolStripStatusRx.Text = "Received: 0";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        /// <summary>
        /// Set controller
        /// </summary>
        /// <param name="controller"></param>
        public void SetController(IController controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// Initialize serial port information
        /// </summary>
        private void InitializeCOMCombox()
        {
            //BaudRate
            baudRateCbx.Items.Add(2400);
            baudRateCbx.Items.Add(9600);
            baudRateCbx.Items.Add(19200);
            baudRateCbx.Items.Add(38400);
            baudRateCbx.Items.Add(57600);
            baudRateCbx.Items.Add(115200);
            baudRateCbx.Items.ToString();
            //get 9600 print in text
            baudRateCbx.Text = baudRateCbx.Items[0].ToString();

            //Data bits
            dataBitsCbx.Items.Add(7);
            dataBitsCbx.Items.Add(8);
            //get the 8bit item print it in the text 
            dataBitsCbx.Text = dataBitsCbx.Items[1].ToString();

            //Stop bits
            stopBitsCbx.Items.Add("One");
            stopBitsCbx.Items.Add("OnePointFive");
            stopBitsCbx.Items.Add("Two");
            //get the One item print in the text
            stopBitsCbx.Text = stopBitsCbx.Items[0].ToString();

            //Parity
            parityCbx.Items.Add("None");
            parityCbx.Items.Add("Even");
            parityCbx.Items.Add("Mark");
            parityCbx.Items.Add("Odd");
            parityCbx.Items.Add("Space");
            //get the first item print in the text
            parityCbx.Text = parityCbx.Items[1].ToString();

            //Handshaking
            handshakingcbx.Items.Add("None");
            handshakingcbx.Items.Add("XOnXOff");
            handshakingcbx.Items.Add("RequestToSend");
            handshakingcbx.Items.Add("RequestToSendXOnXOff");
            handshakingcbx.Text = handshakingcbx.Items[0].ToString();

            //Com Ports
            string[] ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length == 0)
            {
                statuslabel.Text = "No COM found !";
                openCloseSpbtn.Enabled = false;
            }
            else
            {
                Array.Sort(ArrayComPortsNames);
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    comListCbx.Items.Add(ArrayComPortsNames[i]);
                }
                comListCbx.Text = ArrayComPortsNames[0];
                openCloseSpbtn.Enabled = true;
            }
        }

        /// <summary>
        /// update status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenComEvent(Object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action<Object, SerialPortEventArgs>(OpenComEvent), sender, e);
                return;
            }

            if (e.isOpend)  //Open successfully
            {
                statuslabel.Text = comListCbx.Text + " Opend";
                openCloseSpbtn.Text = "Close";
                sendbtn.Enabled = true;
                send1.Enabled = true;
                send3.Enabled = true;
                requestButton.Enabled = true;
                autoSendcbx.Enabled = true;
                autoReplyCbx.Enabled = true;

                comListCbx.Enabled = false;
                baudRateCbx.Enabled = false;
                dataBitsCbx.Enabled = false;
                stopBitsCbx.Enabled = false;
                parityCbx.Enabled = false;
                handshakingcbx.Enabled = false;
                refreshbtn.Enabled = false;

                if (autoSendcbx.Checked)
                {
                    autoSendtimer.Start();
                    sendtbx.ReadOnly = true;
                }
            }
            else    //Open failed
            {
                statuslabel.Text = "Open failed !";
                sendbtn.Enabled = false;
                send1.Enabled = false;
                requestButton.Enabled = false;
                send3.Enabled = false;
                autoSendcbx.Enabled = false;
                autoReplyCbx.Enabled = false;
            }
        }

        /// <summary>
        /// update status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CloseComEvent(Object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action<Object, SerialPortEventArgs>(CloseComEvent), sender, e);
                return;
            }

            if (!e.isOpend) //close successfully
            {
                statuslabel.Text = comListCbx.Text + " Closed";
                openCloseSpbtn.Text = "Open";

                sendbtn.Enabled = false;
                requestButton.Enabled = false;
                send1.Enabled = false;
                send3.Enabled = false;
                sendtbx.ReadOnly = false;
                autoSendcbx.Enabled = false;
                autoSendtimer.Stop();

                comListCbx.Enabled = true;
                baudRateCbx.Enabled = true;
                dataBitsCbx.Enabled = true;
                stopBitsCbx.Enabled = true;
                parityCbx.Enabled = true;
                handshakingcbx.Enabled = true;
                refreshbtn.Enabled = true;
            }
        }

        public static string Hex2Binary(string hex)
        {
            return String.Join(String.Empty, 
                hex.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        }

        public static DateTime ParseTime(string str)
        {
            Console.WriteLine(str);
            int sec = Convert.ToInt32(Hex2Binary(str.Substring(0, 2)).Substring(2, 6), 2);
            int min = Convert.ToInt32(Hex2Binary(str.Substring(2, 2)).Substring(2, 6), 2);
            int hour = Convert.ToInt32(Hex2Binary(str.Substring(4, 2)).Substring(3, 5), 2);
            int day = Convert.ToInt32(Hex2Binary(str.Substring(6, 2)).Substring(3, 5), 2);
            int month = Convert.ToInt32(Hex2Binary(str.Substring(8, 2)).Substring(4, 4), 2);
            string year1 = Hex2Binary(str.Substring(8, 2)).Substring(0, 4);
            string year2 = Hex2Binary(str.Substring(6, 2)).Substring(0, 3);
            int year = Convert.ToInt32(year1 + year2, 2);
            Console.WriteLine($"YEAR={2000 + year} month={month} day={day} hour={hour} min={min} sec={sec}");

            return new DateTime(2000 + year, month, day, hour, min, sec);
        }

        public static String bcdDecoder (String sub1)
        {
            if (sub1 == null || sub1.Length % 2 != 0)
                return null;
            StringBuilder str = new StringBuilder();
            for (int i=sub1.Length; i>=2; i = i - 2)
            {
                str.Append(sub1.Substring(i - 2, 2));
            }
            return str.ToString();
        }

        public static double vif(String str)
        {
            str = Hex2Binary(str);
            if (str.Substring(0, 5).Equals("10010"))
            {
                int n = Convert.ToInt32(str.Substring(5, 3), 2);
                return Math.Pow(10, n - 6);
            }
            else if (str.Substring(0, 6).Equals("010110"))
            {
                int n = Convert.ToInt32(str.Substring(6, 2), 2);
                return Math.Pow(10, n - 3);
            }
            else if (str.Substring(0, 6).Equals("001001"))
            {
                switch (str.Substring(6, 2))
                {
                    case "00":
                        return (double) 1/3600;
                    case "01":
                        return (double)1 / 60;
                    case "10":
                        return 1;
                    case "11":
                        return 24;
                    default:
                        throw new ArgumentException("Invalid VIF time unit encoding");
                }
            }
            else
            {
                throw new ArgumentException("Vif not recognised");
            }
        }



        /// <summary>
        /// Display received data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public int ccc = -1;
        public void ComReceiveDataEvent(Object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    Invoke(new Action<Object, SerialPortEventArgs>(ComReceiveDataEvent), sender, e);
                }
                catch (System.Exception)
                {
                    //disable form destroy exception
                }
                return;
            }

            if (recStrRadiobtn.Checked) //display as string
            {
                receivetbx.AppendText(Encoding.Default.GetString(e.receivedBytes));
            }
            else //display as hex
            {
                if (receivetbx.Text.Length > 0)
                {
                   receivetbx.AppendText("-");
                }
                receivetbx.AppendText(IController.Bytes2Hex(e.receivedBytes));
            }
            //update status bar
            receiveBytesCount += e.receivedBytes.Length;
            toolStripStatusRx.Text = "Received: "+receiveBytesCount.ToString();

            onceLength += e.receivedBytes.Length;

            returnData += IController.Bytes2Hex(e.receivedBytes);

            if (onceLength == returnLength && onceLength ==75)
            {
                //ccc++;
                ccc = 0;
                Console.WriteLine($"ccc is {ccc}");

                //string received = receivetbx.Text.Replace("-", "");

                string received = returnData.Replace("-","");

                Console.WriteLine($"returnData is {returnData}");



                orTimeBox.Text = ParseTime(received.Substring(128 + (150*ccc), 12)).ToString();
                deviceNumberBox.Text = bcdDecoder(received.Substring(14 + (150 * ccc), 8));
                manufacturerId.Text = received.Substring(22 + (150 * ccc), 4);
                normalFlow.Text = (Double.Parse(bcdDecoder(received.Substring(44 + (150 * ccc), 8))) * vif(received.Substring(40 + (150 * ccc), 2))).ToString();
                reverseFlow.Text = (Double.Parse(bcdDecoder(received.Substring(58 + (150 * ccc), 8))) * vif(received.Substring(54 + (150 * ccc), 2))).ToString();
                flowTemp.Text = (Double.Parse(bcdDecoder(received.Substring(70 + (150 * ccc), 6))) * vif(received.Substring(68 + (150 * ccc), 2))).ToString();
                operationTime.Text = (Double.Parse(bcdDecoder(received.Substring(92 + (150 * ccc), 8))) * vif(received.Substring(90 + (150 * ccc), 2))).ToString();
            }

            //auto reply
            if (autoReplyCbx.Checked)
            {
                sendbtn_Click(this, new EventArgs());
            }

        }

        /// <summary>
        /// Auto scroll in receive textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void receivetbx_TextChanged(object sender, EventArgs e)
        {
            receivetbx.SelectionStart = receivetbx.Text.Length;
            receivetbx.ScrollToCaret();
        }

        /// <summary>
        /// update time in status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statustimer_Tick(object sender, EventArgs e)
        {
            this.statusTimeLabel.Text = System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        /// <summary>
        /// open or close serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openCloseSpbtn_Click(object sender, EventArgs e)
        {
            if (openCloseSpbtn.Text == "Open")
            {
                controller.OpenSerialPort(comListCbx.Text, baudRateCbx.Text,
                    dataBitsCbx.Text, stopBitsCbx.Text, parityCbx.Text,
                    handshakingcbx.Text);
            } 
            else
            {
                controller.CloseSerialPort();
            }
        }

        /// <summary>
        /// Refresh soft to find Serial port device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            comListCbx.Items.Clear();
            //Com Ports
            string[] ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length == 0)
            {
                statuslabel.Text = "No COM found !";
                openCloseSpbtn.Enabled = false;
            }
            else
            {
                Array.Sort(ArrayComPortsNames);
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    comListCbx.Items.Add(ArrayComPortsNames[i]);
                }
                comListCbx.Text = ArrayComPortsNames[0];
                openCloseSpbtn.Enabled = true;
                statuslabel.Text = "OK !";
            }
            
        }

        /// <summary>
        /// Send data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendbtn_Click(object sender, EventArgs e)
        {
            String sendText = sendtbx.Text;
            bool flag = false;
            if (sendText == null)
            {
                return;
            }
            //set select index to the end
            sendtbx.SelectionStart = sendtbx.TextLength; 
          
            if (sendHexRadiobtn.Checked)
            {
                //If hex radio checked
                //send bytes to serial port
                String activeCode = "";
                for (int i = 0; i < 256; i++)
                {
                    activeCode += "00 ";
                }
                sendText = activeCode + sendText;

                onceLength = 0;
                returnLength = 75;
                returnData = "";

                Console.WriteLine("Send:"+sendText);
                Byte[] bytes = IController.Hex2Bytes(sendText);
                sendbtn.Enabled = false;//wait return
                flag = controller.SendDataToCom(bytes);
                sendbtn.Enabled = true;
                sendBytesCount += bytes.Length;
            }
            else
            {
                //send String to serial port
                sendbtn.Enabled = false;//wait return
                flag = controller.SendDataToCom(sendText);
                sendbtn.Enabled = true;
                sendBytesCount += sendText.Length;
            }
            if (flag)
            {
                statuslabel.Text = "Send OK !";
            }
            else
            {
                statuslabel.Text = "Send failed !";
            }
            //update status bar
            toolStripStatusTx.Text = "Sent: " + sendBytesCount.ToString();
        }

    
        

        /// <summary>
        /// clear text in send area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearSendbtn_Click(object sender, EventArgs e)
        {
            sendtbx.Text = "";
            toolStripStatusTx.Text = "Sent: 0";
            sendBytesCount = 0;
            addCRCcbx.Checked = false;
        }

        /// <summary>
        /// clear receive text in receive area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearReceivebtn_Click(object sender, EventArgs e)
        {
            receivetbx.Text = "";
            toolStripStatusRx.Text = "Received: 0";
            receiveBytesCount = 0;
        }

        /// <summary>
        /// String to hex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recHexRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (recHexRadiobtn.Checked)
            {
                if (receivetbx.Text == null)
                {
                    return;
                }
                receivetbx.Text = IController.String2Hex(receivetbx.Text);
            }
        }

        /// <summary>
        /// Hex to string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recStrRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (recStrRadiobtn.Checked)
            {
                if (receivetbx.Text == null)
                {
                    return;
                }
                receivetbx.Text = IController.Hex2String(receivetbx.Text);
            }
        }

        /// <summary>
        /// String to Hex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendHexRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sendHexRadiobtn.Checked)
            {
                if (sendtbx.Text == null)
                {
                    return;
                }
                sendtbx.Text = IController.String2Hex(sendtbx.Text);
                addCRCcbx.Enabled = true;
            }
        }

        /// <summary>
        /// Hex to string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendStrRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sendStrRadiobtn.Checked)
            {
                if (sendtbx.Text == null)
                {
                    return;
                }
                sendtbx.Text = IController.Hex2String(sendtbx.Text);
                addCRCcbx.Enabled = false;
            }
        }

        /// <summary>
        /// Filter illegal input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Input Hex, should like: AF-1B-09
            if (sendHexRadiobtn.Checked)
            {
                e.Handled = true;
                int length = sendtbx.SelectionStart;
                switch (length % 3)
                {
                case 0:
                case 1:
                    if ((e.KeyChar >= 'a' && e.KeyChar <= 'f')
                        || (e.KeyChar >= 'A' && e.KeyChar <= 'F')
                        || char.IsDigit(e.KeyChar)
                        || (char.IsControl(e.KeyChar) && e.KeyChar != (char)13))
                    {
                        e.Handled = false;
                    }
                    break;
                case 2:
                    if (e.KeyChar == '-'
                        || (char.IsControl(e.KeyChar) && e.KeyChar != (char)13)
                        || e.KeyChar == ' '
                        || (e.KeyChar >= 'a' && e.KeyChar <= 'f')
                        || (e.KeyChar >= 'A' && e.KeyChar <= 'F')
                        || char.IsDigit(e.KeyChar)
                        || (char.IsControl(e.KeyChar) && e.KeyChar != (char)13))
                    {
                        e.Handled = false;
                    }
                    break;
                }
            }
        }


        /// <summary>
        /// Auto send data to serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoSendcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (autoSendcbx.Checked)
            {
                autoSendtimer.Enabled = true;
                autoSendtimer.Interval = int.Parse(sendIntervalTimetbx.Text);
                autoSendtimer.Start();

                //disable send botton and textbox
                sendIntervalTimetbx.Enabled = false;
                sendtbx.ReadOnly = true;
                sendbtn.Enabled = false;
                send1.Enabled = false;
                send3.Enabled = false;
            }
            else
            {
                autoSendtimer.Enabled = false;
                autoSendtimer.Stop();

                //enable send botton and textbox
                sendIntervalTimetbx.Enabled = true;
                sendtbx.ReadOnly = false;
                sendbtn.Enabled = true;
                send1.Enabled = true;
                send3.Enabled = true;
            }
        }

        private void autoSendtimer_Tick(object sender, EventArgs e)
        {
            sendbtn_Click(sender, e);
        }

        /// <summary>
        /// filter illegal input of auto send interval time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendIntervalTimetbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Add CRC checkbox changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCRCcbx_CheckedChanged(object sender, EventArgs e)
        {
            String sendText = sendtbx.Text;
            if (sendText == null || sendText == "")
            {
                addCRCcbx.Checked = false;
                return;
            }
            if (addCRCcbx.Checked)
            {
                //Add 2 bytes CRC to the end of the data
                Byte[] senddata = IController.Hex2Bytes(sendText);
                Byte[] crcbytes = BitConverter.GetBytes(CRC16.Compute(senddata));
                sendText += "-" + BitConverter.ToString(crcbytes, 1, 1);
                sendText += "-" + BitConverter.ToString(crcbytes, 0, 1);
            }
            else
            {
                //Delete 2 bytes CRC to the end of the data
                if (sendText.Length >= 6)
                {
                    sendText = sendText.Substring(0, sendText.Length - 6);
                }
            }
            sendtbx.Text = sendText;
        }

        /// <summary>
        /// save received data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void receivedDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "txt file|*.txt";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FileName = "received.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(fName, receivetbx.Text);
            }
        }

        /// <summary>
        /// save send data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "txt file|*.txt";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FileName = "send.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(fName, sendtbx.Text);
            }
        }

        /// <summary>
        /// Quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// about me
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.StartPosition = FormStartPosition.CenterParent;
            about.Show();

            if (about.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - about.Width) / 2;
                var y = Location.Y + (Height - about.Height) / 2;
                about.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }
        }

        /// <summary>
        /// Help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.StartPosition = FormStartPosition.CenterParent;
            help.Show();

            if (help.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - help.Width) / 2;
                var y = Location.Y + (Height - help.Height) / 2;
                help.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }
        }

        private void sendtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sendText = "105bfe5916";
            bool flag = false;
            String activeCode = "";
            for (int i = 0; i < 256; i++)
            {
                activeCode += "00 ";
            }

            sendText = activeCode + sendText;

            onceLength = 0;
            returnLength = 75;
            returnData = "";

            Console.WriteLine("Send:" + sendText);
            Byte[] bytes = IController.Hex2Bytes(sendText);
            sendbtn.Enabled = false;//wait return
            requestButton.Enabled = false;
            flag = controller.SendDataToCom(bytes);
            sendbtn.Enabled = true;
            requestButton.Enabled = true;

            if (flag)
            {
                statuslabel.Text = "Send OK !";
            }
            else
            {
                statuslabel.Text = "Send failed !";
            }
            //update status bar
            toolStripStatusTx.Text = "Sent: " + sendBytesCount.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            header_label.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Decrypted_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void deviceNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void send1_Click_1(object sender, EventArgs e)
        {
            string currentAddress = "00";
            Console.WriteLine($"return Data before loop: {returnData}");
            if (returnData != null && returnData.Replace("-", "").Length == 150)
            {
                Console.WriteLine($"return data of bugtest#10000: {returnData}");
                currentAddress = returnData.Replace("-", "").Substring(10, 2);
                Console.WriteLine($"current address from check: {currentAddress}");
            }
            else if(returnData != null)
            {
                currentAddress = last;
            }
                String sendText = primaryAddress.Text;
            bool flag = false;
            if (sendText == null)
            {
                return;
            }
            else if (!sendText.All(char.IsDigit) || Convert.ToInt32(sendText) > 255 ||
                Convert.ToInt32(sendText) < 0)
            {
                statusLabel1.Text = "Primary Address should be a number from 1 to 255";
                return;
            }
            primaryAddress.SelectionStart = primaryAddress.TextLength;

            String activeCode = "";
            for (int i = 0; i < 256; i++)
            {
                activeCode += "00";
            }

            string checkSum = "";

            //68060668 730151 01 7A 00 20 16

            if (tog % 2 == 0) 
            { 
                sendText = int.Parse(sendText).ToString("X2"); //make it hex
                checkSum = ((Convert.ToInt32("53", 16) + Convert.ToInt32(currentAddress, 16) +
                                Convert.ToInt32("51", 16) + Convert.ToInt32("01", 16) +
                                Convert.ToInt32("7A", 16) + Convert.ToInt32(sendText, 16)) % 256).ToString("X2");
                last = sendText;
                sendText = activeCode + "68060668" + "53" + currentAddress + "51017A" + sendText + checkSum + "16";
            }

            else if (tog % 2 == 1)
            {
                sendText = int.Parse(sendText).ToString("X2"); //make it hex
                checkSum = ((Convert.ToInt32("73", 16) + Convert.ToInt32(currentAddress, 16) +
                                Convert.ToInt32("51", 16) + Convert.ToInt32("01", 16) +
                                Convert.ToInt32("7A", 16) + Convert.ToInt32(sendText, 16)) % 256).ToString("X2");
                last = sendText;
                sendText = activeCode + "68060668" + "73" + currentAddress + "51017A" + sendText + checkSum + "16";
            }
            Byte[] bytes = IController.Hex2Bytes(sendText);
            Console.WriteLine($"command sent: {sendText}");
            send1.Enabled = false;//wait return
            flag = controller.SendDataToCom(bytes);
            send1.Enabled = true;

            tog++;

            onceLength = 0;
            returnLength = 1;
            returnData = "";


            if (flag)
            {
                statusLabel1.Text = "Request Sent";
            }
            else
            {
                statusLabel1.Text = "Send failed !";
            }
        }

        public static String ToBinary(int value) =>
            Convert.ToString(value, 2).PadLeft(8,'0');

        private void send3_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker.Value;
            bool flag = false;
            String activeCode = "";
            for (int i = 0; i < 256; i++)
            {
                activeCode += "00";
            }

            int year = dateTime.Year;
            int month = dateTime.Month;
            int day = dateTime.Day;
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;

            string currentAddress = "00";
            Console.WriteLine($"return Data before loop: {returnData}");
            if (returnData != null && returnData.Replace("-", "").Length == 150)
            {
                currentAddress = returnData.Replace("-", "").Substring(10, 2);
            }
            else if (returnData != null)
            {
                currentAddress = last;
            }

            string sendText = "00" + ToBinary(minute).Substring(2, 6) + "001" + ToBinary(hour).Substring(3, 5) +
                        ToBinary(year-2000).Substring(5, 3) + ToBinary(day).Substring(3, 5) +
                        ToBinary(year-2000).Substring(1, 4) + ToBinary(month).Substring(4, 4);

            Console.WriteLine($"Binary datetime string test {sendText}");

            string checkSum = "";

            sendText = Convert.ToInt32(sendText, 2).ToString("X8"); //make it hex
            Console.WriteLine($"hex datetime set: {sendText}");

            if (tog % 2 == 0)
            {
                checkSum = ((Convert.ToInt32("53", 16) + Convert.ToInt32(currentAddress, 16) +
                                Convert.ToInt32("51", 16) + Convert.ToInt32("04", 16) +
                                Convert.ToInt32("6D", 16) + Convert.ToInt32(sendText.Substring(0,2), 16) +
                                Convert.ToInt32(sendText.Substring(2, 2), 16) + Convert.ToInt32(sendText.Substring(4, 2), 16) +
                                Convert.ToInt32(sendText.Substring(6, 2), 16)) % 256).ToString("X2");
                sendText = activeCode + "68090968" + "53" + currentAddress + "51046D" + sendText + checkSum + "16";
            }

            else if (tog % 2 == 1)
            {
                checkSum = ((Convert.ToInt32("73", 16) + Convert.ToInt32(currentAddress, 16) +
                                Convert.ToInt32("51", 16) + Convert.ToInt32("04", 16) +
                                Convert.ToInt32("6D", 16) + Convert.ToInt32(sendText.Substring(0, 2), 16) +
                                Convert.ToInt32(sendText.Substring(2, 2), 16) + Convert.ToInt32(sendText.Substring(4, 2), 16) +
                                Convert.ToInt32(sendText.Substring(6, 2), 16)) % 256).ToString("X2");
                sendText = activeCode + "68090968" + "73" + currentAddress + "51046D" + sendText + checkSum + "16";
            }

            sendText = activeCode + "68090968" + "73" + currentAddress + "51046D" + sendText + checkSum + "16";
            Byte[] bytes = IController.Hex2Bytes(sendText);
            Console.WriteLine($"command sent: {sendText}");
            send1.Enabled = false;//wait return
            flag = controller.SendDataToCom(bytes);
            send1.Enabled = true;

            tog++;
            onceLength = 0;
            returnLength = 1;
            returnData = "";

            if (flag)
            {
                statusLabel1.Text = "Request Sent";
            }
            else
            {
                statusLabel1.Text = "Send failed !";
            }
        }

        
    }
}

