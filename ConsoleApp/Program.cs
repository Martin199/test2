using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> listaSinCodificar = new List<string>();



            string fraseSinCodificar = Convert.ToString(Console.ReadLine());
            string palabraConEspacio = string.Empty;

            for (int i = 1; i <= fraseSinCodificar.Length; i++)
            {
                if ((i % 5) == 0 && i != 1)
                {
                    palabraConEspacio += fraseSinCodificar[i - 1];
                    listaSinCodificar.Add(palabraConEspacio);
                    palabraConEspacio = string.Empty;
                }
                else
                {
                    palabraConEspacio += fraseSinCodificar[i - 1];
                }
            }
            if (palabraConEspacio != string.Empty)
            {
                listaSinCodificar.Add(palabraConEspacio);
            }


            Dictionary<string, string> dicc = new Dictionary<string, string>();
            Random generator = new Random();
            int ii = 0;
            string mesajeCodificado = string.Empty;
            string clavesOrdenadas = string.Empty;

            foreach (var item in listaSinCodificar)
            {
                Dictionary<string, string> diccGrupo = new Dictionary<string, string>();

                foreach (var letra in item)
                {
                    string clave = generator.Next(0, 10000).ToString("D4");


                    clavesOrdenadas += (letra.ToString() + " = " + clave + ", ");

                    if (!diccGrupo.ContainsValue(letra.ToString()))
                    {
                        diccGrupo.Add(clave, letra.ToString());
                        dicc.Add(clave, letra.ToString());

                        mesajeCodificado += clave + ";";
                    }
                    else
                    {
                        mesajeCodificado += clave + ";";
                    }


                }
  
                clavesOrdenadas += "\n";

            }


            Console.WriteLine(mesajeCodificado + "\n");


            Console.WriteLine(clavesOrdenadas + "\n");
            Console.ReadKey();
        }
    }
}
