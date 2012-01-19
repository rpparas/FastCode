using System;
using System.Collections;
using System.Text;

namespace SampleApp
{
    class SyntaxChecker
    {
        /** states:
         *  0   initial state
         *  1   final state
         *  2   underscore found
         *  3   dead state (error)
         */

        public static int NO_ERROR = 0;
        public static int EMPTY = 1;
        public static int START_CHAR = 2;
        public static int ENDING_CHAR = 3;
        public static int CONSECUTIVE = 4;
        public static int SPECIAL_CHAR = 5;

        public static int UNKNOWN_VAL = 6;
        public static int INCOMP_VAL = 7;
        public static int NON_NUMERIC = 8;

        public static int Check(String name)
        {
            char[] contents = name.ToCharArray();
            for (int i = 0, state = 0, error = 0; i < contents.Length; i++)
            {
				switch(state)
				{
					case 0:
						if(char.IsLetter(contents[i]))
						{
							state = 1;
						}
						else if(char.IsDigit(contents[i]))
						{
							state = 3;
	                        error = START_CHAR;
						}
						else if (contents[i] == '_')
						{
							state = 3;
							error = START_CHAR;
						}
						else
						{
							state = 3;
							error = SPECIAL_CHAR;
						}
						break;

					case 1:
						if(contents[i] == '_')
						{
							state = 2;
						}
						else if (i + 1 == contents.Length)
						{
							state = 3;
							error = ENDING_CHAR;
						}
						else if(!char.IsLetter(contents[i]) && !char.IsDigit(contents[i]))
						{
							state = 3;
							error = SPECIAL_CHAR;
						}
						break;

					case 2:
						if(char.IsLetter(contents[i]))
						{
							state = 1;
						}
						else if(char.IsDigit(contents[i]))
						{
							state = 1;
						}
						else if (contents[i] == '_')
						{
							state = 3;
							error = CONSECUTIVE;
						}
						break;

					case 3:
						return error;
				}
			}

            return name.Length == 0 ? EMPTY : NO_ERROR;
        }

        public static bool Check(String type, String value)
        {
			ArrayList primitive = new ArrayList();
			primitive.AddRange(Types.Primitive);
            string cause;

			switch(primitive.IndexOf(type))
			{
				case 0:
					try
					{
						bool.Parse(value);
						return true;
					}
					catch (Exception e)
					{
						cause = e.Message;
						return false;
					}

				case 1:
					try
					{
						byte.Parse(value);
						return true;
					}
					catch (Exception e)
					{
						cause = e.Message;
						return false;
					}

				case 2:
					try
					{
						char.Parse(value);
						return true;
					}
					catch (Exception e)
					{
						cause = e.Message;
						return false;
					}

				case 3:
					try
					{
						double.Parse(value);
						return true;
					}
					catch (Exception e)
					{
						cause = e.Message;
						return false;
					}

				case 4:
					try
					{
						float.Parse(value);
						return true;
					}
					catch (Exception e)
					{
						cause = e.Message;
						return false;
					}

				case 5:
					try
					{
						int.Parse(value);
						return true;
					}
					catch (Exception e)
					{
						cause = e.Message;
						return false;
					}

				case 6:
					try
					{
						long.Parse(value);
						return true;
					}
					catch (Exception e)
					{
						cause = e.Message;
						return false;
					}

				case 7:
					try
					{
						short.Parse(value);
						return true;
					}
					catch (Exception e)
					{
						cause = e.Message;
						return false;
					}

				default:
					return true;
			}
        }

        public static int Type(ArrayList types, String type)
        {
            type = type.Trim();
            if (type == "")
            {
                return 0;
            }
            else if (types.Contains(type))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
