namespace NumerosRomanosTeste
{
    public class NumeroRomano
    {
        public NumeroRomano(int numeroDecimal, string numeroRomano)
        {
            NumeroDecimal = numeroDecimal;
            NomeRomano = numeroRomano;
        }
        public int NumeroDecimal { get; set; }
        public string NomeRomano { get; set; }
    }
}