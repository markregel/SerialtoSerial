using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Threading;
using System.Xml;
using System.Globalization;

namespace SerialtoSerial
{
    public partial class Form1 : Form
    {        
        private int ticks;
        private StreamWriter sw1;
        private StreamWriter sw2;
        string lineRxHex1 = "";
        string lineRxHex2 = "";
        string lineRxAsc1 = "";
        string lineRxAsc2 = "";
        string lineTxHex1 = "";
        string lineTxHex2 = "";
        string lineTxAsc1 = "";
        string lineTxAsc2 = "";       
        Boolean mb;
        byte tx1;
        byte tx2;
        string folderPath = "";
        bool fastRx1 = false;
        bool fastRx2 = false;
        bool fastTx1 = false;
        bool fastTx2 = false;
        int ticksRx1;
        int ticksRx2;
        int ticksTx1;
        int ticksTx2;
        int max;
        AdvancedSettings formAdvancedSettings = new AdvancedSettings(); //advanced settings form
                                                          
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string s, TextBox tb);
       
        public Form1()
        {
            InitializeComponent();
            Init();
            ReadSettings("");
        }

        //init controls on main form
        private void Init()
        {
            comboPort1.Items.Clear();
            comboPort2.Items.Clear();
            comboPort1.Sorted = true;
            comboPort2.Sorted = true;

            //populate port names
            string[] ports = SerialPort.GetPortNames();

            comboPort1.Items.Add("None");
            comboPort2.Items.Add("None");
            foreach (string port in ports)
            {
                comboPort1.Items.Add(port);
                comboPort2.Items.Add(port);
            }                       
            comboPort1.SelectedItem = "None";
            comboPort2.SelectedItem = "None";

            //populate baud rate
            comboBaud1.Items.Clear();
            comboBaud2.Items.Clear();

            comboBaud1.Items.Add("1200");
            comboBaud1.Items.Add("2400");
            comboBaud1.Items.Add("4800");
            comboBaud1.Items.Add("9600");
            comboBaud1.Items.Add("19200");
            comboBaud1.Items.Add("38400");
            comboBaud1.Items.Add("57600");
            comboBaud1.Items.Add("115200");

            comboBaud2.Items.Add("1200");
            comboBaud2.Items.Add("2400");
            comboBaud2.Items.Add("4800");
            comboBaud2.Items.Add("9600");
            comboBaud2.Items.Add("19200");
            comboBaud2.Items.Add("38400");
            comboBaud2.Items.Add("57600");
            comboBaud2.Items.Add("115200");

            comboBaud1.SelectedIndex = 3;
            comboBaud2.SelectedIndex = 3;
            
            formAdvancedSettings.Init(); //init advanced settings
        }

        private void SetText(string s, TextBox tb)
        {           
            //char[] values = text.ToCharArray();
           
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (tb.InvokeRequired)
            { 
                SetTextCallback d = new SetTextCallback(SetText);                
                //this.Invoke(d, new object[] { s, tb });
                this.BeginInvoke(d, new object[] { s, tb });
                // Using this.Invoke causes deadlock when closing serial port,
                // and BeginInvoke is good practice anyway.
                        
            }
            else
            {
                tb.AppendText(s);                                
            }
        }
      
        //port1 data received
        void sp_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {
            //byte[] b = new byte[1];
            int iNumRead;
                                             
            try
            {
                iNumRead = serialPort1.BytesToRead;
                if(iNumRead > 0)               
                {                   
                    byte[] array = new byte[iNumRead];
                    
                    iNumRead = serialPort1.Read(array, 0, iNumRead);
                    Update(array, textRx1);
                          
                    //port forwarding                                                    
                    if (serialPort2.IsOpen && checkForward1.Checked)
                    {
                        ticks = 50;
                        Update(array, textTx2);
                        serialPort2.Write(array, 0, iNumRead);                                          
                    }                    
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }

        //port2 data received
        void sp_DataReceived2(object sender, SerialDataReceivedEventArgs e)
        {
            //byte[] b = new byte[1];
            int iNumRead;

            try
            {
                iNumRead = serialPort2.BytesToRead;
                if (iNumRead > 0)
                {                   
                    byte[] array = new byte[iNumRead];

                    iNumRead = serialPort2.Read(array, 0, iNumRead);
                    Update(array, textRx2);

                    //port forwarding                                                    
                    if (serialPort1.IsOpen && checkForward2.Checked)
                    {
                        ticks = 50;
                        Update(array, textTx1);
                        serialPort1.Write(array, 0, iNumRead);
                    }

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
                      
        } 

        //init serial ports
        private Boolean InitPort(SerialPort s)
        {
            string baud;
            string port;

            try
            {
                if (s.IsOpen)
                {
                    s.Close();
                }

                if (s == serialPort1)
                {
                    s.Parity = formAdvancedSettings.Parity1;
                    s.DataBits = formAdvancedSettings.Databits1;
                    s.StopBits = formAdvancedSettings.Stopbits1;
                    s.Handshake = formAdvancedSettings.Handshake1;

                    port = comboPort1.SelectedItem.ToString();
                    baud = comboBaud1.SelectedItem.ToString();
                    s.PortName = port;
                    s.BaudRate = Convert.ToInt32(baud);
                    s.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived1);                    
                }

                if (s == serialPort2)
                {
                    s.Parity = formAdvancedSettings.Parity2;
                    s.DataBits = formAdvancedSettings.Databits2;
                    s.StopBits = formAdvancedSettings.Stopbits2;
                    s.Handshake = formAdvancedSettings.Handshake2;

                    port = comboPort2.SelectedItem.ToString();
                    baud = comboBaud2.SelectedItem.ToString();
                    s.PortName = port;
                    s.BaudRate = Convert.ToInt32(baud);
                    s.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived2);
                }

                s.ReadTimeout = 1000;
                s.WriteTimeout = 5000;
                s.WriteBufferSize = 1000000;
                s.ReadBufferSize = 1000000;


                if (s.Handshake != Handshake.None)
                {
                    //try { s.DtrEnable = true; }
                    //catch { }
                    //try { s.RtsEnable = true; }
                    //catch { }
                }

                s.Open();
            }
            catch (Exception e)
            {
                if (s.IsOpen)
                {
                    s.Close();
                }
                MessageBox.Show(e.Message);
                return false;                
            }
                                              
            return true;
        }

        //start button
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Boolean p1 = false;
            Boolean p2 = false;

            ClosePorts();                          
            mb = false;
          
            if (comboPort1.SelectedItem.ToString() != "None")
            {
                p1 = InitPort(serialPort1);
            }

            if (comboPort2.SelectedItem.ToString() != "None")
            {
                p2 = InitPort(serialPort2);
            }
           
            if (p1)
            {
                buttonStart.BackColor = Color.Red;

                //start file capture
                try
                {
                    if (sw1 == null)
                    {
                        //String s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);                                             
                        String s = folderPath + "\\rx1.txt";
                        sw1 = new StreamWriter(s, true);
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }

            if (p2)
            {
                buttonStart.BackColor = Color.Red;

                //start file capture
                try
                {
                    if (sw2 == null)
                    {                        
                        //String s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);  
                        String s = folderPath + "\\rx2.txt";                                            
                        sw2 = new StreamWriter(s, true);
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }

            if (p1 == false && p2 == false)
            {
                MessageBox.Show("No ports selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            fastRx1 = false;
            fastRx2 = false;
            fastTx1 = false;
            fastTx2 = false;
        }

        //stop button
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.BackColor = BackColor;
            ClosePorts();
            CloseCapture();

            lineRxHex1 = "";
            lineRxHex2 = "";
            lineRxAsc1 = "";
            lineRxAsc2 = "";
            lineTxHex1 = "";
            lineTxHex2 = "";
            lineTxAsc1 = "";
            lineTxAsc2 = "";       
        }

        //opening
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
            ClosePorts();
            CloseCapture();
            timer1.Stop();
            SaveSettings("");                                  
        }

        //close serial ports
        private void ClosePorts()
        {           
            Thread.Sleep(100);
            try
            {                            
                //close serial ports              
                if(serialPort1.IsOpen)
                {                                                           
                    serialPort1.Close();                                        
                }

                if(serialPort2.IsOpen)
                {                                                          
                    serialPort2.Close();
                }  
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }    
        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (ticksRx1 > 0)
            {
                ticksRx1--;
            }
           
            if (ticksRx2 > 0)
            {
                ticksRx2--;
            }
           
            if (ticksTx1 > 0)
            {
                ticksTx1--;
            }
           
            if (ticksTx2 > 0)
            {
                ticksTx2--;
            }
                      
            if (ticks == 0)
            {                              
                try
                {
                    if (serialPort1.IsOpen && checkSend1.Checked == true)
                    {
                        if (serialPort1.BytesToWrite < 10000)
                        {

                            byte[] b = new byte[1];
                            //for (int i = 0; i <= 255; i++)
                            //{
                            //    b[i] = (byte)i;
                            //}
                            b[0] = tx1++;
                            serialPort1.Write(b, 0, 1);
                            //serialPort1.Write(b, 0, 256);
                            Update(b, textTx1);
                        }
                    }

                    if (serialPort2.IsOpen && checkSend2.Checked == true)
                    {
                        if (serialPort2.BytesToWrite < 10000)
                        {
                            byte[] b = new byte[1];
                            //for (int i = 0; i <= 255; i++)
                            //{
                            //    b[i] = (byte)i;
                            //}
                            b[0] = tx2++;
                            serialPort2.Write(b, 0, 1);
                            //serialPort2.Write(b, 0, 256);
                            Update(b, textTx2);                            
                        }                        
                    }
                }
                catch (Exception e1)
                {
                    if (mb == false)
                    {
                        MessageBox.Show(e1.Message);
                        ticks = 100;
                        mb = true;
                    }
                }
            }
            else
            {
                ticks--;
            }
        }

        //update rx and tx textboxes
        private void Update(byte[] array, TextBox tb)
        {

            if (array.Length > max) 
                max = array.Length;
                                                            
            foreach (byte b in array)
            {
                //hex
                int value = Convert.ToInt32(b);
                string hex = String.Format("{0:x2} ", value);
                             
                //ASCII                       
                StringBuilder builder = new StringBuilder();
                builder.Append(b > 32 && b < 127 ? (char)b : '.');
                string asc = builder.ToString();
                
                if (tb == textRx1)
                {                    
                    lineRxHex1 += hex;
                    lineRxAsc1 += asc;

                    if (fastRx1 == false) //slow data write individual bytes to display
                    {
                        SetText(hex, tb);
                        SetText(asc, textRxAsc1);
                    }
                 
                    if (lineRxHex1.Length >= 96)
                    {

                        WriteCapture(lineRxHex1, lineRxAsc1, tb);

                        if (fastRx1 == false)
                        {
                            SetText(Environment.NewLine, tb);
                            SetText(Environment.NewLine, textRxAsc1);
                        }
                        else
                        {   //fast data write whole line to display
                            lineRxHex1 += Environment.NewLine;
                            lineRxAsc1 += Environment.NewLine;

                            SetText(lineRxHex1, tb);
                            SetText(lineRxAsc1, textRxAsc1);
                        }
                        
                        lineRxHex1 = "";
                        lineRxAsc1 = "";

                        //check for fast data
                        if (array.Length > 200)
                        {
                            fastRx1 = true;
                            ticksRx1 = 100;
                        }
                        else if (ticksRx1 == 0)
                        {
                            fastRx1 = false;
                        }
                    }
                }

                else if (tb == textRx2)
                {                    
                    lineRxHex2 += hex;
                    lineRxAsc2 += asc;

                    if (fastRx2 == false)
                    {
                        SetText(hex, tb);
                        SetText(asc, textRxAsc2);
                    }

                    if (lineRxHex2.Length >= 96)
                    {
                        WriteCapture(lineRxHex2, lineRxAsc2, tb);

                        if (fastRx2 == false)
                        {
                            SetText(Environment.NewLine, tb);
                            SetText(Environment.NewLine, textRxAsc2);
                        }
                        else
                        {
                            lineRxHex2 += Environment.NewLine;
                            lineRxAsc2 += Environment.NewLine;

                            SetText(lineRxHex2, tb);
                            SetText(lineRxAsc2, textRxAsc2);
                        }

                        lineRxHex2 = "";
                        lineRxAsc2 = "";

                        if (array.Length > 200)
                        {
                            fastRx2 = true;
                            ticksRx2 = 100;
                        }
                        else if (ticksRx2 == 0)
                        {
                            fastRx2 = false;
                        }
                    }
                    
                }

                else if (tb == textTx1)
                {                    
                    lineTxHex1 += hex;
                    lineTxAsc1 += asc;

                    if (fastTx1 == false)
                    {
                        SetText(hex, tb);
                        SetText(asc, textTxAsc1);
                    }

                    if (lineTxHex1.Length >= 96)
                    {                       
                        if (fastTx1 == false)
                        {
                            SetText(Environment.NewLine, tb);
                            SetText(Environment.NewLine, textTxAsc1);
                        }
                        else
                        {
                            lineTxHex1 += Environment.NewLine;
                            lineTxAsc1 += Environment.NewLine;

                            SetText(lineTxHex1, tb);
                            SetText(lineTxAsc1, textTxAsc1);
                        }

                        lineTxHex1 = "";
                        lineTxAsc1 = "";

                        if (array.Length > 200)
                        {
                            fastTx1 = true;
                            ticksTx1 = 200;
                        }
                        else if (ticksTx1 == 0)
                        {
                            fastTx1 = false;
                        }
                    }
                   
                }

                else if (tb == textTx2)
                {                    
                    lineTxHex2 += hex;
                    lineTxAsc2 += asc;

                    if (fastTx2 == false)
                    {
                        SetText(hex, tb);
                        SetText(asc, textTxAsc2);
                    }

                    if (lineTxHex2.Length >= 96)
                    {
                        if (fastTx2 == false)
                        {
                            SetText(Environment.NewLine, tb);
                            SetText(Environment.NewLine, textTxAsc2);
                        }
                        else
                        {
                            lineTxHex2 += Environment.NewLine;
                            lineTxAsc2 += Environment.NewLine;

                            SetText(lineTxHex2, tb);
                            SetText(lineTxAsc2, textTxAsc2);
                        }

                        lineTxHex2 = "";
                        lineTxAsc2 = "";

                        if (array.Length > 200)
                        {
                            fastTx2 = true;
                            ticksTx2 = 200;
                        }
                        else if (ticksTx2 == 0)
                        {
                            fastTx2 = false;
                        }
                    }
                }
                                                                
            }
        }

        //write capture file
        private void WriteCapture(string hex, string asc, TextBox tb) 
        {            
            string line = String.Format("{0} {1}", hex, asc);
            
            if (tb == textRx1)
            {
                if (sw1 != null && checkCapture1.Checked)
                {
                    sw1.WriteLine(line);
                    sw1.Flush();
                }
            }

            else if (tb == textRx2 && checkCapture2.Checked)
            {
                if (sw2 != null)
                {
                    sw2.WriteLine(line);
                    sw2.Flush();
                }
            }
        }

        //close capture file
        private void CloseCapture() 
        {
            //close file capture
            try
            {
                if (sw1 != null)
                {
                    if (lineRxHex1.Length > 0)
                    {
                        if (checkCapture1.Checked)
                        {
                            string line = String.Format("{0,-96} {1}", lineRxHex1, lineRxAsc1);
                            sw1.WriteLine(line);
                            sw1.Flush();
                        }
                    }
                    sw1.Close();
                    sw1 = null;
                }

                if (sw2 != null)
                {
                    if (lineRxHex2.Length > 0)
                    {
                        if (checkCapture2.Checked)
                        {
                            string line = String.Format("{0,-96} {1}", lineRxHex2, lineRxAsc2);
                            sw2.WriteLine(line);
                            sw2.Flush();
                        }
                    }
                    sw2.Close();
                    sw2 = null;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        //clear screen button
        private void buttonClear_Click(object sender, EventArgs e)
        {                                   
            textRx1.Clear();
            textRx2.Clear();
            textTx1.Clear();
            textTx2.Clear();
            textRxAsc1.Clear();
            textRxAsc2.Clear();
            textTxAsc1.Clear();
            textTxAsc2.Clear();
        }
        
        //purge capture file button
        private void buttonCapture1_Click(object sender, EventArgs e)
        {

            try
            {
                if (sw1 != null)
                {
                    sw1.Close();
                    sw1 = null;
                }
               
                //String s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);  
                String s = folderPath + "\\rx1.txt";                             
                sw1 = new StreamWriter(s, false);

                s = String.Format("Capture file {0} Cleared", s);
                MessageBox.Show(s, "Capture File Port1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        //purge capture file button
        private void buttonCapture2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sw2 != null)
                {
                    sw2.Close();
                    sw2 = null;
                }
               
                //String s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                String s = folderPath + "\\rx2.txt";
                sw2 = new StreamWriter(s, false);

                s = String.Format("Capture file {0} Cleared", s);
                MessageBox.Show(s, "Capture File Port1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        //advanced settings button
        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult buttonClicked = formAdvancedSettings.ShowDialog();            
        }

        //send text entered into ascii box
        private void textTxAsc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            try
            {
                if (serialPort1.IsOpen)
                {               
                    byte[] b = new byte[1];
                    b[0] = Convert.ToByte(ch);
                    Update(b, textTx1);
                    serialPort1.Write(b, 0, 1);
                }
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        //send text entered into ascii box
        private void textTxAsc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            try
            {
                if (serialPort2.IsOpen)
                {
                    byte[] b = new byte[1];
                    b[0] = Convert.ToByte(ch);
                    Update(b, textTx2);
                    serialPort2.Write(b, 0, 1);
                }
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 formAbout = new AboutBox1();

            formAbout.ShowDialog();
        }
       
        //save settings
        private void SaveSettings(string filename)
        {
            string s;

            if (filename.Length == 0)
            {
                s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                s += "\\SerialToSerial\\serialtoserial.xml";
            }
            else
            {
                s = filename;
            }

            XmlWriter writer;

            try
            {
                writer = XmlWriter.Create(s);

                writer.WriteStartElement("SerialtoSerial"); //root element

                //capture folder
                writer.WriteElementString("CaptureFolder", folderPath);

                //port1
                writer.WriteStartElement("Port1");
                writer.WriteElementString("Name", comboPort1.SelectedItem.ToString());
                writer.WriteElementString("BaudRate", comboBaud1.SelectedItem.ToString());
                writer.WriteElementString("Parity", Enum.GetName(typeof(Parity), formAdvancedSettings.Parity1));
                writer.WriteElementString("StopBits", Enum.GetName(typeof(StopBits), formAdvancedSettings.Stopbits1));
                writer.WriteElementString("Handshake", Enum.GetName(typeof(Handshake), formAdvancedSettings.Handshake1));
                writer.WriteElementString("DataBits", formAdvancedSettings.Databits1.ToString());
                writer.WriteElementString("Forward", checkForward1.Checked.ToString());
                writer.WriteElementString("Send", checkSend1.Checked.ToString());
                writer.WriteElementString("Capture", checkCapture1.Checked.ToString());
                writer.WriteEndElement();

                //port2
                writer.WriteStartElement("Port2");
                writer.WriteElementString("Name", comboPort2.SelectedItem.ToString());
                writer.WriteElementString("BaudRate", comboBaud2.SelectedItem.ToString());
                writer.WriteElementString("Parity", Enum.GetName(typeof(Parity), formAdvancedSettings.Parity2));
                writer.WriteElementString("StopBits", Enum.GetName(typeof(StopBits), formAdvancedSettings.Stopbits2));
                writer.WriteElementString("Handshake", Enum.GetName(typeof(Handshake), formAdvancedSettings.Handshake2));
                writer.WriteElementString("DataBits", formAdvancedSettings.Databits2.ToString());
                writer.WriteElementString("Forward", checkForward2.Checked.ToString());
                writer.WriteElementString("Send", checkSend2.Checked.ToString());
                writer.WriteElementString("Capture", checkCapture2.Checked.ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void ReadSettings(string filename)
        {
            string s;

            if (filename.Length == 0)
            {
                s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                s += "\\SerialToSerial";
                folderPath = s;

                Directory.CreateDirectory(s);
                s += "\\serialtoserial.xml";
            }
            else
            {
                s = filename;
            }
                                   
            try
            {
                               
                if(File.Exists(s))
                {

                    XmlReader reader = XmlReader.Create(s);


                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            s = reader.Name;
                            switch (s)
                            {

                                case "CaptureFolder":

                                    s = reader.ReadString();

                                    if (s.Length == 0)
                                    {
                                        //default to personal documents/SerialToSerial folder
                                        s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                                        s += "\\SerialToSerial";
                                        folderPath = s;
                                    }
                                    else
                                    {
                                        folderPath = s;
                                    }

                                    Directory.CreateDirectory(folderPath);

                                    string s1 = folderPath + "\\rx1.txt";
                                    checkCapture1.Text = s1;
                                    s1 = folderPath + "\\rx2.txt";
                                    checkCapture2.Text = s1;         
                                    break;

                                case "Port1":

                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        string type = reader.NodeType.ToString();

                                        if (reader.IsStartElement())
                                        {
                                            s = reader.Name;
                                            switch (s)
                                            {
                                                case "Name":
                                                    s = reader.ReadString();
                                                    comboPort1.SelectedItem = s;
                                                    break;

                                                case "BaudRate":
                                                    s = reader.ReadString();
                                                    comboBaud1.SelectedItem = s;
                                                    break;

                                                case "Parity":
                                                    s = reader.ReadString();
                                                    formAdvancedSettings.Parity1 = (Parity)Enum.Parse(typeof(Parity), s);
                                                    break;

                                                case "StopBits":
                                                    s = reader.ReadString();
                                                    formAdvancedSettings.Stopbits1 = (StopBits)Enum.Parse(typeof(StopBits), s);
                                                    break;

                                                case "Handshake":
                                                    s = reader.ReadString();
                                                    formAdvancedSettings.Handshake1 = (Handshake)Enum.Parse(typeof(Handshake), s);
                                                    break;

                                                case "DataBits":
                                                    s = reader.ReadString();
                                                    formAdvancedSettings.Databits1 = Convert.ToInt16(s);
                                                    break;

                                                case "Forward":
                                                    s = reader.ReadString();
                                                    if (s == "True")
                                                        checkForward1.Checked = true;
                                                    else
                                                        checkForward1.Checked = false;
                                                    break;

                                                case "Send":
                                                    s = reader.ReadString();
                                                    if (s == "True")
                                                        checkSend1.Checked = true;
                                                    else
                                                        checkSend1.Checked = false;
                                                    break;

                                                case "Capture":
                                                    s = reader.ReadString();
                                                    if (s == "True")
                                                        checkCapture1.Checked = true;
                                                    else
                                                        checkCapture1.Checked = false;
                                                    break;
                                            }
                                        } //if (reader.IsStartElement()) 
                                    } //while(reader.Read() && reader.NodeType != XmlNodeType.EndElement)                            
                                    break;

                                case "Port2":

                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        string type = reader.NodeType.ToString();

                                        if (reader.IsStartElement())
                                        {
                                            s = reader.Name;
                                            switch (s)
                                            {
                                                case "Name":
                                                    s = reader.ReadString();
                                                    comboPort2.SelectedItem = s;
                                                    break;

                                                case "BaudRate":
                                                    s = reader.ReadString();
                                                    comboBaud2.SelectedItem = s;
                                                    break;

                                                case "Parity":
                                                    s = reader.ReadString();
                                                    formAdvancedSettings.Parity2 = (Parity)Enum.Parse(typeof(Parity), s);
                                                    break;

                                                case "StopBits":
                                                    s = reader.ReadString();
                                                    formAdvancedSettings.Stopbits2 = (StopBits)Enum.Parse(typeof(StopBits), s);
                                                    break;

                                                case "Handshake":
                                                    s = reader.ReadString();
                                                    formAdvancedSettings.Handshake2 = (Handshake)Enum.Parse(typeof(Handshake), s);
                                                    break;

                                                case "DataBits":
                                                    s = reader.ReadString();
                                                    formAdvancedSettings.Databits2 = Convert.ToInt16(s);
                                                    break;

                                                case "Forward":
                                                    s = reader.ReadString();
                                                    if (s == "True")
                                                        checkForward2.Checked = true;
                                                    else
                                                        checkForward2.Checked = false;
                                                    break;

                                                case "Send":
                                                    s = reader.ReadString();
                                                    if (s == "True")
                                                        checkSend2.Checked = true;
                                                    else
                                                        checkSend2.Checked = false;
                                                    break;

                                                case "Capture":
                                                    s = reader.ReadString();
                                                    if (s == "True")
                                                        checkCapture2.Checked = true;
                                                    else
                                                        checkCapture2.Checked = false;
                                                    break;
                                            }
                                        } //if (reader.IsStartElement()) 
                                    } //while(reader.Read() && reader.NodeType != XmlNodeType.EndElement)                            
                                    break;
                                }
                            }
                        }
                        reader.Close();
                }   //if(File.Exists(s))             
            }
            catch (System.IO.FileNotFoundException)
            {
                //file not found 
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        //restore defaults
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All settings about to be restored to default values!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                comboPort1.SelectedItem = "None";
                comboPort2.SelectedItem = "None";
                comboBaud1.SelectedIndex = 3;
                comboBaud2.SelectedIndex = 3;

                formAdvancedSettings.Handshake1 = Handshake.None;
                formAdvancedSettings.Handshake2 = Handshake.None;
                formAdvancedSettings.Stopbits1 = StopBits.One;
                formAdvancedSettings.Stopbits2 = StopBits.One;
                formAdvancedSettings.Parity1 = Parity.None;
                formAdvancedSettings.Parity2 = Parity.None;
                formAdvancedSettings.Databits1 = 8;
                formAdvancedSettings.Databits2 = 8;

                checkCapture1.Checked = false;
                checkCapture2.Checked = false;
                checkForward1.Checked = false;
                checkForward2.Checked = false;
                checkSend1.Checked = false;
                checkSend2.Checked = false;

                //default to personal documents/SerialToSerial folder
                string s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                s += "\\SerialToSerial";
                folderPath = s;   
                                 
                Directory.CreateDirectory(folderPath);

                s = folderPath + "\\rx1.txt";
                checkCapture1.Text = s;
                s = folderPath + "\\rx2.txt";
                checkCapture2.Text = s;         

                MessageBox.Show("Settings restored!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //set capture folder
        private void setCaptureFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = folderBrowserDialog1.SelectedPath;

                if (s.Length == 0)
                {
                    //default to personal documents/SerialToSerial folder
                    s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    s += "\\SerialToSerial";
                    folderPath = s;
                }
                else
                {
                    folderPath = s;
                }

                Directory.CreateDirectory(folderPath);

                string s1 = folderPath + "\\rx1.txt";
                checkCapture1.Text = s1;
                s1 = folderPath + "\\rx2.txt";
                checkCapture2.Text = s1;         
            }
        }

        //load settings from selected file
        private void loadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openBrowserDialog = new OpenFileDialog();

            string s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            s += "\\SerialToSerial";
            openBrowserDialog.InitialDirectory = s;

            openBrowserDialog.DefaultExt = "xml";           
            openBrowserDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (openBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openBrowserDialog.FileName;
                ReadSettings(filename);
            }

        }

        //save settings to selected file
        private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveBrowserDialog = new SaveFileDialog();

            string s = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            s += "\\SerialToSerial";
            saveBrowserDialog.InitialDirectory = s;

            saveBrowserDialog.DefaultExt = "xml";
            saveBrowserDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveBrowserDialog.FileName;
                SaveSettings(filename);
            }
            
        }

        //display operation reference
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
            string path = Directory.GetCurrentDirectory();
            path += "\\Serial to Serial.pdf";
            
            System.Diagnostics.Process.Start(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "";

                openFileDialog1.InitialDirectory = "C:\\tfs_projects\\InformerIP\\main\\Debug\\Exe";
                DialogResult buttonClicked = openFileDialog1.ShowDialog();
                if (buttonClicked == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                        {
                            byte[] b = new byte[1];

                            b[0] = 0x02; //STX
                            serialPort1.Write(b, 0, 1);

                            for(int i = 0; i < 10000; i++)
                            {
                               
                                String line = sr.ReadLine();

                                if (line == null)
                                {
                                    break;
                                }

                                line += "\r\n";

                                serialPort1.Write(line);

                                byte[] array = System.Text.Encoding.UTF8.GetBytes(line);
                                Update(array, textTx1);

                                //byte[] array = System.Text.Encoding.UTF8.GetBytes(line);
                            }

                            b[0] = 0x03; //ETX
                            serialPort1.Write(b, 0, 1);
                           
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }


                }
                
                serialPort1.Write(s);

                //byte[] array = System.Text.Encoding.UTF8.GetBytes(s);
                //Update(array, textTx1);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string s = "AT&FE0V1&C1&D2S95=47S0=0\r";            
            string s = "at+ctsp=1,3,130\r\n";
            serialPort1.Write(s);

            byte[] array = System.Text.Encoding.UTF8.GetBytes(s);
            Update(array, textTx1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string s = "ATS0=0\r";
            //string s = "at+ctsp=1,3,130\r\n";
            string s = "at+ctsds=12,0,0,0\r\n"; //SDS type4, SSI, area not defined, low priority
            serialPort1.Write(s);

            byte[] array = System.Text.Encoding.UTF8.GetBytes(s);
            Update(array, textTx1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string s = "AT&FE0V1&C1&D2S95=47S0=0\r";           
            string s = "at+ctom=1\r\n"; //dmo mode
            serialPort1.Write(s);

            byte[] array = System.Text.Encoding.UTF8.GetBytes(s);
            Update(array, textTx1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string s = "ATS7=60L0M1&K3N1X4\r";
            string s = "at+ctdct=1\r\n"; //direct ms-ms
            serialPort1.Write(s);

            byte[] array = System.Text.Encoding.UTF8.GetBytes(s);
            Update(array, textTx1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string s = "ATS0=0\r";

            string str = "I need to poop";
            string hex = ConvertStringToHex(str);
            int length = str.Length * 8;

            string s = string.Format("at+cmgs={0},{1}\r\n{2}{3}\x1a", 100, length + 32, "8204E301", hex);

            //string s = "AT+CMGS=100,88\r\n8204E301 30 45 4C 50 20 4D 30\x1a";
            serialPort1.Write(s);

            byte[] array = System.Text.Encoding.UTF8.GetBytes(s);
            Update(array, textTx1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //string s = "8204E301 48454C50204D45\x1a";
            string s = "8204E30130454C50204D30\x1a";
            serialPort1.Write(s);

            byte[] array = System.Text.Encoding.UTF8.GetBytes(s);
            Update(array, textTx1);
        }


        public string ConvertStringToHex(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
            {      
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }
                                          
    }
}
