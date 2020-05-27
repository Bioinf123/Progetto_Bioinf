using System;
using System.IO;

namespace Library_Progetto_Bioinf
{
    public class MetodProgettoBioinf
    {
        public static string res = "resistente.txt";
        public static string sens = "sensibile.txt";
        public static string ReadRes()
        {
            string lineres = "";
            if (File.Exists(res))
            {
                using (StreamReader srres = new StreamReader(res))
                {
                    lineres = srres.ReadToEnd();
                }
            }
            return lineres;
        }
        public static string ReadSens()
        {
            string linesens = "";
            if (File.Exists(sens))
            {
                using (StreamReader srsens = new StreamReader(sens))
                {
                    linesens = srsens.ReadToEnd();
                }
            }
            return linesens;
        }

        public static int Sensibile()
        {
            string linesens = MetodProgettoBioinf.ReadSens();
            int senslength = linesens.Length;
            return senslength;
        }

        public static int Resistente()
        {
            string lineres = MetodProgettoBioinf.ReadRes();
            int reslenght = lineres.Length;
            return reslenght;
        }
    }
}

