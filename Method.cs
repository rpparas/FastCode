using System;
using System.Windows.Forms;
using System.Collections;
using System.Text;

namespace SampleApp
{
    public class Method
    {
        private String name;
        private String rtype;
        private String access;
        private String comments;
        private String code;
        private String[] attributes;

        private ArrayList exceptions;
        private ArrayList parameters;
        private ArrayList variables;

        public Method()
        {
            exceptions = new ArrayList();
            parameters = new ArrayList();
            variables = new ArrayList();
        }

        public String Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }

        public String ReturnType
        {
            set
            {
                this.rtype = value;
            }
            get
            {
                return rtype;
            }
        }

        public String Access
        {
            set
            {
                this.access = value;
            }
            get
            {
                return access;
            }
        }

        public String Comments
        {
            set
            {
                this.comments = value;
            }
            get
            {
                return comments;
            }
        }

        public String Code
        {
            set
            {
                this.code = value;
            }
            get
            {
                return code;
            }
        }
        
        public String[] Attributes
        {
            set
            {
                this.attributes = value;
            }
            get
            {
                return attributes;
            }
        }

        public ArrayList Parameters
        {
            set
            {
                this.parameters = value;
            }
            get
            {
                return parameters;
            }
        }

        public ArrayList Variables
        {
            get
            {
                return variables;
            }
        }

        public void AddParameter(Variable v)
        {
            parameters.Add(v);
        }

        public void AddVariable(Variable v)
        {
            Variable old = GetVariable(v.Name);
            if (old != null)
            {
                RemoveVariable(old);
            }
            variables.Add(v);
        }

        public Boolean RemoveVariable(Variable v)
        {
            if (variables.Contains(v))
            {
                variables.Remove(v);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ContainsVariable(Variable v)
        {
            return variables.Contains(v);
        }

        public Variable GetVariable(String name)
        {
            Object[] NewList = variables.ToArray();
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

        public String Rtf
        {
            get
            {
                String text = @"     {\f1\cf1 ";
                if (access == "public" || access == "private" || access == "protected")
                {
                    text += access + " ";
                }

                for (int i = 0; attributes != null && i < attributes.Length; i++)
                {
                    text += attributes[i] + " ";
                }

                text += @"}{\f1\cf2 " + ReturnType + @" }\b " + Name + @"\b0(";

                Object[] param = parameters.ToArray();
                for (int i = 0; i < param.Length; i++)
                {
                    Variable v = (Variable)param[i];
                    text += v.Type + " " + v.Name;
                    if (i + 1 != param.Length)
                    {
                        text += ", ";
                    }
                }

                text += @")\line     \{\line          ";
                if (code != "" && code != null && attributes != null)
                {
                    text += code;
                }
                text += @"\line     \}";
                return text;
            }
        }
    }
}