using CsvHelper;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace Task1T
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string caminho = "C:\\Input.csv";
            string caminho2 = @"C:\Users\guilherme.santana\Desktop\Output.json";

            var leitor = new CsvReader(new StreamReader(caminho));

            char delimitador = new ValidaDelimitador().IdentificaDelimitador(caminho);
            leitor.Configuration.Delimiter = delimitador.ToString();
            leitor.Configuration.RegisterClassMap<ValidaQualificador>();

            clientes = leitor.GetRecords<Cliente>().Select(x => new Cliente(x.Matricula, 
                                                                            x.TotalCreditos,
                                                                            x.TotalDebitosFacultativos,
                                                                            x.TotalDebitosObrigatorios)).ToList();
            string jsonSerializado = JsonConvert.SerializeObject(clientes); //Converte o arquivo CSV em Json
            File.WriteAllText(caminho2, jsonSerializado);

        }
    }
}
