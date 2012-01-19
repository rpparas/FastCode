using System;
using System.Collections;
using System.Windows.Forms;
using System.Text;

namespace SampleApp
{
    public class ClassInfo
    {
        private String fileName;
        private String className;
        private String type;
        private String access;
        private String attribute;
        private String inherit;
        private String comments;
        private String package;

        private ArrayList instanceVar;
        private ArrayList methods;
        
        private String[] interfaces;

        public ClassInfo()
        {
            instanceVar = new ArrayList();
            methods = new ArrayList();
            //constructors = new ArrayList();
        }

        public String FileName
        {
            set
            {
                fileName = value;
            }
            get
            {
                return fileName;
            }
        }

        public String ClassName
        {
            set
            {
                className = value;
            }
            get
            {
                return className;
            }
        }

        public String Access
        {
            set
            {
                access = value;
            }
            get
            {
                return access;
            }
        }

        public String Type
        {
            set
            {
                type = value;
            }
            get
            {
                return type;
            }
        }

        public String Attribute
        {
            set
            {
                attribute = value;
            }
            get
            {
                return attribute;
            }
        }

        public String Inherit
        {
            set
            {
                inherit = value;
            }
            get
            {
                return inherit;
            }
        }

        public String Comments
        {
            set
            {
                comments = value;
            }
            get
            {
                return comments;
            }
        }

        public String Package
        {
            set
            {
                package = value;
            }
            get
            {
                return package;
            }
        }

        public String[] Interfaces
        {
            set
            {
                interfaces = value;
            }
            get
            {
                return interfaces;
            }
        }

        public String Rtf
        {
            get
            {
                String text = @"{\rtf1\ansi{\fonttbl\f0\fswissVerdana;}{\colortbl;\red0\green102\blue255;\red255\green0\blue0;\red0\green176\blue80;}\f0";
                text += @"{\f1\cf1 ";

                if (access == "public" || access == "private")
                {
                    text += access + " ";
                }

                if (attribute == "final")
                {
                    text += attribute + " ";
                    ClassName = ClassName.ToUpper();
                }

                text += Type + @"} \b " + ClassName + @"\b0";

                if (inherit == "" || inherit == null)
                {
                    text += @"\line\{\line";
                }
                else
                {
                    text += @"{\f1\cf1  extends }\b " + inherit + @"\b0\line\{\line";
                }

                Object[] var = instanceVar.ToArray();
                for (int i = 0; i < var.Length; i++)
                {
                    Variable v = (Variable)var[i];
                    text += v.Rtf + @"\line";
                }

                if (methods.Count > 0)
                {
                    text += @"\line\line";
                    Object[] method = methods.ToArray();
                    for (int i = 0; i < method.Length; i++)
                    {
                        Method m = (Method)method[i];
                        String edited = m.Rtf;
                        edited = edited.Replace("{", @"\{");
                        edited = edited.Replace("}", @"\}");
                        text += m.Rtf + @"\line\line";
                    }
                }
                text += @"\line\}}";
                return text;
            }
        }

        public Object[] Code()
        {
            ArrayList lines = new ArrayList();
            String text = "";

            if (access == "public" || access == "private")
            {
                text += access + " ";
            }

            if (attribute == "final")
            {
                text += attribute + " ";
                ClassName = ClassName.ToUpper();
            }

            text += Type + " " + ClassName;

            if (inherit != "")
            {
                text += " extends "+ inherit;
            }

            lines.Add(text);
            lines.Add("{");
            lines.Add("");

            Object[] var = instanceVar.ToArray();
            for (int i = 0; i < var.Length; i++)
            {
                Variable v = (Variable)var[i];
                lines.Add(v.Code());
            }

            lines.Add("}");
            return lines.ToArray();
        }

        public void AddInstanceVariable(Variable v)
        {
            Variable old = GetinstanceVariable(v.Name);
            if (old != null)
            {
                RemoveinstanceVariable(old);
            }
            instanceVar.Add(v);
        }

        public Boolean RemoveinstanceVariable(Variable v)
        {
            if (instanceVar.Contains(v))
            {
                instanceVar.Remove(v);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ContainsinstanceVariable(Variable v)
        {
            return instanceVar.Contains(v);
        }

        public Variable GetinstanceVariable(String name)
        {
            Object[] NewList = instanceVar.ToArray();
            for (int i = 0; i < NewList.Length; i++)
            {
                Variable v = (Variable)NewList[i];
                if (v.Name == name)
                {
                    return v;
                }
            }
            return null;
        }

        public bool AddMethod(Method m)
        {
            String[] paramTypes = new String[m.Parameters.Count];
            Object[] var = m.Parameters.ToArray();
            for(int i = 0 ; i < paramTypes.Length; i++)
            {
                Variable v = (Variable)var[i];
                paramTypes[i] = v.Type;
            }
            
            if (GetMethod(m.Name, paramTypes) == null)
            {
                methods.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EditMethod(Method m)
        {
            Method old = GetMethod(m.Name);
            if(old != null)
            {
                methods.Remove(old);
                methods.Add(m);
            }
        }

        public Method GetMethod(String name)
        {
            Object[] NewList = methods.ToArray();
            for (int i = 0; i < NewList.Length; i++)
            {
                Method m = (Method)NewList[i];
                if (m.Name == name)
                {
                    return m;
                }
            }
            return null;
        }

        public Method GetMethod(String name, String[] paramTypes)
        {
            Object[] NewList = methods.ToArray();
            for (int i = 0; i < NewList.Length; i++)
            {
                Method m = (Method)NewList[i];
                if (m.Name == name)
                {
                    Object[] var = m.Parameters.ToArray();
                    for (int j = 0; j < var.Length; j++)
                    {
                        Variable v = (Variable)var[j];
                        if (v.Type != paramTypes[j])
                        {
                            break;
                        }
                    }
                    return m;
                }
            }
            return null;
        }
        
        public ArrayList Methods
        {
            get
            {
                return methods;
            }
        }

        public Object[] MethodNames
        {
            get
            {
                Object[] methods = this.methods.ToArray();
                ArrayList names = new ArrayList();
                for (int i = 0; i < methods.Length; i++)
                {
                    Method m = (Method)(methods[i]);
                    names.Add(m.Name);
                }
                return names.ToArray();
            }
        }

        public TreeNode GetTreeNode()
        {
            TreeNode root = new TreeNode(ClassName);
            root.Nodes.Add("imports", "Imports");

            TreeNode variables = new TreeNode("Instance Variables");
            Object[] var = instanceVar.ToArray();
            for (int i = 0; i < var.Length; i++)
            {
                Variable v = (Variable)var[i];
                variables.Nodes.Add(v.Name + " : " + v.Type);
            }

            TreeNode methods = new TreeNode("Methods");
            Object[] met = this.methods.ToArray();
            for (int i = 0; i < met.Length; i++)
            {
                Method m = (Method)met[i];
                methods.Nodes.Add(m.Name + " : " + m.ReturnType);
            }

            variables.ExpandAll();
            root.Nodes.Add(variables);
            root.Nodes.Add(methods);
            return root;
        }
    }
}
