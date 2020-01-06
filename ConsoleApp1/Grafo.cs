using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CGrafo
    { 

        private int[,] MatrizAdj;
        private int[] grau;
        private int nos;

        public CGrafo(int pNos)
        {
            nos = pNos;

            // Instacia a matriz de adjacencia
            MatrizAdj = new int[nos, nos];

            // Instancia correção de grau
            grau = new int[nos];
        }

        public void AdicionaAresta(int pNoInicio, int pNoFinal)
        {
            MatrizAdj[pNoInicio, pNoFinal] = 1;
        }

        //Novo
        public void AdicionaAresta(int pNoInicio, int pNoFinal, int pPeso)
        {
            MatrizAdj[pNoInicio, pNoFinal] = pPeso;
        }

        public void MostraAdjacencia()
        {
            int n = 0;
            int m = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (n = 0; n < nos; n++)
                Console.Write("\t{0}", n);

            Console.WriteLine();

            for (n = 0; n < nos; n++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(n);
                for (m = 0; m < nos; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write("\t{0}", MatrizAdj[n, m]);
                }
                Console.WriteLine();
            }
        }
        public int ObterAdjacencia(int pFila, int pColuna)
        {
            return MatrizAdj[pFila, pColuna];
        }

        public void CalcularGrau()
        {
            for (int n = 0; n < nos; n++)
            {
                for (int m = 0; m < nos; m++)
                {
                    if (MatrizAdj[m, n] == 1)
                        grau[n]++;
                }
            }
        }

        public void MostrarGrau()
        {
            int n = 0;
            Console.ForegroundColor = ConsoleColor.White;
            for (n = 0; n < nos; n++)
                Console.WriteLine("Nos: {0}, {1}", n, grau[n]);
        }

        public int MenorCaminho()
        {
            bool encontrado = false;
            int n = 0;

            for (n = 0; n < nos; n++)
            {
                if (grau[n] == 0)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                return n;
            else
                return -1;

        }

        public void DecresceGrau(int pNo)
        {
            grau[pNo] = -1;

            for (int n = 0; n < nos; n++)
            {
                if (MatrizAdj[pNo, n] == 1)
                    grau[n]--;
            }
        }


    }       




        
}


    
