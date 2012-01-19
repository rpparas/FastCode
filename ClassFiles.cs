using System;
using System.Collections;
using System.Text;

namespace SampleApp
{
    class ClassFiles
    {
        private static ArrayList list = new ArrayList();

        public static void Add(ClassInfo ci)
	    {
		    ClassInfo old = GetClassInfo(ci.FileName);
		    if(old != null)
		    {
			    Remove(old);
		    }
		    list.Add(ci);
	    }

	    public static void AddOverwrite(ClassInfo ci)
	    {
	        ClassInfo old = GetClassInfo(ci.FileName);
	        if(old != null)
	        {
		        Remove(old);
	        }
	        list.Add(ci);	
	    }

        public static Boolean Remove(ClassInfo ci)
        {
            if (list.Contains(ci))
            {
                list.Remove(ci);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Remove(String fn)
        {
            ClassInfo ci = GetClassInfo(fn);
            if (ci == null)
            {
                return false;
            }
            else
            {
                list.Remove(ci);
                return true;
            }
        }

        public static void RemoveAll()
        {
            list.RemoveRange(0, list.Count);
        }

        public static Boolean Contains(ClassInfo ci)
        {
            return list.Contains(ci);
        }
       
        public static Boolean Contains(String fn)
        {
            ClassInfo c = GetClassInfo(fn);
            return (c != null);
        }

        public static int Count()
        {
            return list.Count;
        }

        public static ClassInfo GetClassInfo(String fn)
        {
            Object[] NewList = list.ToArray();
            for(int i = 0; i < NewList.Length; i++)
            {
                ClassInfo ci = (ClassInfo)NewList[i];
                if (ci.FileName == fn)
                {
                    return ci;
                }
            }
            return null;
        }
    }
}
