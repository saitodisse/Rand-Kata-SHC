using System;

namespace NumerosRomanosTeste
{
    public class ConversorRomano
    {
        private NumeroRomanoLista _romanos;

        public ConversorRomano()
        {
            InicializarRomanos();
        }
        private void InicializarRomanos()
        {
            _romanos = new NumeroRomanoLista();
            _romanos.Add(new NumeroRomano(0, ""));
            _romanos.Add(new NumeroRomano(1, "I"));
            _romanos.Add(new NumeroRomano(5, "V"));
            _romanos.Add(new NumeroRomano(10, "X"));
            _romanos.Add(new NumeroRomano(50, "L"));
            _romanos.Add(new NumeroRomano(100, "C"));
            _romanos.Add(new NumeroRomano(500, "D"));
            _romanos.Add(new NumeroRomano(1000, "M"));
            _romanos.Add(new NumeroRomano(5000, "V'"));
            _romanos.Add(new NumeroRomano(10000, "X'"));
            _romanos.Add(new NumeroRomano(50000, "L'"));
            _romanos.Add(new NumeroRomano(100000, "C'"));
            _romanos.Add(new NumeroRomano(500000, "D'"));
            _romanos.Add(new NumeroRomano(1000000, "M'"));
        }

        public string ConverterDecimal(int numero)
        {
            int tamanho = numero.ToString().Length;
            var multiplo10 = (int)Math.Pow(10, tamanho);

            int anterior = multiplo10/10;
            int atual = multiplo10/2;
            int proximo = multiplo10;

            string letraRomana = ObterLetraRomana(numero / anterior, anterior, atual, proximo);
            if(numero > 10)
            {
                string proximoRomano = ConverterDecimal(numero%anterior);
                
                if (!string.IsNullOrEmpty(proximoRomano))
                    return letraRomana + " " + proximoRomano;
                
                return letraRomana;
            }

            return letraRomana;
        }

        private string ObterLetraRomana(int numero, int anterior, int atual, int proximo)
        {
            switch (numero)
            {
                case 0:
                    return "";
                case 1:
                    return _romanos.GetNome(anterior);
                case 2:
                    return _romanos.GetNome(anterior) + _romanos.GetNome(anterior);
                case 3:
                    return _romanos.GetNome(anterior) + _romanos.GetNome(anterior) + _romanos.GetNome(anterior);
                case 4:
                    return _romanos.GetNome(anterior) + _romanos.GetNome(atual);
                case 5:
                    return _romanos.GetNome(atual);
                case 6:
                    return _romanos.GetNome(atual) + _romanos.GetNome(anterior);
                case 7:
                    return _romanos.GetNome(atual) + _romanos.GetNome(anterior) + _romanos.GetNome(anterior);
                case 8:
                    return _romanos.GetNome(atual) + _romanos.GetNome(anterior) + _romanos.GetNome(anterior) + _romanos.GetNome(anterior);
                case 9:
                    return _romanos.GetNome(anterior) + _romanos.GetNome(proximo);
                case 10:
                    return _romanos.GetNome(proximo);
                default:
                    throw new Exception("Erro, o número " + numero + " não é suportado.");
            }
        }
    }
}