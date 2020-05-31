using System;
using System.IO;

namespace Progetto_Bioinf
    {
    public class MetodiBioinf
    {
        public static string res = "res.txt";
        public static string sens = "sens.txt";
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
        public static int Resistente()
        {
            string linesens = MetodiBioinf.ReadRes();
            int lengthresistente = linesens.Length;
            return lengthresistente;
        }
        public static int Sensibile()
        {
            string linesens = MetodiBioinf.ReadSens();
            int lengthsensibile = linesens.Length;
            return lengthsensibile;
        }
        public static string Uguale()
        {
            string res = MetodiBioinf.ReadRes();
            string sens = MetodiBioinf.ReadSens();
            long p = MetodiBioinf.Diverso();
            string u = "";
            for (int i = 0; i < p; i++)
            {
                u += sens[i];
            }
            return u;
        }
        public static int Diverso()
        {
            string res = MetodiBioinf.ReadRes();
            string sens = MetodiBioinf.ReadSens();
            for (int i = 0; i < Math.Min(sens.Length, res.Length); i++)
            {
                if (sens[i] != res[i])
                    return i;
            }
            return -1;
        }
        public static int Stringhe()
        {
            string res = MetodiBioinf.ReadRes();
            string sens = MetodiBioinf.ReadSens();
            int d = 0;
            for (int i = 0; i < Math.Min(sens.Length, res.Length); i++)
            {
                if (sens[i] != res[i])
                {
                    d++;
                }
            }
            return d;

        }
    }
}

