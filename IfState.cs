using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    class IfState
    {
        private String contents;
        private String statements;

        public IfState(String contents, String statements)
        {
            Contents = contents;
            Statements = statements;
        }

        public String Contents
        {
            set
            {
                contents = value;
            }
            get
            {
                return contents;
            }
        }

        public String Statements
        {
            set
            {
                statements = value;
            }
            get
            {
                return statements;
            }
        }
    }
}
