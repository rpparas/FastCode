using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    public class Variable
    {
        public static int INSTANCE = 0;
        public static int MEMBER = 1;
        
        private String name;
        private String type;
        private String val;
        private String access;
        private String comments;
        private String[] attributes;
        
        private int scope;
        private String method;

        public Variable()
        {

        }

        public String Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
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

        public String Value
        {
            set
            {
                val = value;
            }
            get
            {
                return val;
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
        
        public String[] Attributes
        {
            set
            {
                attributes = value;
            }
            get
            {
                return attributes;
            }
        }

        public int Scope
        {
            set
            {
                scope = value;
            }
            get
            {
                return scope;
            }
        }

        public String Method
        {
            set
            {
                method = value;
            }
            get
            {
                return method;
            }
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

                for (int i = 0; i < Attributes.Length; i++)
                {
                    text += attributes[i] + " ";
                }

                if (Value == null || Value.Trim() == "")
                {
                    text += @"}{\f1\cf2 " + Type + @"}\b  " + Name + @"\b0\;";
                }
                else
                {
                    text += @"}{\f1\cf2 " + Type + @"}\b  " + Name + @"\b0  = \i " + Value + @"\i0\;";
                }
                return text;
            }
        }

        public String Code()
        {
            String text = "";
            if (access == "public" || access == "private" || access == "protected")
            {
                text += access + " ";
            }

            for (int i = 0; i < attributes.Length; i++)
            {
                text += attributes[i] + " ";
            }

            if (Value == null || Value.Trim() == "")
            {
                text += Type + " " + Name + ";";
            }
            else
            {
                text += Type + " " + Name + " = " + Value + ";";
            }
            return text;
        }
    }
}
