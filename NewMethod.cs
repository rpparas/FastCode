using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class NewMethod : Form
    {
        private String ClassName;
        private Boolean successful;
        public static String OtherDataType;
        public static int ArrayDimension;
        private ArrayList parameters;


        public NewMethod(String ClassName)
        {
            OtherDataType = "";
            ArrayDimension = 0;
            this.ClassName = ClassName;
            this.parameters = new ArrayList();
            InitializeComponent();
        }
        
        
        public void OverrideComponents(TextBox MethodName, ComboBox ReturnType, RadioButton PublicRadio, RadioButton PrivateRadio,
                                       CheckBox StaticCheck, CheckBox FinalCheck)
        {
            this.MethodName = MethodName;
            this.ReturnType = ReturnType;
            this.PublicRadio = PublicRadio;
            this.PrivateRadio = PrivateRadio;
            this.StaticCheck = StaticCheck;
            this.FinalCheck = FinalCheck;
        }

        public Boolean ProcessContents()
        {
            OK_Click(null, null);
            return successful;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            successful = false;
            if(CheckMethodName())
            {
                if (CheckReturnType())
                {
                    CreateMethod();
                    if (successful)
                    {
                        this.Close();
                    }
                }
            }
        }

        private Boolean CheckMethodName()
        {
            int error = SyntaxChecker.Check(MethodName.Text);
            switch (error)
            {
                case 1:
                    MessageBox.Show("Please supply a name for this method.", "Invalid Method Name");
                    break;

                case 2:
                    MessageBox.Show("Method name must begin with a letter.", "Invalid Method Name");
                    break;

                case 3:
                    MessageBox.Show("Method name must not end with an underscore.", "Invalid Method Name");
                    break;

                case 4:
                    MessageBox.Show("Consecutive underscores are invalid.", "Invalid Method Name");
                    break;

                case 5:
                    MessageBox.Show("Please use letters, digits and underscores only.", "Invalid Method Name");
                    break;
            }
            if (error == SyntaxChecker.NO_ERROR)
            {
                return true;
            }
            else
            {
                MethodName.SelectAll();
                MethodName.Focus();
                return false;
            }
        }

        private Boolean CheckReturnType()
        {
            String type = ReturnType.Text;
            type = type.Replace("[]", "");

            int error = SyntaxChecker.Check(type);
            switch (error)
            {
                case 1:
                    MessageBox.Show("Please supply a return type for this method.", "Invalid Method Type");
                    break;

                case 2:
                    MessageBox.Show("Method type must begin with a letter.", "Invalid Method Type");
                    break;

                case 3:
                    MessageBox.Show("Method type must not end with an underscore.", "Invalid Method Type");
                    break;

                case 4:
                    MessageBox.Show("Consecutive underscores are invalid.", "Invalid Method Type");
                    break;

                case 5:
                    MessageBox.Show("Please use letters, digits and underscores only.", "Invalid Method Type");
                    break;
            }

            if (error == SyntaxChecker.NO_ERROR)
            {
                return true;
            }
            else
            {
                ReturnType.SelectAll();
                ReturnType.Focus();
                return false;
            }
        }

        private void CreateMethod()
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
            else if (ProtectedRadio.Checked)
            {
                access = "protected";
            }

            ArrayList attributes = new ArrayList();
            if (FinalCheck.Checked)
            {
                attributes.Add("final");
                MethodName.Text = MethodName.Text.ToUpper();
            }

            if (AbstractCheck.Checked)
            {
                attributes.Add("abstract");
            }

            if (StaticCheck.Checked)
            {
                attributes.Add("static");
            }

            if (SynchronizedCheck.Checked)
            {
                attributes.Add("synchronized");
            }

            String[] attr = ToStringArray(attributes.ToArray());

            Method m = new Method();
            m.Name = MethodName.Text;
            if (ReturnType.Text == "boolean")
            {
                m.ReturnType = "bool";
            }
            else if (ReturnType.Text == "character")
            {
                m.ReturnType = "char";
            }
            else if (ReturnType.Text == "integer")
            {
                m.ReturnType = "int";
            }
            else
            {
                m.ReturnType = ReturnType.Text;
            }
            m.Access = access;
            m.Attributes = attr;
            m.Parameters = parameters;
            m.Comments = Comments.Text;
            m.Code = Code.Text;

            ClassInfo ci = ClassFiles.GetClassInfo(ClassName + ".java");
            if (ci.AddMethod(m))
            {
                ClassFiles.Add(ci);
                successful = true;
                Close();
            }
            else
            {
                MessageBox.Show("Method of same name and parameter types exists.", "Improper Method Overloading");
                successful = false;
            }
        }

        private String[] ToStringArray(Object[] attributes)
        {
            String[] attr = new String[attributes.Length];
            for (int i = 0; i < attr.Length; i++)
            {
                attr[i] = (String)attributes[i];
            }
            return attr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataType form = new DataType(ReturnType.Text, DataType.Method);
            form.ShowDialog();
            if (OtherDataType != null)
            {
                ReturnType.Text = OtherDataType;
                for (int i = 0; i < ArrayDimension; i++)
                {
                    ReturnType.Text += "[]";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Parameters param = new Parameters(ClassName + ".java");
            param.ShowDialog();
            if (param.Successful)
            {
                this.parameters = param.ParameterList;
                Object[] var = this.parameters.ToArray();
                Parameters.Items.Clear();
                for (int i = 0; i < var.Length; i++)
                {
                    Variable v = (Variable)var[i];
                    Parameters.Items.Add(v.Type + " : " + v.Name);
                }
            }
        }
    }
}