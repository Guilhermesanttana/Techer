using System;
using System.Collections.Generic;
using System.Text;

namespace Task1T
{
    class CalculaMargem
    {

        //Calcula e retorna a margem consignavel 
        public double Margem(double totalCreditos, double totalDebitosObrigatorios, double totalDebitosFacultativos)
        {
            double margem = (totalCreditos - totalDebitosObrigatorios) * 0.3f;
            double margemLivre = Math.Round((margem - totalDebitosFacultativos), 2);

            return margemLivre;
        }

        //Calcula e retorna a margem cartão
        public double MargemCartao(double totalCreditos, double totalDebitosObrigatorios) 
        {

            double margemCartao = Math.Round((totalCreditos - totalDebitosObrigatorios) * 0.05f, 2);

            return margemCartao;
        }
    }
}
