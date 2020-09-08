using System;
using System.Windows.Forms;

namespace areyesram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = InputBox.Prompt("Please tell me your name", "Question #1");
            if (text != null)
                label1.Text = text;
        }
    }
}
