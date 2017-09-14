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

namespace WindowsClient3
{
    public partial class Form1 : Form
    {
        private IMathService channel = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var endPoint = new EndpointAddress(
                "net.tcp://127.0.0.1:6666/IMathService"
            );

            channel = ChannelFactory<IMathService>
                .CreateChannel(
                    new NetTcpBinding(),
                    endPoint
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyNumbers mynumbers = new MyNumbers()
            {
                Number1 = Convert.ToInt32(textBox1.Text),
                Number2 = Convert.ToInt32(textBox2.Text)
            };

            textBox3.Text = channel.Add(mynumbers).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyNumbers mynumbers = new MyNumbers()
            {
                Number1 = Convert.ToInt32(textBox1.Text),
                Number2 = Convert.ToInt32(textBox2.Text)
            };

            textBox3.Text = channel.Subtract(mynumbers).ToString();
        }
    }
}
