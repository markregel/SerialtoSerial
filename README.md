# SerialtoSerial
Dual serial port monitor and redirector application 

•	Monitoring of two ports 
•	Redirection allows received data of one port to be forwarded out the other port
•	On screen display of sent and received data in binary hexadecimal and text format
•	Capture files in binary and text format
•	Push buttons for clearing the screen and capture files
•	Persistent settings. All settings automatically saved when the application is closed and restored the next time the application is started 

Forward received data out port #n (redirection)

When enabled all data received on the port will be forwarded out the other port.  This is useful when using two ports for in line sniffing or monitoring a remote device using a virtual serial port.
Virtual Serial Port (Serial over IP)
Another use for forwarding is accessing a remote device using a virtual serial port or Serial over IP.  Serial over IP devices are commonly available and consist of a hardware unit with a RS-232 port and Ethernet port for connecting the target device to a TCP/IP network or the Internet.  Serial over IP devices typically include a driver which is installed on the PC for associating the virtual serial port to a Com Port name.  Follow the manufactures instructions for installing the driver.  Using a virtual serial port and the Serial to Serial application setup with the Forward option enabled for both ports a serial device can be monitored and debugged from a remote location.
