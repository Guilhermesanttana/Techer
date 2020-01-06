using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Models
{
    public class Dijkstra
    {

        /*

        using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int inicio = 0;
            int final = 0;
            int distancia = 0;
            int n = 0;
            int qtdNos = 4;
            string dato = "";
            int atual = 0;
            int coluna = 0;


            CGrafo meuGrafo = new CGrafo(qtdNos);


            meuGrafo.AdicionaAresta(0, 1, 25);
            meuGrafo.AdicionaAresta(0, 2, 39);
            meuGrafo.AdicionaAresta(0, 3, 179);
            meuGrafo.AdicionaAresta(1, 0, 25);
            meuGrafo.AdicionaAresta(1, 2, 64);
            meuGrafo.AdicionaAresta(1, 3, 174);
            meuGrafo.AdicionaAresta(2, 0, 39);
            meuGrafo.AdicionaAresta(2, 1, 64);
            meuGrafo.AdicionaAresta(2, 3, 194);
            meuGrafo.AdicionaAresta(3, 0, 179);
            meuGrafo.AdicionaAresta(3, 1, 174);
            meuGrafo.AdicionaAresta(3, 2, 194);


            
            meuGrafo.AdicionaAresta(0, 1, 25);
            meuGrafo.AdicionaAresta(0, 2, 39);
            meuGrafo.AdicionaAresta(0, 3, 179);
            meuGrafo.AdicionaAresta(1, 0, 25);
            meuGrafo.AdicionaAresta(1, 2, 64);
            meuGrafo.AdicionaAresta(1, 3, 174);
            meuGrafo.AdicionaAresta(2, 0, 39);
            meuGrafo.AdicionaAresta(2, 1, 64);
            meuGrafo.AdicionaAresta(2, 3, 194);
            meuGrafo.AdicionaAresta(3, 0, 179);
            meuGrafo.AdicionaAresta(3, 1, 174);
            meuGrafo.AdicionaAresta(3, 2, 194);


            meuGrafo.AdicionaAresta(0, 1, 2);
            meuGrafo.AdicionaAresta(0, 3, 1);
            meuGrafo.AdicionaAresta(1, 3, 3);
            meuGrafo.AdicionaAresta(1, 4, 10);
            meuGrafo.AdicionaAresta(2, 0, 4);
            meuGrafo.AdicionaAresta(2, 5, 5);
            meuGrafo.AdicionaAresta(3, 2, 2);
            meuGrafo.AdicionaAresta(3, 4, 2);
            meuGrafo.AdicionaAresta(3, 6, 4);
            meuGrafo.AdicionaAresta(4, 6, 6);
            meuGrafo.AdicionaAresta(6, 5, 1);


        meuGrafo.MostraAdjacencia();

            Console.WriteLine("Inicio: ");
            dato = Console.ReadLine();
            inicio = Convert.ToInt32(dato);

            Console.WriteLine("Final: ");
            dato = Console.ReadLine();
            final = Convert.ToInt32(dato);


            //Cria a tabela
            // 0 - Visitado
            // 1 - Distancia
            // 2 - Menor

            int[,] tabela = new int[qtdNos, 3];

            //inicializa tabela
            for (n = 0; n<qtdNos; n++)
            {
                tabela[n, 0] = 0;
                tabela[n, 1] = int.MaxValue;
                tabela[n, 2] = 0;
            }
    tabela[inicio, 1] = 0;

            MostrarTabela(tabela);


    //Inicio Dijkstra
    atual = inicio;

            do
            {
                //marca no como visitado
                tabela[atual, 0] = 1;

                for (coluna = 0; coluna<qtdNos; coluna++)
                {
                    // Busca o proximo no e ve se o valor dele é diferente de zero
                    if (meuGrafo.ObterAdjacencia(atual, coluna) != 0)
                    {
                        // Calcula a distancia
                        distancia = meuGrafo.ObterAdjacencia(atual, coluna) + tabela[atual, 1];

                        // Coloca a distancia
                        if (distancia<tabela[coluna, 1])
                        {
                            //Adiciona a soma da distancia
                            tabela[coluna, 1] = distancia;

                            // Sinaliza que foi visitado
                            tabela[coluna, 2] = atual;
                        }
                    }
                }

                // O novo atual é o No com a menor distancia do que havia sido visitado

                int indiceMenor = -1;
int distanciaMenor = int.MaxValue;

                for (int x = 0; x<qtdNos; x++)
                {
                    if (tabela[x, 1] < distanciaMenor && tabela[x, 0] == 0)
                    {
                        indiceMenor = x;
                        distanciaMenor = tabela[x, 1];
                    }
                }

                atual = indiceMenor;
            } while (atual != -1);

            MostrarTabela(tabela);

//Obtem a rota
List<int> rota = new List<int>();
int no = final;

            while (no != inicio)
            {
                rota.Add(no);
                no = tabela[no, 2];
            }
            rota.Add(inicio);

            rota.Reverse();

            foreach (int posicao in rota)
                Console.Write("{0}->", posicao);

            Console.WriteLine();








            


            var clientes = new Cliente().ListarClientes();



            Entregador entregador01 = new Entregador();
            entregador01.IdEntregador = 1;
            entregador01.Nome = "Nome01";
            entregador01.Telefone = 30880840;
            entregador01.Clientes = new List<Cliente>();
            entregador01.Clientes = clientes;


            Itinerario entregas = new Itinerario(entregador01);



            Console.WriteLine(entregador01);

            Console.ReadKey();

            

        }

        public static void MostrarTabela(int[,] pTabela)
{
    int n = 0;

    for (n = 0; n < pTabela.GetLength(0); n++)
    {
        Console.WriteLine("{0}-> {1}\t{2}\t{3}", n, pTabela[n, 0], pTabela[n, 1], pTabela[n, 2]);
    }

    Console.WriteLine("-------------------");
}

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nome { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }


    public Cliente()
    {
        _clientes = new List<Cliente>();
    }

    public List<Cliente> _clientes;
    public List<Cliente> ListarClientes()
    {
        _clientes.Add(new Cliente() { IdCliente = 1, Nome = "Rakan", Latitude = 10, Longitude = 50 });
        _clientes.Add(new Cliente() { IdCliente = 2, Nome = "Mikasa", Latitude = 50, Longitude = 100 });
        _clientes.Add(new Cliente() { IdCliente = 3, Nome = "Bruna", Latitude = 35, Longitude = 80 });
        _clientes.Add(new Cliente() { IdCliente = 4, Nome = "Guilherme", Latitude = 200, Longitude = 10 });

        return _clientes;
    }

}

public class Entregador
{
    [Key]
    public int IdEntregador { get; set; }
    [MaxLength(40)]
    public string Nome { get; set; }
    public int Telefone { get; set; }

    public List<Cliente> Clientes { get; set; }



    public Entregador()
    {

    }

    public Entregador(List<Cliente> listaDeClientes)
    {
        List<Cliente> cliente = listaDeClientes;
    }
}


public class Itinerario
{
    public int distancias { get; set; }
    public List<Cliente> Entregas { get; set; }

    public Itinerario(Entregador entregador)
    {

        var entregas = new List<Cliente>();

        foreach (var i in entregas)
        {


        }
    }


}        

    }
}



           */
        /*

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






            */
    }
}
