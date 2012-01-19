using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class NewVariable : Form
    {
        private ClassInfo ci;
        private String methodName;
        private Boolean successful;
        public static String OtherDataType;
        public static int ArrayDimension;

        public NewVariable(ClassInfo ci, String methodName)
        {
            InitializeComponent();
            this.ci = ci;
            this.methodName = methodName;
            Method m = ci.GetMethod(methodName);
            InitializeContents(m);
            EnableComponents(m == null);
        }

        public void OverrideComponents(TextBox VariableName, ComboBox VariableType, TextBox VariableValue, 
                                        RadioButton PublicRadio, RadioButton PrivateRadio, 
                                        CheckBox StaticCheck, CheckBox FinalCheck)
        {
            this.VariableName = VariableName;
            this.VariableType = VariableType;
            this.InitialValue = VariableValue;
            this.PublicRadio = PublicRadio;
            this.PrivateRadio = PrivateRadio;
            this.StaticCheck = StaticCheck;
            this.FinalCheck = FinalCheck;
        }

        private void InitializeContents(Method m)
        {
            VariableType.Items.Clear();
            VariableType.Items.AddRange(Types.Primitive);
            VariableType.Items.AddRange(Types.Supported);
            if (m != null)
            {
                MethodCombo.Enabled = true;
                MethodCombo.Items.Clear();
                MethodCombo.Items.AddRange(ci.MethodNames);
                MethodCombo.SelectedItem = m.Name;
                MethodRadio.Checked = true;
            }
            else
            {
                InstanceRadio.Checked = true;
                if (ci.MethodNames.Length == 0)
                {
                    MethodCombo.Enabled = false;
                }
            }
        }

        public Boolean ProcessContents()
        {
            OK_Click(null, null);
            return successful;
        }

        private void EnableComponents(bool enable)
        {
            AccessGroup3.Enabled = enable;
            AttributesGroup3.Enabled = enable;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            successful = false;
            if(CheckVariableName())
            {
                if(CheckVariableType())
                {
                    if (CheckValue())
                    {
                        if (InstanceRadio.Checked)
                        {
                            CreateInstanceVariable();
                        }
                        else
                        {
                            CreateMethodVariable();
                        }
                        if (successful)
                        {
                            this.Close();
                        }
                    }
                }                
            }
        }

        private Boolean CheckVariableName()
        {
            int error = SyntaxChecker.Check(VariableName.Text);
            switch (error)
            {
                case 1:
                    MessageBox.Show("Please supply a name for this variable.", "Invalid Variable Name");
                    break;

                case 2:
                    MessageBox.Show("Variable name must begin with a letter.", "Invalid Variable Name");
                    break;

                case 3:
                    MessageBox.Show("Variable name must not end with an underscore.", "Invalid Variable Name");
                    break;

                case 4:
                    MessageBox.Show("Consecutive underscores are invalid.", "Invalid Variable Name");
                    break;

                case 5:
                    MessageBox.Show("Please use letters, digits and underscores only.", "Invalid Variable Name");
                    break;
            }

            if (error == SyntaxChecker.NO_ERROR)
            {
                return true;
            }
            else
            {
                VariableName.SelectAll();
                VariableName.Focus();
                return false;
            }
        }

        private Boolean CheckVariableType()
        {
            String type = VariableType.Text;
            type = type.Replace("[]", "");
            
            int error = SyntaxChecker.Check(type);
            switch (error)
            {
                case 1:
                    MessageBox.Show("Please supply a data type for the variable.", "Invalid Variable Type");
                    break;

                case 2:
                    MessageBox.Show("Variable type must begin with a letter.", "Invalid Variable Type");
                    break;

                case 3:
                    MessageBox.Show("Variable type must not end with an underscore.", "Invalid Variable Type");
                    break;

                case 4:
                    MessageBox.Show("Consecutive underscores are invalid.", "Invalid Variable Type");
                    break;

                case 5:
                    MessageBox.Show("Please use letters, digits and underscores only.", "Invalid Variable Type");
                    break;
            }

            

            if (error == SyntaxChecker.NO_ERROR)
            {
                return true;
            }
            else
            {
                VariableType.SelectAll();
                VariableType.Focus();
                return false;
            }
        }

        private Boolean CheckValue()
        {
            if (InitialValue.Text != "" && !Types.IsMatch(VariableType.Text, InitialValue.Text))
            {
                MessageBox.Show("Initial value of the variable doesn't match its type.", "Mismatched Type");
                return false;
            }
            return true;
        }

        private void CreateInstanceVariable()
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
            if (StaticCheck.Checked)
            {
                attributes.Add("static");
            }
            if (FinalCheck.Checked)
            {
                attributes.Add("final");
                VariableName.Text = VariableName.Text.ToUpper();
            }
            if (TransientCheck.Checked)
            {
                attributes.Add("transient");
            }

            String[] attr = ToStringArray(attributes.ToArray());

            Variable v = new Variable();
            v.Name = VariableName.Text;
            if (VariableType.Text == "character")
            {
                v.Type = "char";
            }
            else if (VariableType.Text == "integer")
            {
                v.Type = "int";
            }
            else
            {
                v.Type = VariableType.Text;
            }
            v.Value = GetValue(v.Type);
            v.Access = access;
            v.Comments = Comments.Text;
            v.Attributes = attr;
            v.Scope = Variable.INSTANCE;

            if (Types.AddInstanceVariable(v))
            {
                ClassInfo ci = ClassFiles.GetClassInfo(this.ci.ClassName + ".java");
                ci.AddInstanceVariable(v);
                ClassFiles.Add(ci);
                successful = true;
                Close();
            }
            else
            {
                MessageBox.Show("Variable with same name exists. Please supply a unique name.", "Dual Variable Declaration");
                VariableName.SelectAll();
                VariableName.Focus();
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

        private String GetValue(String type)
        {
            String value = "";
            if (enclose.Checked || type == Types.STRING)
            {
                value = "\"" + InitialValue.Text + "\"";
            }
            else
            {
                value = InitialValue.Text;
            }
            return value;
        }

        private void CreateMethodVariable()
        {
            Variable v = new Variable();
            v.Name = VariableName.Text;
            v.Type = VariableType.Text;
            v.Value = GetValue(v.Type);
            v.Comments = Comments.Text;
            v.Scope = Variable.MEMBER;
            v.Method = MethodCombo.Text;

            ClassInfo ci = ClassFiles.GetClassInfo(this.ci.ClassName + ".java");
            if (ci == null)
            {
                ci.AddInstanceVariable(v);
                ClassFiles.Add(ci);
            }
            else
            {
                ci.GetMethod(v.Method).AddVariable(v);
                ClassFiles.Add(ci);
            }
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataType form = new DataType(VariableType.Text, DataType.Variable);
            form.ShowDialog();
            if (OtherDataType != null)
            {
                VariableType.Text = OtherDataType;
                for (int i = 0; i < ArrayDimension; i++)
                {
                    VariableType.Text += "[]";
                }
                enclose.Enabled = true;
            }
        }

        private void DataTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VariableType.Items.Contains(VariableType.Text))
            {
                enclose.Enabled = false;
                OtherDataType = null;
                ArrayDimension = 0;
            }
            else
            {
                enclose.Enabled = true;
            }

            if (VariableType.Text == "String")
            {
                enclose.Checked = true;
            }
        }

        private void NewVariable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                OK_Click(null, null);
            }
        }

        private void InstanceRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (InstanceRadio.Checked)
            {
                EnableComponents(true);
            }
        }

        private void MethodRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MethodRadio.Checked)
            {
                EnableComponents(false);
            }
        }
   }
}