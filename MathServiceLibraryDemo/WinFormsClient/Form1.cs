using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        MathServiceReference.MathServiceClient client = null;
        public Form1()
        {
            client = new MathServiceReference.MathServiceClient();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            MathServiceReference.MyNumbers numbers = new MathServiceReference.MyNumbers()
            {
                Number1 = a,
                Number2 = b
            };

            int c = client.Add(numbers);

            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            MathServiceReference.MyNumbers numbers = new MathServiceReference.MyNumbers()
            {
                Number1 = a,
                Number2 = b
            };

            int c = client.Subtract(numbers);

            textBox3.Text = c.ToString();
        }
    }
}
