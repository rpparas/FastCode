using System;
using System.Collections;
using System.Text;

namespace SampleApp
{
    class Conditions
    {
        private ArrayList statements;
        private IfState else1;

        public Conditions()
        {
            statements = new ArrayList();
        }

        public void AddIf(IfState NewIf)
        {
            statements.Add(NewIf);
        }

        public Object[] Statements
        {
            get
            {
                return statements.ToArray();
            }
        }

        public IfState Else
        {
            set
            {
                else1 = value;
            }
            get
            {
                return else1;
            }
        }

        public String Rtf
        {
            get
            {
                Object[] statements = this.statements.ToArray();

                String text = @"{\rtf1\ansi{\fonttbl\f0\fswissVerdana;}{\colortbl;\red0\green102\blue255;\red255\green0\blue0;\red0\green176\blue80;}\f0";
                text += @"if(" + ((IfState)statements[0]).Contents + @")\line ";
                text += @"\{\line     " + ((IfState)statements[0]).Statements + @"\line\}\line ";

                for (int i = 1; i < statements.Length; i++)
                {
                    text += @"else if (" + ((IfState)statements[i]).Contents + @")\line ";
                    text += @"\{\line     " + ((IfState)statements[i]).Statements + @"\line\}\line ";
                }

                if (Else != null)
                {
                    text += @"else \line ";
                    text += @"\{\line     " + Else.Statements + @"\line\} ";
                }
                return text;
            }
        }
    }
}
