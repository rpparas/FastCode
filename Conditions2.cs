using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class Conditions2 : Form
    {
        private Boolean JustAdded;
        private String label = "Click to add/edit expression.";
        public static String left;
        public static String right;
        private int SelectedButton;

        public static int LEFT_EXPR = 1;
        public static int RIGHT_EXPR = 2;


        public Conditions2()
        {
            InitializeComponent();
            DisableComponents();
            left = label;
            right = label;
        }

        private void DisableComponents()
        {
            switch (SelectedButton)
            {
                case 0:
                    LeftButton.Enabled = false;
                    Operator.Enabled = false;
                    RightButton.Enabled = false;
                    richTextBox1.Enabled = false;
                    RightButton.Enabled = false;
                    GenerateButton.Enabled = false;
                    LocationCombo.Enabled = false;
                    break;

                default:
                    LeftButton.Enabled = true;
                    break;
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            Form ExprLeft = new Expression(LEFT_EXPR);
            ExprLeft.Location = new Point(150, 150);
            ExprLeft.ShowDialog();
            JustAdded = true;

            Operator.Enabled = true;
            RightButton.Enabled = true;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            Form ExprRight = new Expression(RIGHT_EXPR);
            ExprRight.Location = new Point(150, 150);
            ExprRight.ShowDialog();
            JustAdded = true;

            richTextBox1.Enabled = true;
            GenerateButton.Enabled = true;
        }

        private void Conditions_MouseMove(object sender, MouseEventArgs e)
        {
            if (JustAdded)
            {
                LeftButton.Text = left.Trim() == "" ? label : left;
                RightButton.Text = right.Trim() == "" ? label : right;
                JustAdded = false;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (GenerateButton.Text == "Generate Code")
            {
                GenerateButton.Text = "Insert Code";
            }
            else
            {
                //pass contents
                this.Close();
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            GenerateButton.Text = "Append Code";
            GenerateButton_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedButton = 1;
            DisableComponents();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}