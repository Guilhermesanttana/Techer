using CsvHelper.Configuration;

namespace Task1T
{
    class ValidaQualificador : ClassMap<Cliente>
    {

        public ValidaQualificador()
        {
            Map(m => m.Matricula).Name("Matricula", "matricula");
            Map(m => m.TotalCreditos).Name("TotalCreditos", "totalcreditos");
            Map(m => m.TotalDebitosFacultativos).Name("TotalDebitosFacultativos", "totaldebitosfacultativos");
            Map(m => m.TotalDebitosObrigatorios).Name("TotalDebitosObrigatorios", "totaldebitosobrigatorios");
            Map(m => m.MargemConsignavel).Optional(); //Colunas que nao existem no CSV mas fazem parte da classe Cliente 
            Map(m => m.MargemCartao).Optional();

        }
    }
}
