using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class NewObject : Form
    {
        private String TabName;
        private Boolean successful;
        
        public NewObject(String TabName)
        {
            InitializeComponent();
            this.TabName = TabName;
        }

        public void OverrideComponents(TextBox ObjectName, ComboBox ObjectType, ComboBox Inherit, 
                                    RadioButton PublicRadio, RadioButton DefaultRadio, CheckBox FinalCheck)
        {
            this.ObjectName = ObjectName;
            this.ObjectType = ObjectType;
            this.Inherit = Inherit;
            this.PublicRadio = PublicRadio;
            this.DefaultRadio = DefaultRadio;
            this.FinalCheck = FinalCheck;
        }

        public Boolean ProcessContents()
        {
            OK_Click(null, null);
            return successful;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            ObjectName.Text = ObjectName.Text.Trim();
            ObjectType.Text = ObjectType.Text.Trim();
            Inherit.Text = Inherit.Text.Trim();
            successful = false;

            if (!CheckName(ObjectName.Text))
            {
                ObjectName.SelectAll();
                ObjectName.Focus();
                return;
            }

            if (!CheckType())
            {
                ObjectType.SelectAll();
                ObjectType.Focus();
                return;
            }

            if (Inherit.Text != "" && !CheckName(Inherit.Text))
            {
                Inherit.SelectAll();
                Inherit.Focus();
                return;
            }

            successful = true;
            CreateClass();
        }

        private Boolean CheckName(String name)
        {
            int error = SyntaxChecker.Check(name);
            switch (error)
            {
                case 1:
                    MessageBox.Show("Please supply a name for this object.", "Invalid Project Name");
                    break;
                case 2:
                    MessageBox.Show("Name of object must begin with a letter.", "Invalid Project Name");
                    break;
                case 3:
                    MessageBox.Show("Name of object must not end with an underscore.", "Invalid Project Name");
                    break;
                case 4:
                    MessageBox.Show("Consecutive underscores are invalid.", "Invalid Project Name");
                    break;
                case 5:
                    MessageBox.Show("Please use letters, digits and underscores only.", "Invalid Project Name");
                    break;
                default:
                    return true;
            }
            return false;
        }

        public Boolean CheckType()
        {
            if (ObjectType.Items.Contains(ObjectType.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select a valid object type", "Object Type");
                return false;
            }
        }

        private void CreateClass()
        {
            String access = "";
            if (PublicRadio.Checked)
            {
                access = "public";
            }
            else if (PrivateRadio.Checked)
            {
                access = "private";
            }

            String attribute = (FinalCheck.Checked ? "final" : "");

            ClassInfo ci = new ClassInfo();
            ci.FileName = TabName;
            ci.ClassName = ObjectName.Text;
            ci.Type = ObjectType.Text;
            ci.Access = access;
            ci.Attribute = attribute;
            ci.Inherit = Inherit.Text;
            ci.Comments = comments.Text;

            ClassFiles.Add(ci);
            Types.AddClass(ci);
            Close();
        }

        private void NewObject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                OK_Click(null, null);
            }
        }
    }
}