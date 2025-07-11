# Water-Meter Config Tool – COMDBG Edition

A WinForms utility (built on top of the **COMDBG** serial framework) that
talks to our NB-IoT / optical-interface water meters via the **M-Bus**
protocol.  
It lets you **read, decode, and configure** a single meter plugged into a
USB optical head.
---

## Features

* **Live read-out** – fetch the full MBUS variable data frame \
  (flow totals, temperatures, operation hours …).
* **Hex/ASCII console** – raw traffic in/out with auto CRC, auto spacing.
* **One-click config**
  * Set **primary address**
  * Set **meter date-time**
* Automatic **53 / 73 FCB toggling** and **wake-up pre-amble** (256 × `0x00`)
  so every write gets its `E5` ACK first time.
* Saves / restores last COM settings (baud-rate, parity, etc.).
* Works with any USB optical probe in **2400 8E1**.

**All the decoding, data processing etc happens based on the factory's protocol, which follows the MBUS protocol


Default serial settings: **2400 baud  8-E-1  no handshake**.
