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

namespace SerialtoSerial
{
    public partial class AdvancedSettings : Form
    {

        private string handshake1;
        private string handshake2;
        private string parity1;
        private string parity2;
        private string stopbits1;
        private string stopbits2;
        private string databits1;
        private string databits2;
        //private Boolean ok_cancel;
       
        public Handshake Handshake1
        {
            get
            {
                return (Handshake)Enum.Parse(typeof(Handshake), handshake1);
            }
            set
            {
                handshake1 = Enum.GetName(typeof (Handshake), value);
                comboHandshake1.SelectedItem = handshake1;
            }
        }

        public Handshake Handshake2
        {
            get
            {
                return (Handshake)Enum.Parse(typeof(Handshake), handshake2);
            }
            set
            {
                handshake2 = Enum.GetName(typeof(Handshake), value);
                comboHandshake2.SelectedItem = handshake2;
            }
        }

        public Parity Parity1
        {
            get
            {
                return (Parity)Enum.Parse(typeof(Parity), parity1);
            }
            set
            {
                parity1 = Enum.GetName(typeof(Parity), value);
                comboParity1.SelectedItem = parity1;
            }
        }

        public Parity Parity2
        {
            get
            {
                return (Parity)Enum.Parse(typeof(Parity), parity2);
            }
            set
            {
                parity2 = Enum.GetName(typeof(Parity), value);
                comboParity2.SelectedItem = parity2;
            }
        }

        public StopBits Stopbits1
        {
            get
            {
                return (StopBits)Enum.Parse(typeof(StopBits), stopbits1);
            }
            set
            {
                stopbits1 = Enum.GetName(typeof(StopBits), value);
                comboStopbits1.SelectedItem = stopbits1;
            }
        }

        public StopBits Stopbits2
        {
            get
            {
                return (StopBits)Enum.Parse(typeof(StopBits), stopbits2);
            }
            set
            {
                stopbits2 = Enum.GetName(typeof(StopBits), value);
                comboStopbits1.SelectedItem = stopbits2;
            }
        }

        public int Databits1
        {
            get
            {
                int i = Convert.ToInt16(databits1);
                return i;
            }
            set
            {
                databits1 = value.ToString();
                comboStopbits1.SelectedItem = databits1;
            }
        }

        public int Databits2
        {
            get
            {
                int i = Convert.ToInt16(databits2);
                return i;
            }
            set
            {
                databits2 = value.ToString();
                comboStopbits1.SelectedItem = databits2;
            }
        }

        public AdvancedSettings()
        {
            InitializeComponent();
        }

        //init controls
        public void Init()
        {
            //handshake
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                comboHandshake1.Items.Add(s);
                comboHandshake2.Items.Add(s);
            }
            comboHandshake1.SelectedIndex = 0;
            comboHandshake2.SelectedIndex = 0;
            handshake1 = comboHandshake1.SelectedItem.ToString();
            handshake2 = comboHandshake1.SelectedItem.ToString();

            //parity
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                comboParity1.Items.Add(s);
                comboParity2.Items.Add(s);
            }
            comboParity1.SelectedIndex = 0;
            comboParity2.SelectedIndex = 0;
            parity1 = comboParity1.SelectedItem.ToString();
            parity2 = comboParity2.SelectedItem.ToString();

            //stop bits
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                comboStopbits1.Items.Add(s);
                comboStopbits2.Items.Add(s);
            } 
            comboStopbits1.SelectedIndex = 1;
            comboStopbits2.SelectedIndex = 1;
            stopbits1 = comboStopbits1.SelectedItem.ToString();
            stopbits2 = comboStopbits2.SelectedItem.ToString();
           
            //data bits
            for(int i = 5; i <= 8; i++)
            {
                comboDatabits1.Items.Add(i.ToString());
                comboDatabits2.Items.Add(i.ToString());
            }
            comboDatabits1.SelectedIndex = 3;
            comboDatabits2.SelectedIndex = 3;
            databits1 = comboDatabits1.SelectedItem.ToString();
            databits2 = comboDatabits2.SelectedItem.ToString();
            
        }

        //ok button
        private void buttonOk_Click(object sender, EventArgs e)
        {           
            DialogResult = DialogResult.OK;
            Close();
        }

        //cancel button
        private void buttonCancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Settings will not be saved", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                DialogResult = DialogResult.No;
                Close();
            }
        }

        private void Setup_Shown(object sender, EventArgs e)
        {
            //update controls
            comboDatabits1.SelectedItem = databits1;
            comboDatabits2.SelectedItem = databits2;
            comboStopbits1.SelectedItem = stopbits1;
            comboStopbits2.SelectedItem = stopbits2;
            comboParity1.SelectedItem = parity1;
            comboParity2.SelectedItem = parity2;
            comboHandshake1.SelectedItem = handshake1;
            comboHandshake2.SelectedItem = handshake2;           
        }

        private void AdvancedSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (DialogResult != DialogResult.No)
            {
                //update fields
                handshake1 = comboHandshake1.SelectedItem.ToString();
                handshake2 = comboHandshake2.SelectedItem.ToString();
                parity1 = comboParity1.SelectedItem.ToString();
                parity2 = comboParity2.SelectedItem.ToString();
                stopbits1 = comboStopbits1.SelectedItem.ToString();
                stopbits2 = comboStopbits2.SelectedItem.ToString();
                databits1 = comboDatabits1.SelectedItem.ToString();
                databits2 = comboDatabits2.SelectedItem.ToString();
            }

        }
    }
}
