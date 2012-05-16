using System;
using System.Collections.Generic;
using System.Linq;

namespace NumerosRomanosTeste
{
    public class NumeroRomano
    {
        public int NumeroDecimal { get; set; }
        public string NomeRomano { get; set; }
    }

    public class NumeroRomanoLista : List<NumeroRomano>
    {
        public string GetNome (int numero)
        {
            NumeroRomano numeroRomano = this.First(x => x.NumeroDecimal == numero);
            return numeroRomano.NomeRomano;
        }
    }



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

            var numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 0;
            numeroRomano.NomeRomano = "";
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 1;
            numeroRomano.NomeRomano = "I";
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 5;
            numeroRomano.NomeRomano = "V";
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 10;
            numeroRomano.NomeRomano = "X";
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 50;
            numeroRomano.NomeRomano = "L";
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 100;
            numeroRomano.NomeRomano = "C";
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 500;
            numeroRomano.NomeRomano = "D";
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 1000;
            numeroRomano.NomeRomano = "M";
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 10000;
            numeroRomano.NomeRomano = "X'";
            _romanos.Add(numeroRomano);
        }

        public string ConverterDecimal(int numero)
        {
            if (numero <= 10)
            {
                string unidade = ObterLetras(numero, 1, 5, 10);
                return unidade;
            }
            if (numero <= 100)
            {
                string dezena = ObterLetras(numero/10, 10, 50, 100);
                return dezena + ConverterDecimal(numero % 10);
            }
            if (numero <= 1000)
            {
                string centena = ObterLetras(numero/100, 100, 500, 1000);
                return centena + ConverterDecimal(numero % 100);
            }
            if (numero <= 10000)
            {
                string milhar = ObterLetras(numero/1000, 1000, 5000, 10000);
                return milhar + ConverterDecimal(numero % 1000);
            }

            return string.Empty;
        }



        private string ObterLetras(int numero, int anterior, int atual, int proximo)
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
                    throw new Exception("erro numero = " + numero);
                    //int dezena = numero/10;
                    //string primeiroCaracter;
                    //if (dezena < 5)
                    //{
                    //    primeiroCaracter = ObterLetras(dezena, 10, 0, 50);
                    //}
                    //else
                    //{
                    //    primeiroCaracter = ObterLetras(dezena, 5, 10, 50);
                    //}

                    //string segundoCaracter;

                    //int unidade = numero % 10;
                    //if (unidade <= 0)
                    //{
                    //    return primeiroCaracter;
                    //}
                    //else if (unidade > 5 && unidade <= 10)
                    //{
                    //    unidade -= 5;
                    //    segundoCaracter = ObterLetras(unidade, 1, 5, 10);
                    //    return primeiroCaracter + segundoCaracter;
                    //}
                    //else
                    //{
                    //    segundoCaracter = ObterLetras(unidade, 1, 0, 5);
                    //    return primeiroCaracter + segundoCaracter;
                    //}
            }
        }
    }
}