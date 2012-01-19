using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class Parameters : Form
    {
        private const int ADD = 0;
        private const int REMOVE = 1;
        private bool successful;

        private ArrayList selection;
        private ArrayList parameters;
        private String fileName;
        private int selectedIndex;
        private int paramIndex;

        public Parameters(String fileName)
        {
            parameters = new ArrayList();
            selection = new ArrayList();
            this.fileName = fileName;

            InitializeComponent();
            InitializeContents();
        }

        private void InitializeContents()
        {
            ClassInfo ci = ClassFiles.GetClassInfo(fileName);
            if(ci != null)
            {
                Object[] methods = ci.Methods.ToArray();
                listBox1.Items.Clear();
                for (int i = 0; i < methods.Length; i++)
                {
                    Method m = (Method)methods[i];
                    Object[] param = m.Parameters.ToArray();
                    for (int j = 0; j < param.Length; j++)
                    {
                        Variable v = (Variable)param[i];
                        selection.Add(v);
                        listBox1.Items.Add(v.Name + " : " + v.Type);
                    }

                    Object[] var = m.Variables.ToArray();
                    for (int j = 0; j < var.Length; j++)
                    {
                        Variable v = (Variable)var[i];
                        selection.Add(v);
                        listBox1.Items.Add(v.Name + " : " + v.Type);
                    }
                }
            }
        }

        private void AddButton1b_Click(object sender, EventArgs e)
        {
            int error = Types.CheckName(VariableName.Text);
            if (error == SyntaxChecker.NO_ERROR)
            {
                error = Types.CheckType(VariableType.Text);
                if (error == SyntaxChecker.NO_ERROR)
                {
                    Variable v = new Variable();
                    v.Name = VariableName.Text;
                    v.Type = VariableType.Text;

                    VariableName.Text = "";
                    VariableType.Text = "";
                    UpdateSelectionList(v, REMOVE);
                    UpdateParameterList(v, ADD);

                }
                else
                {
                    VariableType.SelectAll();
                    VariableType.Focus();
                }
            }
            else
            {
                VariableName.SelectAll();
                VariableName.Focus();
            }
        }

        private void UpdateSelectionList(Variable v, int operation)
        {
            switch(operation){
                case ADD:
                    selection.Add(v);
                    listBox1.Items.Add(v.Name + " : " + v.Type);
                    break;

                case REMOVE:
                    Object[] sel = selection.ToArray();
                    Variable var = (Variable)sel[selectedIndex];
                    if (var.Name == v.Name && var.Type == v.Type)
                    {
                        selection.RemoveAt(selectedIndex);
                        listBox1.Items.RemoveAt(selectedIndex);
                    }
                    break;
            }
        }

        private void UpdateParameterList(Variable v, int operation)
        {
            switch(operation)
            {
                case ADD:
                    parameters.Add(v);
                    listBox2.Items.Add(v.Name + " : " + v.Type);
                    break;

                case REMOVE:
                    Object[] param = parameters.ToArray();
                    Variable var = (Variable)param[paramIndex];
                    if (var.Name == v.Name && var.Type == v.Type)
                    {
                        parameters.RemoveAt(paramIndex);
                        listBox2.Items.RemoveAt(paramIndex);
                    }
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex != -1)
            {
                Object[] sel = selection.ToArray();
                Variable v = (Variable)selection.ToArray()[selectedIndex];
                VariableName.Text = v.Name;
                VariableType.Text = v.Type;
            }
        }

        private void RemoveButton1b_Click(object sender, EventArgs e)
        {
            paramIndex = listBox2.SelectedIndex;
            Variable v = (Variable)parameters.ToArray()[paramIndex];
            UpdateParameterList(v, REMOVE);
            UpdateSelectionList(v, ADD);
        }

        public bool Successful
        {
            get
            {
                return successful;
            }
        }

        public ArrayList ParameterList
        {
            get
            {
                return parameters;
            }
        }
        
        private void OK_Click(object sender, EventArgs e)
        {
            successful = true;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            successful = false;
            this.Close();
        }
    }
}