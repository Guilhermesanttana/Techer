using System;
using System.Collections.Generic;
using System.Text;

namespace Task1T
{
    public class Cliente
    {
        public string Matricula { get; set; }
        public double TotalCreditos { get; set; }
        public double TotalDebitosObrigatorios { get; set; }
        public double TotalDebitosFacultativos { get; set; }
        public double MargemConsignavel { get; set; }
        public double MargemCartao { get; set; }

        public Cliente(string matricula, double totalCreditos, double totalDebitosObrigatorios, double totalDebitosFacultativos)
        {
            CalculaMargem calc = new CalculaMargem();
            
            Matricula = matricula;
            TotalCreditos = totalCreditos;
            TotalDebitosObrigatorios = totalDebitosObrigatorios;
            TotalDebitosFacultativos = totalDebitosFacultativos;
            MargemConsignavel = calc.Margem(totalCreditos, totalDebitosObrigatorios, totalDebitosFacultativos);
            MargemCartao = calc.MargemCartao(totalCreditos, totalDebitosObrigatorios);
        }

        private Cliente()
        {

        }
    }
}
