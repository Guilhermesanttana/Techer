using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task1T
{
    class ValidaDelimitador
    {
        public char IdentificaDelimitador(string caminho)
        {
            StreamReader sr = new StreamReader(caminho);
            string linha = sr.ReadLine();
            int pontoVirgula = 0;
            int virgula = 0;
            char delimitador;

            for(int i = 0; i < linha.Length ; i++)
            {
                if (linha[i] == ';')
                    pontoVirgula++;
                else if (linha[i] == ',')
                    virgula++;
            }

            if (pontoVirgula > virgula)
                delimitador = ';';
            else
                delimitador = ',';

            return delimitador;
        }        
    }
}
