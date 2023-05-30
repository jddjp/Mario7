using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            serialPort1.Open();
            serialPort1.WriteLine("P");
            CheckForIllegalCrossThreadCalls = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            label1.Text = serialPort1.ReadExisting();
            serialPort1.WriteLine("P");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
