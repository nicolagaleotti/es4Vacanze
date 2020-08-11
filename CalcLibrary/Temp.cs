using System;

namespace CalcLibrary
{
    public class Temp
    {
        public static double MediaTemperature(double[] temperature)
        {
            double resp = 0;
            if (temperature != null && temperature.Length > 0)
            {
                int quantita = temperature.Length;
                double somma = 0;
                for (int i = 0; i < quantita; i++)
                {
                    somma += temperature[i];
                }
                resp = somma / quantita;
            }
            else
                resp = double.NaN;
            return resp;
        }
    }
}
