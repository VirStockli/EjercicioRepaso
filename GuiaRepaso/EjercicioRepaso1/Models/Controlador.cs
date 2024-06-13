using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso1.Models
{
    public class Controlador
    {
        public int[] VecEnt = new int[1000];
        public int ContNum = 0;
        double Promedio;
        public void IngresarValor(int valor)
        {
            VecEnt[ContNum] = valor;
            ContNum++;
        }
        public double CalcularPromedio()
        {
            int Acum = 0;
            for (int i = 0; i < ContNum; i++)
            {
                Acum += VecEnt[i];

            }
            if (ContNum > 0)
            {
                Promedio = Acum / ContNum;
            }
            return Promedio;
        }
        
        public int [] DevolverProm (ref int contador)
        {
            int[] MayorProm = new int[ContNum];
            double Promedio = CalcularPromedio();

            for (int i = 0; i < ContNum; i++)
            {
                if (VecEnt[i] >= Promedio)
                {
                    MayorProm[contador] = VecEnt[i];
                    contador++;
                }
            }
            return MayorProm;

        }
        public void Burbuja(int[]valores, int contador)
        {
            int aux;
            for (int i = 0; i < contador-1;i++)
            {
                for (int j = i+1; j < contador;j++)
                {
                    if (valores[i]> valores[j])
                    {
                        aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                    }
                }
            }
        }
    }
}
