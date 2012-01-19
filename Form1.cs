using System;
using System.Diagnostics;
using System.Collections;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class MainIDE : Form
    {
        private Boolean JustAdded;
        private ArrayList parameters;
        private int marker;
        private int selectionStart;

        public MainIDE()
        {
            InitializeComponent();
            InitializeContents();
            DisableComponents();
            UpdateCodeView();
            UpdateTabs();
            UpdateLabels();
        }

        private void InitializeContents()
        {
            Types.InitializeContents();
        }

        private void DisableComponents()
        {
            if (tabControl2.TabCount == 0)
            {
                MenuItems(false);
                InsertMenuItems(false);
                FloatingMenu(false);
            }
            else
            {
                tabControl1.Enabled = true;
                string fn = tabControl2.SelectedTab.Text;
                ClassInfo ci = ClassFiles.GetClassInfo(fn);

                if (ci == null)
                {
                    //MenuItems(false); selected
                    InsertMenuItems(false);
                    headersToolStripMenuItem.Enabled = true;
                    declarationToolStripMenuItem.Enabled = true;
                    objectToolStripMenuItem.Enabled = true;
                    methodToolStripMenuItem.Enabled = false;
                    variableToolStripMenuItem.Enabled = false;

                    groupBoxMethod.Enabled = false;
                    groupBoxVariable.Enabled = false;
                    groupBoxIf.Enabled = false;
                    groupBoxSwitch.Enabled = false;
                    groupBoxTry.Enabled = false;
                }
                else
                {
                    MenuItems(true);
                    InsertMenuItems(true);
                    methodToolStripMenuItem.Enabled = true;
                    variableToolStripMenuItem.Enabled = true;

                    groupBoxMethod.Enabled = true;
                    groupBoxVariable.Enabled = true;
                    groupBoxIf.Enabled = ci.Methods.Count > 0;
                    groupBoxSwitch.Enabled = ci.Methods.Count > 0;
                    groupBoxTry.Enabled = ci.Methods.Count > 0;
                }
            }
        }

        private void MenuItems(Boolean isEnable)
        {
            closeToolStripMenuItem.Enabled = isEnable;
            saveToolStripMenuItem.Enabled = isEnable;
            saveAsToolStripMenuItem.Enabled = isEnable;
            printToolStripMenuItem.Enabled = isEnable;

            undoToolStripMenuItem.Enabled = isEnable;
            redoToolStripMenuItem.Enabled = isEnable;
            copyToolStripMenuItem.Enabled = isEnable;
            cutToolStripMenuItem.Enabled = isEnable;
            pasteToolStripMenuItem.Enabled = isEnable;
            findToolStripMenuItem.Enabled = isEnable;

            codeToolStripMenuItem.Enabled = isEnable;
            outlineToolStripMenuItem.Enabled = isEnable;
            fullScreenToolStripMenuItem.Enabled = isEnable;

            InsertMenuItems(isEnable);

            compileToolStripMenuItem.Enabled = isEnable;
            executeToolStripMenuItem.Enabled = isEnable;

            documentationToolStripMenuItem.Enabled = isEnable;
            aboutToolStripMenuItem.Enabled = isEnable;
        }

        private void InsertMenuItems(Boolean isEnable)
        {
            headersToolStripMenuItem.Enabled = isEnable;
            declarationToolStripMenuItem.Enabled = isEnable;
            constructToolStripMenuItem.Enabled = isEnable;
            loopToolStripMenuItem.Enabled = isEnable;
            expressionToolStripMenuItem.Enabled = isEnable;
            structuresToolStripMenuItem.Enabled = isEnable;
            predefinedToolStripMenuItem.Enabled = isEnable;
            widgetsToolStripMenuItem.Enabled = isEnable;
            miscellaneousToolStripMenuItem.Enabled = isEnable;
        }

        private void FloatingMenu(Boolean isEnable)
        {
            tabControl1.Enabled = isEnable;
        }

        private void UpdateCodeView()
        {
            ClassInfo ci = ClassFiles.GetClassInfo(tabControl2.SelectedTab.Text);
            if (ci != null)
            {
                richTextBox1.Rtf = ci.Rtf;
                treeView1.Nodes.Clear();
                TreeNode root = ci.GetTreeNode();
                treeView1.Nodes.Add(root);
                treeView1.ExpandAll();
            }
            else
            {
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add("No contents yet");
            }
        }

        private void UpdateLabels()
        {
            FileNameLabel.Text = tabControl2.SelectedTab.Text;
            ReturnType.Items.Clear();
            ReturnType.Items.AddRange(Types.Primitive);
            ReturnType.Items.AddRange(Types.Supported);
            compileToolStripMenuItem.Text = "Compile " + tabControl2.SelectedTab.Text;
            executeToolStripMenuItem.Text = "Execute " + tabControl2.SelectedTab.Name;
        }

        private void UpdateTabs()
        {
            ClassInfo ci = ClassFiles.GetClassInfo(tabControl2.SelectedTab.Text);
            if (ci != null)
            {
                ObjectType.Text = ci.Type;
                ObjectName.Text = ci.ClassName;
                Inherit.Text = ci.Inherit;

                if (ci.Access == "public")
                {
                    PublicRadio.Checked = true;
                }
                else if (ci.Access == "private")
                {
                    DefaultRadio.Checked = true;
                }
                else
                {
                    PublicRadio.Checked = false;
                    DefaultRadio.Checked = false;
                }

                FinalCheck.Checked = (ci.Attribute == "final");
                linkLabel1.Text = "Apply Changes";
            }

            ReturnType.Items.Clear();
            ReturnType.Items.AddRange(Types.Primitive);
            ReturnType.Items.AddRange(Types.Supported);

            VariableType.Items.Clear();
            VariableType.Items.AddRange(Types.Primitive);
            VariableType.Items.AddRange(Types.Supported);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form popup = new NewObject(tabControl2.SelectedTab.Text);
            popup.ShowDialog();
            JustAdded = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form popup = new NewMethod(tabControl2.SelectedTab.Name);
            popup.ShowDialog();
            JustAdded = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassInfo ci = ClassFiles.GetClassInfo(tabControl2.SelectedTab.Text);
            Form popup = new NewVariable(ci, FindMethod());
            popup.ShowDialog();
            JustAdded = true;
        }

        private void objectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form popup = new NewObject(tabControl2.SelectedTab.Text);
            popup.ShowDialog();
            JustAdded = true;
        }

        private void methodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form popup = new NewMethod(tabControl2.SelectedTab.Name);
            popup.ShowDialog();
            JustAdded = true;
        }

        private void variableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfo ci = ClassFiles.GetClassInfo(tabControl2.SelectedTab.Text);
            Form popup = new NewVariable(ci, FindMethod());
            popup.ShowDialog();
            JustAdded = true;
        }

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {
            DisableComponents();
        }

        private void MainIDE_MouseMove(object sender, MouseEventArgs e)
        {
            if (JustAdded)
            {
                DisableComponents();
                UpdateCodeView();
                UpdateTabs();
                UpdateLabels();
                JustAdded = false;
                richTextBox1.SelectionStart = selectionStart;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fn = tabControl2.SelectedTab.Text;
            ClassInfo ci = ClassFiles.GetClassInfo(fn);
            SaveFile(fn, ci);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String fn = GetFileName();
            ClassInfo ci = ClassFiles.GetClassInfo(fn);

            if (ci == null && ClassFiles.Count() != 0)
            {
                MessageBox.Show("Filename must match classname.", "Error Saving");
                return;
            }
            SaveFile(fn, ci);
        }

        private String GetFileName()
        {
            int last = saveFileDialog1.FileName.LastIndexOf('\\');
            return saveFileDialog1.FileName.Substring(last+1);
        }

        private void SaveFile(String fn, ClassInfo ci)
        {
            try
            {
                FileStream sFile = new FileStream(fn, FileMode.Create);
                StreamWriter sw = new StreamWriter(sFile);
                sw.AutoFlush = true;

                if (ci == null)
                {
                    sw.WriteLine("");
                }

                else
                {
                    /*Object[] lines = ci.Code();*/
                    Object[] lines = richTextBox1.Lines;

                    for (int i = 0; i < lines.Length; i++)
                    {
                        String line = (String)lines[i];
                        sw.WriteLine(line);
                    }
                }
                sw.Close();
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message, "Error Saving");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = tabControl2.SelectedTab.Text;
            saveFileDialog1.Filter = "Java Source Code(*.java)|*.java|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();

            String fn = saveFileDialog1.FileName;
            int lastSlash = fn.LastIndexOf("\\");
            fn = fn.Substring(lastSlash);

            ClassInfo ci = ClassFiles.GetClassInfo(tabControl2.SelectedTab.Text);
            if (ci == null)
            {
                tabControl2.SelectedTab.Name = fn.Substring(0, fn.LastIndexOf(".java")-1);
                tabControl2.SelectedTab.Text = fn;
            }
            else
            {
                tabControl2.SelectedTab.Name = ci.ClassName = fn.Substring(0, fn.LastIndexOf(".java")-1);
                tabControl2.SelectedTab.Text = ci.FileName = fn;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //check which method this variable should go
            ClassInfo ci = ClassFiles.GetClassInfo(tabControl2.SelectedTab.Text);
            NewVariable nv = new NewVariable(ci, FindMethod());
            nv.OverrideComponents(VariableName, VariableType, VariableValue, PublicRadio3, PrivateRadio3, StaticCheck3, FinalCheck3);
            JustAdded = nv.ProcessContents();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewObject no = new NewObject(tabControl2.SelectedTab.Text);
            no.OverrideComponents(ObjectName, ObjectType, Inherit, PublicRadio, DefaultRadio, FinalCheck);
            no.ProcessContents();
            JustAdded = true;
        }

        private void conditionStatementsIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfo ci = ClassFiles.GetClassInfo(tabControl2.SelectedTab.Text);
            Form popup = new NewCondition(ci, FindMethod());
            popup.ShowDialog();
            JustAdded = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ClassInfo ci = ClassFiles.GetClassInfo(tabControl2.SelectedTab.Text);
            NewCondition nc = new NewCondition(ci, FindMethod());
            nc.ShowDialog();

            if (nc.MethodSelected != null && !nc.IsDefault)
            {
                String[] lines = nc.Lines;
                richTextBox1.SelectedText = "\n           ";
                for (int i = 0; i < lines.Length; i++)
                {
                    richTextBox1.SelectedText = lines[i] + "\n           ";
                    richTextBox1.SelectionIndent = 10;
                }

                lines = GetCode();
                String text = "";
                if(lines != null)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        text += lines[i] + @"\line ";
                    }
                }

                text = text.Replace("{",@"\{");
                text = text.Replace("}",@"\}");

                nc.MethodSelected.Code = text;
                ci.EditMethod(nc.MethodSelected);
                ClassFiles.RemoveAll();
                ClassFiles.Add(ci);
            }

            JustAdded = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewMethod nm = new NewMethod(tabControl2.SelectedTab.Name);
            nm.OverrideComponents(MethodName, ReturnType, PublicRadio2, PrivateRadio2, StaticCheck2, FinalCheck2);
            nm.ProcessContents();
            MethodName.Text = ReturnType.Text = ParameterText.Text = "";
            PublicRadio2.Checked = PrivateRadio2.Checked = StaticCheck2.Checked = FinalCheck2.Checked = false;
            parameters = null;
            JustAdded = true;
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(null, null);
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(@"C:\Program Files\Java\jdk1.5.0_10\bin\javac.exe");
            process.StartInfo.Arguments = tabControl2.SelectedTab.Text;
            process.Start();
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(@"C:\Program Files\Java\jdk1.5.0_10\bin\java");
            process.StartInfo.Arguments = tabControl2.SelectedTab.Name;
            process.Start();
        }

        private String FindMethod()
        {
            String line = "";
            int currentLine = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            for (int i = currentLine; i > -1 && richTextBox1.Lines.Length > 0; i--)
            {
                line = richTextBox1.Lines[i].Trim();
                line = line.Trim();
                try
                {
                    line = line.Substring(0, line.IndexOf("("));
                    if (line.Contains(" "))
                    {
                        int first = line.LastIndexOf(" ") + 1;
                        line = line.Substring(first, line.Length - first);
                        marker = i+1;
                        break;
                    }
                }
                catch (Exception e)
                {
                    String cause = e.Message;
                }
            }
            return line;
        }

        private String[] GetCode()
        {
            ArrayList code = new ArrayList();
            Stack braces = new Stack();

            for (int i = marker; i < richTextBox1.Lines.Length; i++)
            {
                String line = richTextBox1.Lines[i];
                char[] chars = new char[line.Length];
                line.CopyTo(0, chars, 0, line.Length);

                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[j] == '{')
                    {
                        braces.Push("{");
                    }

                    if (chars[j] == '}')
                    {
                        if (braces.Count > 0)
                        {
                            braces.Pop();
                        }
                        else
                        {
                            MessageBox.Show("Unpaired grouping symbols found in document.", "Mismatched Groupings");
                            return null;
                        }
                    }
                }

                if (braces.Count == 0)
                {
                    Object[] contents = code.ToArray();
                    String[] text = new String[code.Count];
                    for (int k = 1; k < text.Length; k++)
                    {
                        text[k] = contents[k].ToString();
                    }
                    return text;
                }
                else
                {
                    code.Add(line);
                }
            }
            MessageBox.Show("Unpaired grouping symbols found in document.", "Mismatched Groupings");
            return null;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewClass nc = new NewClass(tabControl2.SelectedTab.Name);
            nc.ShowDialog();
            if (nc.Successful)
            {
                ClassInfo ci = new ClassInfo();
                ci.FileName = nc.Contents + ".java";
                ci.ClassName = nc.Contents;
                ci.Access = "public";
                ci.Type = "class";

                if (nc.HasConstructor)
                {
                    Method m = new Method();
                    m.Name = ci.ClassName;
                    m.Access = "public";
                    ci.AddMethod(m);
                }
                if (nc.HasMain)
                {
                    Method m = new Method();
                    m.Name = "main";
                    m.Access = "public";
                    m.Attributes = new String[1] { "static" };
                    m.ReturnType = "void";

                    Variable v = new Variable();
                    v.Name = "args";
                    v.Type = "String[]";        //edit dimension here
                    v.Method = m.Name;
                    m.AddParameter(v);
                    ci.AddMethod(m);
                }
                InsertTemplate(ci);
            }
        }

        private void InsertTemplate(ClassInfo ci)
        {
            tabControl2.SelectedTab.Name = ci.ClassName;
            tabControl2.SelectedTab.Text = ci.ClassName + ".java";
            ClassFiles.RemoveAll();
            ClassFiles.Add(ci);
            JustAdded = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ClassInfo ci = new ClassInfo();
            ci.FileName = "HelloWorldExample.java";
            ci.ClassName = "HelloWorldExample";
            ci.Access = "public";
            ci.Type = "class";

            Method m = new Method();
            m.Name = "main";
            m.Access = "public";
            m.Attributes = new String[1] { "static" };
            m.ReturnType = "void";

            Variable v = new Variable();
            v.Name = "args";
            v.Type = "String[]";//edit dimension here

            m.AddParameter(v);
            m.Code = "System.out.println(\"Hello World!\");";
            ci.AddMethod(m);
            InsertTemplate(ci);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Parameters param = new Parameters(tabControl2.SelectedTab.Text);
            param.ShowDialog();
            if (param.Successful)
            {
                String text = "";
                Object[] var = param.ParameterList.ToArray();
                for (int i = 0; i < var.Length; i++)
                {
                    Variable v = (Variable)var[i];
                    text += text + v.Type + " " + v.Name;
                    if (i + 1 < var.Length)
                    {
                        text += text + ", ";
                    }
                }
                ParameterText.Text = text;
                this.parameters = param.ParameterList;
            }
        }

        private void InvokeNewObject(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                linkLabel1_LinkClicked(null, null);
            }
        }

        private void ObjectType_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeNewObject(e);
        }

        private void ObjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeNewObject(e);
        }

        private void Inherit_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeNewObject(e);
        }

        private void PublicRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeNewObject(e);
        }

        private void DefaultRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeNewObject(e);
        }

        private void FinalCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeNewObject(e);
        }

        private void InvokeNewMethod(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                linkLabel2_LinkClicked(null, null);
            }
        }

        private void MethodName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeNewMethod(e);
        }

        private void ReturnType_KeyPress(object sender, KeyPressEventArgs e)
        {
            InvokeNewMethod(e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            selectionStart = richTextBox1.SelectionStart;
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            selectionStart = richTextBox1.SelectionStart;
        }
    }
}