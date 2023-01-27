using System;
namespace Projekt_khamzat_test
{
    class Program
    {
        static void Main()
        {

            double[] temperatur = new double[7];

                 temperatur[0] = 4.5;
                 temperatur[1] = 3.2;
                 temperatur[2] = 6.7;
                 temperatur[3] = 6.1;
                 temperatur[4] = 2.1;
                 temperatur[5] = 1.6;
                 temperatur[6] = 2.9;

            double sum = temperatur[0] + temperatur[1] + temperatur[2] + temperatur[3] + temperatur[4] + temperatur[5] + temperatur[6];

                Console.WriteLine("medel temperaturen är:" + sum / 7);







        }
    }

}
            