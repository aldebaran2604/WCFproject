using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WindowsClient1
{
    public partial class Form1 : Form
    {
        private IMathService basicHttpChannel = null;
        private IMathService wsHttpChannel = null;
        private IMathService nettcpChannel = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            basicHttpChannel = new ChannelFactory<IMathService>("MathService_BasicHttp")
                .CreateChannel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyNumbers mynumbers = new MyNumbers()
            {
                Number1 = Convert.ToInt32(textBox1.Text),
                Number2 = Convert.ToInt32(textBox2.Text)
            };

            textBox3.Text = basicHttpChannel.Add(mynumbers).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyNumbers mynumbers = new MyNumbers()
            {
                Number1 = Convert.ToInt32(textBox1.Text),
                Number2 = Convert.ToInt32(textBox2.Text)
            };

            textBox3.Text = basicHttpChannel.Subtract(mynumbers).ToString();
        }
    }
}
