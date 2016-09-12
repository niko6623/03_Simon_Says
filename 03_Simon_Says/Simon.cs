using System;

namespace _03_Simon_Says
{
    internal class Simon
    {
        internal string Echo(string v)
        {
            return v.ToLower();
        }

        internal string Shout(string v)
        {
            return v.ToUpper();
        }

        internal string Repeat(string v)
        {
            return v + " " + v;
        }

        internal object Repeat(string v1, int v2)
        {
            string All = "";
            for (int i = 0; i < v2; i++)
            {
                All = All+ " " + v1;
            }
            return All.Trim();
        }
    }
}

  





