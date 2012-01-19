using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class Expression : Form
    {
        private int oper;
        private int receiver;
        private bool successful;
        private bool isClose;
        private String contents;
        private int varType;
        private String methodName;
        private Object[] classes;

        public Expression(int oper, int receiver, String methodName, int varType)
        {
            successful = false;
            this.varType = varType;
            this.oper = oper;
            this.receiver = receiver;
            this.methodName = methodName;

            InitializeComponent();
            InitializeContents();
            ModifyWindow();
            DisableTabs();
            DisableComponents();
        }

        private void InitializeContents()
        {
            Object[] mv = Types.GetMethodVariables(methodName);
            for (int i = 0; i < mv.Length; i++)
            {
                String name = ((Variable)mv[i]).Name;
                MethodField.Items.Add(name);
            }

            Object[] iv = Types.InstanceVariables;
            bool resultOK = false;
            for (int i = 0; i < iv.Length; i++)
            {
				Variable v = (Variable)iv[i];
				if(receiver == NewCondition.UNARY_EXPR || oper == NewCondition.LOGICAL_AND
					|| oper == NewCondition.LOGICAL_OR || receiver == NewCondition.BOOLVALUE)
				{
					resultOK = v.Type == Types.BOOLEAN;
				}
				else if(oper == NewCondition.GREATER_EQUAL || oper == NewCondition.GREATER ||
					oper == NewCondition.LESS_EQUAL || oper == NewCondition.LESS)
				{
					resultOK = IsNumeric(v);
				}
				else if (oper == NewCondition.EQUAL)
				{
                    resultOK = v.Type == Types.STRING || IsNumeric(v) || v.Type == Types.BOOLEAN;
                }

				if(resultOK)
				{
                	InstanceField.Items.Add(v.Name);
				}
            }

            classes = Types.Classes;
            ClassCombo.Items.Clear();
            for(int i = 0; i < classes.Length; i++)
            {
                ClassInfo ci = (ClassInfo)classes[i];
                ClassCombo.Items.Add(ci.ClassName);
            }
        }

        public int VariableType
        {
            get
            {
                return varType;
            }
        }

        private bool IsNumeric(Variable v)
        {
			return v.Type == "byte" || v.Type == "double" || v.Type == "float" || v.Type == "int" || v.Type == "long" || v.Type == "short";
		}

        private void ModifyWindow()
        {
            switch (receiver)
            {
                case NewCondition.LEFT_EXPR:
                    this.Text = "Insert an expression for the LEFT-HAND side";
                    this.Location = new Point(20, 150);
                    break;
                case NewCondition.RIGHT_EXPR:
                    this.Text = "Insert an expression for the RIGHT-HAND side";
                    this.Location = new Point(840, 150);
                    break;
                case NewCondition.UNARY_EXPR:
                    this.Text = "Insert UNARY expression";
                    this.Location = new Point(350, 150);
                    break;
            }
        }

        private void DisableTabs()
        {
            if (receiver == NewCondition.LEFT_EXPR)
            {
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
            }
            else if(receiver == NewCondition.UNARY_EXPR || oper == NewCondition.LOGICAL_AND
                || oper == NewCondition.LOGICAL_OR || receiver == NewCondition.BOOLVALUE)
            {
                tabControl1.TabPages.Remove(tabPage1);
            }
            else if (oper == NewCondition.GREATER_EQUAL || oper == NewCondition.GREATER ||
                oper == NewCondition.LESS_EQUAL || oper == NewCondition.LESS)
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
            else if (oper == NewCondition.EQUAL)
            {
                if (varType == NewCondition.NUMERIC)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                }
                else if (varType == NewCondition.BOOLVALUE)
                {
                    tabControl1.TabPages.Remove(tabPage1);
                }
                else if (varType == NewCondition.STRING)
                {
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                }
            }
        }

        private void DisableComponents()
        {
            WNum.Enabled = WRadio.Checked;
            MNum.Enabled = MRadio.Checked;
            DNum.Enabled = DRadio.Checked;
            FNum.Enabled = FRadio.Checked;
            CNum.Enabled = CRadio.Checked;

            InstanceField.Enabled = InstanceRadio.Checked;
            MethodField.Enabled = MethodRadio.Checked;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            CheckData();
            if (successful)
            {
                this.Close();
            }
            else
            {
                varType = NewCondition.UNSET;
            }
        }

        private void CheckData()
        {
            if (tabControl1.SelectedTab.Text == "Constants")
            {
                CheckNumbers();
                varType = NewCondition.NUMERIC;
            }
            else if (tabControl1.SelectedTab.Text == "Boolean")
            {
                CheckBoolean();
                varType = NewCondition.BOOLVALUE;
            }
            else if (tabControl1.SelectedTab.Text == "Variables")
            {
                CheckVariables();
            }
            else if (tabControl1.SelectedTab.Text == "Method Calls")
            {
                CheckMethods();
            }
            else
            {
                varType = NewCondition.STRING;
                CheckCustom();
            }
        }

        private void CheckNumbers()
        {
            if (CRadio.Checked)
            {
                if(Types.IsValid(CNum.Text))
                {
                    contents = CNum.Text;
                    successful = true;
                }
                else
                {
                    CNum.SelectAll();
                    CNum.Focus();
                }
            }
            else if (WRadio.Checked)
            {
                contents = WNum.Text;
                successful = true;
            }
            else if (MRadio.Checked)
            {
                contents = MNum.Text;
                successful = true;
            }
            else if (DRadio.Checked)
            {
                contents = DNum.Text;
                successful = true;
            }
            else
            {
                contents = FNum.Text;
                successful = true;
            }
        }

        private void CheckBoolean()
        {
            contents = TrueRadio.Checked ? "true" : "false";
            successful = true;
        }

        private void CheckVariables()
        {
            int error;
            Variable v;
            if (InstanceRadio.Checked)
            {
                error = SyntaxChecker.Check(InstanceField.Text);
                v = Types.GetInstanceVariable(InstanceField.Text);
            }
            else
            {
                error = SyntaxChecker.Check(MethodField.Text);
                v = Types.GetMethodVariable(methodName, MethodField.Text);
            }

            if (v != null)
            {
                if (v.Type == "Object")
                {
                    varType = NewCondition.OBJECT;
                }
                else if (v.Type == "String")
                {
                    varType = NewCondition.STRING;
                }
                else if (v.Type == "boolean")
                {
                    varType = NewCondition.BOOLVALUE;
                }
                else if (IsNumeric(v))
                {
                    varType = NewCondition.NUMERIC;
                }
                else
                {
                    varType = NewCondition.GENERAL;
                }
            }

            switch (error)
            {
                case 1:
                    MessageBox.Show("Please supply a non-empty variable name.", "Invalid Variable Name");
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

            if (error == 0)
            {
                contents = (InstanceRadio.Checked ? InstanceField.Text : MethodField.Text);
                successful = true;
            }
            else
            {
                if (InstanceRadio.Checked)
                {
                    InstanceField.SelectAll();
                    InstanceField.Focus();
                }
                else
                {
                    MethodField.SelectAll();
                    MethodField.Focus();
                }
            }
        }

        private void CheckMethods()
        {
            String className = ClassCombo.Text;
            String methodName = "";
            if (MethodList.SelectedItems.Count == 1)
            {
                
                methodName = MethodList.SelectedItem.ToString();
                contents = className + "." + methodName;
                successful = true;
            }
            else if (MethodList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a method.", "Empty Selection");
            }
            else
            {
                MessageBox.Show("Please select only one method.", "Multiple Selection");
            }
        }

        private void CheckCustom()
        {
            if (CustomField.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a valid expression", "Empty Custom Expression");
            }
            else
            {
                if (EncloseCheck.Checked)
                {
                    contents = @"\" + CustomField.Text.Trim() + @"\";
                }
                else
                {
                    contents = CustomField.Text.Trim();
                }
            }
        }

        private void WRadio_CheckedChanged(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void MRadio_CheckedChanged(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void FRadio_CheckedChanged(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void DRadio_CheckedChanged(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void CRadio_CheckedChanged(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void InstanceRadio_CheckedChanged(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void MethodRadio_CheckedChanged(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void PredefinedRadio_CheckedChanged(object sender, EventArgs e)
        {
            DisableComponents();
        }

        private void ClassRadio_CheckedChanged(object sender, EventArgs e)
        {
            DisableComponents();
        }

        public Boolean Successful
        {
            get
            {
                return successful;
            }
        }

        public String Contents
        {
            get
            {
                return contents;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = !successful && !isClose;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            isClose = true;
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Constants")
            {
                WNum.Focus();
            }
            else if (tabControl1.SelectedTab.Text == "Variables")
            {
                InstanceField.SelectAll();
                InstanceField.Focus();
            }
            else if (tabControl1.SelectedTab.Text == "Method Calls")
            {
                ClassCombo.SelectAll();
                ClassCombo.Focus();
            }
            else
            {
                CustomField.SelectAll();
                CustomField.Focus();
            }
        }

        private void Expression_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeOKButton(e);
        }

        private void InstanceField_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeOKButton(e);
        }

        private void MethodField_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeOKButton(e);
        }

        private void InvokeOKButton(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                OK_Click(null, null);
            }
        }

        private void ClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ClassCombo.SelectedIndex;
            ClassInfo ci = (ClassInfo)classes[selectedIndex];
            if (ci.ClassName == ClassCombo.SelectedItem.ToString())
            {
                MethodList.Items.Clear();
                Object[] methods = ci.Methods.ToArray();
                for (int i = 0; i < methods.Length; i++)
                {
                    Method m = (Method)methods[i];
                    Object[] var = m.Parameters.ToArray();
                    String contents = m.Name + "(";
                    for(int j = 0 ; j < var.Length; j++)
                    {
                        Variable v = (Variable)var[j];
                        contents += v.Type;
                        if (j + 1 < var.Length)
                        {
                            contents += ", ";
                        }
                    }
                    contents += ")";
                    MethodList.Items.Add(contents);
                }
            }
        }

        private void WNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeOKButton(e);
        }

        private void FNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeOKButton(e);
        }

        private void MNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeOKButton(e);
        }

        private void DNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeOKButton(e);
        }

        private void CNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeOKButton(e);
        }

        private void CustomField_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeOKButton(e);
        }
    }
}