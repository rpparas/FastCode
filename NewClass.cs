using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class NewClass : Form
    {
        private bool successful;

        public NewClass(String contents)
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

        public bool HasConstructor
        {
            set
            {
                ConstructorCheck.Checked = value;
            }
            get
            {
                return ConstructorCheck.Checked;
            }
        }

        public bool HasMain
        {
            set
            {
                MainCheck.Checked = value;
            }
            get
            {
                return MainCheck.Checked;
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
            if (CheckName(Contents))
            {
                this.Close();
            }
        }

        private Boolean CheckName(String name)
        {
            int error = SyntaxChecker.Check(name);
            switch (error)
            {
                case 1:
                    MessageBox.Show("Please supply a name for this class.", "Invalid Project Name");
                    break;
                case 2:
                    MessageBox.Show("Name of class must begin with a letter.", "Invalid Project Name");
                    break;
                case 3:
                    MessageBox.Show("Name of class must not end with an underscore.", "Invalid Project Name");
                    break;
                case 4:
                    MessageBox.Show("Consecutive underscores are invalid.", "Invalid Project Name");
                    break;
                case 5:
                    MessageBox.Show("Please use letters, digits and underscores only.", "Invalid Project Name");
                    break;
                default:
                    successful = true;
                    return true;
            }
            return false;
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