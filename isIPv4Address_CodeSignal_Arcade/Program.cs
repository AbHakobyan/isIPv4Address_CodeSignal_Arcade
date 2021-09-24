using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isIPv4Address_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "01.233.161.131";
            bool v = isIPv4Address(s);
            Console.WriteLine(v);
        }

        static bool isIPv4Address(string inputString)
        { 
            List<int> list = new List<int>();
            bool x = true;
            int y = 0;
            string n = "";
            string[] st = inputString.Split('.');
            if (st.Length == 4)
            {
                for (int i = 0; i < st.Length; i++)
                {
                    if (st[i] != "")
                    {
                        if (st[i].StartsWith("0") == true && st[i].Length > 1)
                        {
                            return false;
                        }
                        else
                        {
                            x = int.TryParse(st[i], out y);
                            if (x == true)
                            {
                                list.Add(Convert.ToInt32(st[i]));
                            }
                        }
                    }

                }
            }
            if (list.Count == 4)
            {
                foreach (var item in list)
                {
                    if (item > 255)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
