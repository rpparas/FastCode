using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class Edit : Form
    {
        private bool successful;

        public Edit(String contents)
        {
            InitializeComponent();
            Contents = contents;
        }

        public String Contents
        {
            set
            {
                textBox1.Text = value;
            }
            get
            {
                return textBox1.Text.Trim();
            }
        }
        
        public bool Successful
        {
            get
            {
                return successful;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            successful = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            successful = false;
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = Contents == "";
        }


    }
}