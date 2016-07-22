using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HubGPIOtoVClock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ConnectToGPIO();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logTextBox.Text += "GPIO to VClock App loaded\r\n";
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseDevice();
        }

        [DllImport("k8055d.dll")]
        public static extern int OpenDevice(int CardAddress);

        [DllImport("k8055d.dll")]
        public static extern void CloseDevice();

        [DllImport("k8055d.dll")]
        public static extern int ReadAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void ReadAllAnalog(ref int Data1, ref int Data2);

        [DllImport("k8055d.dll")]
        public static extern void OutputAnalogChannel(int Channel, int Data);

        [DllImport("k8055d.dll")]
        public static extern void OutputAllAnalog(int Data1, int Data2);

        [DllImport("k8055d.dll")]
        public static extern void ClearAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void SetAllAnalog();

        [DllImport("k8055d.dll")]
        public static extern void ClearAllAnalog();

        [DllImport("k8055d.dll")]
        public static extern void SetAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void WriteAllDigital(int Data);

        [DllImport("k8055d.dll")]
        public static extern void ClearDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void ClearAllDigital();

        [DllImport("k8055d.dll")]
        public static extern void SetDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void SetAllDigital();

        [DllImport("k8055d.dll")]
        public static extern bool ReadDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern int ReadAllDigital();

        [DllImport("k8055d.dll")]
        public static extern int ReadCounter(int CounterNr);

        [DllImport("k8055d.dll")]
        public static extern void ResetCounter(int CounterNr);

        [DllImport("k8055d.dll")]
        public static extern void SetCounterDebounceTime(int CounterNr, int DebounceTime);

        [DllImport("k8055d.dll")]
        public static extern int Version();

        [DllImport("k8055d.dll")]
        public static extern int SearchDevices();

        [DllImport("k8055d.dll")]
        public static extern int SetCurrentDevice(int lngCardAddress);

        [DllImport("k8055d.dll")]
        public static extern int ReadBackDigitalOut();

        [DllImport("k8055d.dll")]
        public static extern void ReadBackAnalogOut(int[] Buffer);

        private void ConnectToGPIO()
        {
            int cardAddr = 3 - (Convert.ToInt32(addressCheck1.Checked) + Convert.ToInt32(addressCheck2.Checked) * 2);
            int h = OpenDevice(cardAddr);
            switch (h)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    logTextBox.Text += "Card " + h.ToString() + " connected\r\n";
                    pollTimer.Enabled = true;
                    break;
                case -1:
                    logTextBox.Text += "Card " + h.ToString() + " connected\r\n";
                    break;
            }
        }


        private void pollTimer_Tick(object sender, EventArgs e)
        {
            pollTimer.Enabled = false;
            // Read the digital values
            int i = ReadAllDigital();
            inputCheck1.Checked = (i & 1) > 0;
            inputCheck2.Checked = (i & 2) > 0;
            inputCheck3.Checked = (i & 4) > 0;
            inputCheck4.Checked = (i & 8) > 0;
            inputCheck5.Checked = (i & 16) > 0;
            pollTimer.Enabled = true;

        }


    }
}
