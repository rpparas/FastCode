using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class NewCondition : Form
    {
        public const int SINGLE = 0;
        public const int PAIRED = 1;
        public const int NESTED = 2;

        public const int UNSET = 0;
        public const int GENERAL = 1;
        public const int NUMERIC = 2;
        public const int BOOLVALUE = 3;
        public const int STRING = 4;
        public const int OBJECT = 5;

        public const int EQUAL = 0;
        public const int NOT_EQUAL = 1;
        public const int LOGICAL_AND = 2;
        public const int LOGICAL_OR = 3;
        public const int GREATER_EQUAL = 4;
        public const int GREATER = 5;
        public const int BOOLEAN = 6;
        public const int LOGICAL_NOT = 7;
        public const int LESS_EQUAL = 8;
        public const int LESS = 9;

        public const int UNARY_EXPR = 0;
        public const int LEFT_EXPR = 1;
        public const int RIGHT_EXPR = 2;

        private const String EMPTY = "";
        private String left, right, unary;
        private String condition;
        private String methodName;
        private int varTypeLeft, varTypeRight;

        private int step1;
        private Stack<int> step2;
        private bool isDefault;

        private ClassInfo ci;
        private Method m;
        private Conditions conditions;
        private IfState CurrentIf;

        
        public NewCondition(ClassInfo ci, String methodName)
        {
            InitializeComponent();
            this.ci = ci;
            this.methodName = methodName;
            step2 = new Stack<int>();
            conditions = new Conditions();
            Goto_Step1a();
        }

        private void ClearTabPages()
        {
            for (int i = tabControl1.SelectedIndex; i < tabControl1.TabCount - 1; )
            {
                tabControl1.TabPages.RemoveAt(i + 1);
            }
        }

        private void Goto_Step1a()
        {
            ClearTabPages();
            SingleRadio.Checked = PairedRadio.Checked = NestedRadio.Checked = false;
        }

        private void SingleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (SingleRadio.Checked)
            {
                Goto_Step1a();
                step1 = SINGLE;
                Goto_Step2();
            }
        }

        private void PairedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (PairedRadio.Checked)
            {
                Goto_Step1a();
                step1 = PAIRED;
                Goto_Step2();
            }
        }

        private void NestedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (NestedRadio.Checked)
            {
                Goto_Step1a();
                step1 = NESTED;
                Goto_Step1b();
            }
        }

        private void Goto_Step1b()
        {
            ClearTabPages();
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.SelectTab(tabPage2);
            AddButton1b.Focus();
            listBox1.Items.Clear();

            Object[] statements = conditions.Statements;
            for(int i = 0; i < statements.Length; i++)
            {
		        IfState ifState = (IfState)statements[i];
		        listBox1.Items.Add(ifState.Contents);
            }
            Update_Step1b();
        }

        private void Update_Step1b()
        {
            EditButton1b.Enabled = listBox1.SelectedItems.Count == 1;
            RemoveButton1b.Enabled = listBox1.SelectedItems.Count != 0;
            MoveUpButton.Enabled = EditButton1b.Enabled && listBox1.SelectedIndex != 0;
            MoveDownButton.Enabled = EditButton1b.Enabled && listBox1.SelectedIndex != listBox1.Items.Count - 1;
            SelectAllButton1b.Enabled = listBox1.SelectedItems.Count != listBox1.Items.Count;
            NextButton1b.Enabled = listBox1.Items.Count > 1;
        }

        private void AddButton1b_Click(object sender, EventArgs e)
        {
            Goto_Step2();
        }
        private void RemoveButton1b_Click(object sender, EventArgs e)
        {
            Object[] items = new Object[listBox1.SelectedItems.Count];
            listBox1.SelectedItems.CopyTo(items, 0);
            for (int i = 0; i < items.Length; i++)
            {
                listBox1.Items.Remove(items[i]);
            }
        }

        private void SelectAllButton1b_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SelectedIndex = i;
            }
        }

        private void EditButton1b_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Edit edit = new Edit(listBox1.SelectedItem.ToString());
            edit.ShowDialog();
            if (edit.Successful)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, edit.Contents);
            }
            listBox1.SelectedIndex = index;
            Update_Step1b();
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Object item = listBox1.SelectedItem;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index - 1, item);
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Object item = listBox1.SelectedItem;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index + 1, item);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_Step1b();
        }

        private void NextButton1b_Click(object sender, EventArgs e)
        {
            if (IncludeElseCheck.Checked)
            {
                CurrentIf = new IfState("", "");
                Goto_Step3b();
            }
            else
            {
                Goto_Step4();
            }
        }

        private void Goto_Step2()
        {
            ClearTabPages();
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.SelectTab(tabPage3);
            listBox2.Items.Clear();
            Update_Step2();
        }

        private void Update_Step2()
        {
            EditButton2.Enabled = listBox2.SelectedItems.Count == 1;
            RemoveButton2.Enabled = listBox2.SelectedItems.Count != 0;
            SelectAllButton2.Enabled = listBox2.SelectedItems.Count != listBox2.Items.Count;
            NegateButton.Enabled = EditButton2.Enabled;
            GroupAndButton.Enabled = listBox2.SelectedItems.Count > 1;
            GroupOrButton.Enabled = listBox2.SelectedItems.Count > 1;

            if (listBox2.Items.Count == 1)
            {
                Object[] items = new Object[listBox2.Items.Count];
                listBox2.Items.CopyTo(items, 0);
                condition = items[0].ToString();
                ConditionText2.Text = "if (" + condition + ")";
                NextButton2.Enabled = true;
            }
            else
            {
                ConditionText2.Text = "";
                NextButton2.Enabled = false;
            }
        }

        private void SelectAllButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.SelectedIndex = i;
            }
        }

        private void EditButton2_Click(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            Edit edit = new Edit(listBox2.SelectedItem.ToString());
            edit.ShowDialog();
            if (edit.Successful)
            {
                listBox2.Items.RemoveAt(index);
                listBox2.Items.Insert(index, edit.Contents);
            }
            listBox2.SelectedIndex = index;
            Update_Step2();
        }

        private void RemoveButton2_Click(object sender, EventArgs e)
        {
            Object[] items = new Object[listBox2.SelectedItems.Count];
            listBox2.SelectedItems.CopyTo(items, 0);
            for (int i = 0; i < items.Length; i++)
            {
                listBox2.Items.Remove(items[i]);
            }
        }

        private void NegateButton_Click(object sender, EventArgs e)
        {
            String contents = listBox2.SelectedItem.ToString().Trim();
            if (contents.StartsWith("(") && contents.EndsWith(")"))
            {
                contents = "!" + contents;
            }
            else if (contents.StartsWith("!(") && contents.EndsWith(")"))
            {
                contents = contents.Substring(2, contents.Length - 3);
            }
            else if (contents.Contains("||") || contents.Contains("&&"))
            {
                contents = "!(" + contents + ")";
            }
            else if (contents.StartsWith("!"))
            {
                contents = contents.Substring(1, contents.Length - 1);
            }
            else if(contents.Contains("=="))
            {
                contents = contents.Replace("==", "!=");
            }
            else if (contents.Contains("!="))
            {
                contents = contents.Replace("!=", "==");
            }
            else if (contents.Contains(">="))
            {
                contents = contents.Replace(">=", "<=");
            }
            else if (contents.Contains(">"))
            {
                contents = contents.Replace(">", "<");
            }
            else if (contents.Contains("<="))
            {
                contents = contents.Replace("<=", ">=");
            }
            else if (contents.Contains("<"))
            {
                contents = contents.Replace("<", ">");
            }
            else
            {
                contents = "!" + contents;
            }
            int index = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(index);
            listBox2.Items.Insert(index, contents);
            listBox2.SelectedIndex = index;
            Update_Step2();
        }

        private void GroupAndButton_Click(object sender, EventArgs e)
        {
            Object[] items = new Object[listBox2.SelectedItems.Count];
            int[] indices = new int[listBox2.SelectedIndices.Count];
            listBox2.SelectedItems.CopyTo(items, 0);
            listBox2.SelectedIndices.CopyTo(indices, 0);

            String contents = items[0].ToString();
            for (int i = 1; i < items.Length; i++)
            {
                String item = items[i].ToString();
                if (item.StartsWith("!(") && item.EndsWith(")"))
                {
                    contents = contents + " && " + item;
                }
                else if (item.Contains("||"))
                {
                    contents = contents + " && (" + item + ")";
                }
                else
                {
                    contents = contents + " && " + item;
                }
                listBox2.Items.Remove(item);
            }
            listBox2.Items.Remove(items[0]);
            listBox2.Items.Insert(indices[0], contents);
            listBox2.SelectedIndex = indices[0];
            Update_Step2();
        }

        private void GroupOrButton_Click(object sender, EventArgs e)
        {
            Object[] items = new Object[listBox2.SelectedItems.Count];
            int[] indices = new int[listBox2.SelectedIndices.Count];
            listBox2.SelectedItems.CopyTo(items, 0);
            listBox2.SelectedIndices.CopyTo(indices, 0);

            String contents = items[0].ToString();
            for (int i = 1; i < items.Length; i++)
            {
                String item = items[i].ToString();
                if (item.StartsWith("!(") && item.EndsWith(")"))
                {
                    contents = contents + " || " + item;
                }
                else if (item.Contains("&&"))
                {
                    contents = contents + " || (" + item + ")";
                }
                else
                {
                    contents = contents + " || " + item;
                }
                listBox2.Items.Remove(item);
            }
            listBox2.Items.Remove(items[0]);
            listBox2.Items.Insert(indices[0], contents);
            listBox2.SelectedIndex = indices[0];
            Update_Step2();
        }

        private String PopupWindow(int oper, int receiver)
        {
            Expression expr = null;
            if (receiver == LEFT_EXPR)
            {
                expr = new Expression(oper, receiver, methodName, GENERAL);
            }
            else
            {
                expr = new Expression(oper, receiver, methodName, varTypeLeft);
            }
            expr.ShowDialog();
            if (varTypeLeft == UNSET)
            {
                varTypeLeft = expr.VariableType;
            }
            else
            {
                varTypeRight = expr.VariableType;
            }

            if (expr.Successful)
            {
                return expr.Contents;
            }
            else
            {
                return EMPTY;
            }
        }

        private void AddExpression(String expression)
        {
            listBox2.Items.Add(expression);
            expression = "";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            step2.Push(EQUAL);
            varTypeLeft = UNSET;
            left = PopupWindow(step2.Peek(), LEFT_EXPR);
            if (left != EMPTY)
            {
                varTypeRight = UNSET;
                right = PopupWindow(step2.Peek(), RIGHT_EXPR);
                if (right != EMPTY)
                {
                    if (varTypeLeft == STRING && varTypeRight == STRING)
                    {
                        AddExpression(left + ".equals(" + right + ")");
                    }
                    else
                    {
                        AddExpression(left + " == " + right);
                    }
                    Update_Step2();
                }
            }
        }

        private void NotEqualButton_Click(object sender, EventArgs e)
        {
            step2.Push(NOT_EQUAL);
            varTypeLeft = UNSET;
            left = PopupWindow(step2.Peek(), LEFT_EXPR);
            if (left != EMPTY)
            {
                varTypeRight = UNSET;
                right = PopupWindow(step2.Peek(), RIGHT_EXPR);
                if (right != EMPTY)
                {
                    if (varTypeLeft == STRING && varTypeRight == STRING)
                    {
                        AddExpression("!" + left + ".equals(" + right + ")");
                    }
                    else
                    {
                        AddExpression(left + " != " + right);
                    }
                    Update_Step2();
                }
            }
        }

        private void AndButton_Click(object sender, EventArgs e)
        {
            step2.Push(LOGICAL_AND);
            varTypeLeft = UNSET;
            left = PopupWindow(step2.Peek(), LEFT_EXPR);
            if (left != EMPTY)
            {
                varTypeRight = UNSET;
                right = PopupWindow(step2.Peek(), RIGHT_EXPR);
                if (right != EMPTY)
                {
                    AddExpression(left + " && " + right);
                    Update_Step2();
                }
            }
        }

        private void OrButton_Click(object sender, EventArgs e)
        {
            step2.Push(LOGICAL_OR);
            varTypeLeft = UNSET;
            left = PopupWindow(step2.Peek(), LEFT_EXPR);
            if (left != EMPTY)
            {
                varTypeRight = UNSET;
                right = PopupWindow(step2.Peek(), RIGHT_EXPR);
                if (right != EMPTY)
                {
                    AddExpression(left + " || " + right);
                    Update_Step2();
                }
            }
        }

        private void GreaterEqualButton_Click(object sender, EventArgs e)
        {
            step2.Push(GREATER_EQUAL);
            varTypeLeft = UNSET;
            left = PopupWindow(step2.Peek(), LEFT_EXPR);
            if (left != EMPTY)
            {
                varTypeRight = UNSET;
                right = PopupWindow(step2.Peek(), RIGHT_EXPR);
                if (right != EMPTY)
                {
                    AddExpression(left + " >= " + right);
                    Update_Step2();
                }
            }
        }

        private void GreaterButton_Click(object sender, EventArgs e)
        {
            step2.Push(GREATER);
            varTypeLeft = UNSET;
            left = PopupWindow(step2.Peek(), LEFT_EXPR);
            if (left != EMPTY)
            {
                varTypeRight = UNSET;
                right = PopupWindow(step2.Peek(), RIGHT_EXPR);
                if (right != EMPTY)
                {
                    AddExpression(left + " >= " + right);
                    Update_Step2();
                }
            }
        }

        private void BoolButton_Click(object sender, EventArgs e)
        {
            step2.Push(BOOLEAN);
            unary = PopupWindow(step2.Peek(), UNARY_EXPR);
            if (unary != EMPTY)
            {
                AddExpression(unary);
                Update_Step2();
            }
        }

        private void NOTButton_Click(object sender, EventArgs e)
        {
            step2.Push(LOGICAL_NOT);
            unary = PopupWindow(step2.Peek(), UNARY_EXPR);
            if (unary != EMPTY)
            {
                AddExpression("!" + unary);
                Update_Step2();
            }
        }

        private void LessEqualButton_Click(object sender, EventArgs e)
        {
            step2.Push(LESS_EQUAL);
            varTypeLeft = UNSET;
            left = PopupWindow(step2.Peek(), LEFT_EXPR);
            if (left != EMPTY)
            {
                varTypeRight = UNSET;
                right = PopupWindow(step2.Peek(), RIGHT_EXPR);
                if (right != EMPTY)
                {
                    AddExpression(left + " <= " + right);
                    Update_Step2();
                }
            }
        }

        private void LessButton_Click(object sender, EventArgs e)
        {
            step2.Push(LESS);
            varTypeLeft = UNSET;
            left = PopupWindow(step2.Peek(), LEFT_EXPR);
            if (left != EMPTY)
            {
                varTypeRight = UNSET;
                right = PopupWindow(step2.Peek(), RIGHT_EXPR);
                if (right != EMPTY)
                {
                    AddExpression(left + " < " + right);
                    Update_Step2();
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_Step2();
        }

        private void NextButton2_Click(object sender, EventArgs e)
        {
            CurrentIf = new IfState(condition, "");
            Goto_Step3a();
        }

        private void Goto_Step3a()
        {
            ClearTabPages();
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.SelectTab(tabPage4);
            Update_Step3a();
        }

        private void Update_Step3a()
        {
            ConditionText3a.Text = CurrentIf.Contents;
            CodeText3a.Text = CurrentIf.Statements;
        }


        private void NextButton3a_Click(object sender, EventArgs e)
        {
            CurrentIf.Contents = ConditionText3a.Text;
            CurrentIf.Statements = CodeText3a.Text;
            conditions.AddIf(CurrentIf);

            switch (step1)
            {
                case SINGLE:
                    Goto_Step4();
                    break;
                case PAIRED:
                    Goto_Step3b();
                    break;
                case NESTED:
                    tabControl1.SelectTab(tabPage1);
                    Goto_Step1b();
                    break;
            }
        }

        private void Goto_Step3b()
        {
            ClearTabPages();
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.SelectTab(tabPage5);
        }

        private void NextButton3b_Click(object sender, EventArgs e)
        {
            CurrentIf.Statements = CodeText3b.Text;
            conditions.Else = CurrentIf;
            Goto_Step4();
        }

        private void Goto_Step4()
        {
            ClearTabPages();
            MethodCombo.Items.Clear();
            MethodCombo.Items.AddRange(ci.MethodNames);
            MethodCombo.SelectedItem = methodName;
            if (MethodCombo.SelectedIndex == -1)
            {
                isDefault = true;
            }
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.SelectTab(tabPage6);
            GenerateButton.Focus();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (GenerateButton.Text == "Generate Code")
            {
                PreviewText.Rtf = conditions.Rtf;
                GenerateButton.Text = "Insert Code";
            }
            else
            {
                m = ci.GetMethod((String)MethodCombo.SelectedItem);
                if (m == null)
                {
                    MessageBox.Show("The method you have selected does not seem to exist.  Please verify spelling or name of method.", "Unknown Method");
                }
                else
                {
                    if (isDefault)
                    {
                        String[] lines = PreviewText.Lines;
                        for (int i = 0; i < lines.Length; i++)
                        {
                            m.Code = m.Code + @"\line";
                            lines[i] = lines[i].Replace("{", @"\{");
                            lines[i] = lines[i].Replace("}", @"\}");
                            lines[i] = "          " + lines[i];
                            m.Code = m.Code + lines[i];
                        }
                        ci.EditMethod(m);
                    }
                    this.Close();
                }
            }
        }

        public String[] Lines
        {
            get
            {
                return PreviewText.Lines;
            }
        }

        public Method MethodSelected
        {
            get
            {
                return m;
            }
        }

        public bool IsDefault
        {
            get
            {
                return isDefault;
            }
        }

    }
}