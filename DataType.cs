using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class DataType : Form
    {
        public const string Variable = "Variable";
        public const string Method = "Method";

        private String source;

        public DataType(String type, String source)
        {
            this.source = source;
            InitializeComponent();
            AddType(type);
        }

        private void AddType(String type)
        {
            if (type != null && type.Trim() != "")
            {
                OtherDataType.Items.Add(type);
                OtherDataType.Text = type;
            }
        }

        private void ArrayCheck_CheckedChanged(object sender, EventArgs e)
        {
            Dimensions.Enabled = ArrayCheck.Checked;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (OtherDataType.Text.Trim() == "")
            {
                MessageBox.Show("Please specify a data type.", "Missing Data Type");
                return;
            }

            if (source == DataType.Variable)
            {
                NewVariable.OtherDataType = OtherDataType.Text;
                if (ArrayCheck.Checked)
                {
                    NewVariable.ArrayDimension = (int)(Dimensions.Value);
                }
                else
                {
                    NewVariable.ArrayDimension = 0;
                }
            }
            else
            {
                NewMethod.OtherDataType = OtherDataType.Text;
                if (ArrayCheck.Checked)
                {
                    NewMethod.ArrayDimension = (int)(Dimensions.Value);
                }
                else
                {
                    NewMethod.ArrayDimension = 0;
                }
            }
            Close();
        }
    }
}