using System;
using System.Collections;
using System.Windows.Forms;
using System.Text;

namespace SampleApp
{
    class Types
    {
        public const String OBJECT = "Object";
        public const String STRING = "String";
        public const String BOOLEAN = "boolean";
        private static Object[] primitive = { "boolean", "byte", "character", "double", "float", "integer", "long", "short" };
        private static Object[] supported = { "void", "Object", "String", "Character", "Integer" };
        private static ArrayList instance;
        private static ArrayList local;
        private static ArrayList classes;

        private static ClassInfo ci;
        private static Method m;
        private static Variable v;

        public Types()
        {
            instance = new ArrayList();
            local = new ArrayList();
            classes  = new ArrayList();
        }

        public static void InitializeContents()
        {
            instance = new ArrayList();
            local = new ArrayList();
            classes = new ArrayList();
            ci = new ClassInfo();
            m = new Method();

            ci.ClassName = "Object";
            m.Name = "toString";
            m.Access = "public";
            m.Attributes = null;
            m.ReturnType = "String";
            m.Parameters = new ArrayList();
            ci.AddMethod(m);
            classes.Add(ci);

            ci = new ClassInfo();
            ci.ClassName = "Character";
            m = new Method();
            m.Name = "isUpperCase";
            m.Access = "public";
            m.Attributes = new String[1]{"static"};
            m.ReturnType = "boolean";
            m.Parameters = new ArrayList();
            v = new Variable();
            v.Name = "ch";
            v.Type = "char";
            m.Parameters.Add(v);
            ci.AddMethod(m);

            m = new Method();
            m.Name = "isDigit";
            m.Access = "public";
            m.Attributes = new String[1]{"static"};
            m.ReturnType = "boolean";
            m.Parameters = new ArrayList();
            v = new Variable();
            v.Name = "ch";
            v.Type = "char";
            m.Parameters.Add(v);
            ci.AddMethod(m);
            classes.Add(ci);
        }

        public static void AddClass(ClassInfo ci)
        {
            classes.Add(ci);
        }

        public static Object[] Classes
        {
            get
            {
                return classes.ToArray();
            }
        }



        public static Object[] InstanceVariables
        {
            get
            {
                return instance.ToArray();
            }
        }

        public static Object[] Primitive
        {
            get
            {
                return primitive;
            }
        }

        public static Object[] Supported
        {
            get
            {
                return supported;
            }
        }

        public static bool AddInstanceVariable(Variable variable)
        {
            if (instance == null)
            {
                instance = new ArrayList();
            }

            
            Variable old = GetVariable(instance, variable.Name);
            if (old == null)
            {
                instance.Add(variable);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean RemoveInstanceVariable(Variable variable)
        {
            if (instance.Contains(variable))
            {
                instance.Remove(variable);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean RemoveInstanceVariable(String name)
        {
            Variable v = GetVariable(instance, name);
            if (v == null)
            {
                return false;
            }
            else
            {
                instance.Remove(v);
                return true;
            }
        }

        public static Boolean ContainsInstanceVariable(Variable variable)
        {
            return instance.Contains(variable);
        }

        public static Boolean ContainsInstanceVariable(String name)
        {
            Variable v = GetVariable(instance, name);
            return (v != null);
        }

        public static void AddLocalVariable(Variable variable)
        {
            Variable old = GetVariable(local, variable.Name);
            if (old != null)
            {
                RemoveLocalVariable(old);
            }
            local.Add(variable);
        }

        public static Boolean RemoveLocalVariable(Variable variable)
        {
            if (local.Contains(variable))
            {
                local.Remove(variable);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Variable GetInstanceVariable(String name)
        {
            Object[] NewList = instance.ToArray();
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

        public static Variable GetMethodVariable(String methodName, String varName)
        {
            Object[] NewList = local.ToArray();
            for (int i = 0; i < NewList.Length; i++)
            {
                Variable v = (Variable)NewList[i];
                if (v.Name == varName && v.Method == methodName)
                {
                    return v;
                }
            }
            return null;
        }

        private static Variable GetVariable(ArrayList list, String name)
        {
            Object[] NewList = list.ToArray();
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

        public static Object[] GetMethodVariables(String MethodName)
        {
            Object[] NewList = local.ToArray();
            ArrayList matches = new ArrayList();
            for (int i = 0; i < NewList.Length; i++)
            {
                Variable v = (Variable)NewList[i];
                if (v.Method == MethodName)
                {
                    matches.Add(v);
                }
            }
            return matches.ToArray();
        }

        public static int CheckName(String name)
        {
            int error = SyntaxChecker.Check(name);
            switch (error)
            {
                case 1:
                    MessageBox.Show("Please supply a name for this variable.", "Invalid Variable Name");
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
            return error;
        }

        public static int CheckType(String type)
        {
            type = type.Replace("[]", "");
            int error = SyntaxChecker.Check(type);

            switch (error)
            {
                case 1:
                    MessageBox.Show("Please supply a name for this variable.", "Invalid Variable Name");
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
            return error;
        }

        public static Boolean IsMatch(String type, String value)
        {
            String cause = "";
            if (type == "boolean")
            {
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
            }
            else if(type == "byte")
            {
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
            }
            else if (type == "char")
            {
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
            }
            else if (type == "double")
            {
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
            }
            else if (type == "float")
            {
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
            }
            else if (type == "int")
            {
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
            }
            else if (type == "long")
            {
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
            }
            else if (type == "short")
            {
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
            }
            else
            {
                return true;
            }
        }

        public static bool IsValid(String value)
        {
            bool valid = false;
            valid = IsMatch("boolean", value) || IsMatch("byte", value) ||
                IsMatch("char", value) || IsMatch("double", value) ||
                IsMatch("float", value) || IsMatch("int", value) ||
                IsMatch("long", value) || IsMatch("short", value);
            return valid;
        }

    }
}
