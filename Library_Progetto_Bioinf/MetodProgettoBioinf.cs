using System;
using System.IO;

namespace Library_Progetto_Bioinf
{
    public class MetodProgettoBioinf
    {
        public static string a = "resistente.txt";
        public static string b = "sensibile.txt";
        public static string ReadSens()
        {
            string lines = " ";
            if (File.Exists(b))
            {
                using (StreamReader sr = new StreamReader(b))
                {
                    lines = sr.ReadToEnd();
                }
            }
            return lines;
        }

        public static int Sensibile()
        {
            string lines = MetodProgettoBioinf.ReadSens();
            int blength = lines.Length;
            return blength;
        }
    }
}

