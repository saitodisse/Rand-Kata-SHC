using System;
using System.Collections.Generic;
using System.Linq;

namespace NumerosRomanosTeste
{
    public class NumeroRomano
    {
        public int NumeroDecimal { get; set; }
        public string NomeRomano { get; set; }
        public bool Repete { get; set; }
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
            numeroRomano.Repete = false;
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 1;
            numeroRomano.NomeRomano = "I";
            numeroRomano.Repete = true;
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 5;
            numeroRomano.NomeRomano = "V";
            numeroRomano.Repete = false;
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 10;
            numeroRomano.NomeRomano = "X";
            numeroRomano.Repete = true;
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 50;
            numeroRomano.NomeRomano = "L";
            numeroRomano.Repete = false;
            _romanos.Add(numeroRomano);

            numeroRomano = new NumeroRomano();
            numeroRomano.NumeroDecimal = 100;
            numeroRomano.NomeRomano = "C";
            numeroRomano.Repete = true;
            _romanos.Add(numeroRomano);
        }

        public string ConverterDecimal(int numero)
        {
            if (numero >= 1 && numero <= 5)
            {
                return ObterLetras(numero, 1, 0, 5);
            }
            if (numero >= 6 && numero <= 10)
            {
                return ObterLetras(numero - 5, 1, 5, 10);    
            }
            if (numero >= 11 && numero <= 99)
            {
                return ObterLetras(numero, 1, 5, 10);
            }
            
            return string.Empty;
        }



        private string ObterLetras(int numero, int anterior, int atual, int proximo)
        {
            switch (numero)
            {
                case 1:
                    return _romanos.GetNome(atual) + _romanos.GetNome(anterior);
                case 2:
                    return _romanos.GetNome(atual) + _romanos.GetNome(anterior) + _romanos.GetNome(anterior);
                case 3:
                    return _romanos.GetNome(atual) + _romanos.GetNome(anterior) + _romanos.GetNome(anterior) + _romanos.GetNome(anterior);
                case 4:
                    return _romanos.GetNome(anterior) + _romanos.GetNome(proximo);
                case 5:
                    return _romanos.GetNome(proximo);
                default:
                    int dezena = numero/10;
                    string primeiroCaracter;
                    if (dezena < 5)
                    {
                        primeiroCaracter = ObterLetras(dezena, 10, 0, 50);
                    }
                    else
                    {
                        primeiroCaracter = ObterLetras(dezena, 5, 10, 50);
                    }

                    string segundoCaracter;

                    int unidade = numero % 10;
                    if (unidade <= 0)
                    {
                        return primeiroCaracter;
                    }
                    else if (unidade > 5 && unidade <= 10)
                    {
                        unidade -= 5;
                        segundoCaracter = ObterLetras(unidade, 1, 5, 10);
                        return primeiroCaracter + segundoCaracter;
                    }
                    else
                    {
                        segundoCaracter = ObterLetras(unidade, 1, 0, 5);
                        return primeiroCaracter + segundoCaracter;
                    }
            }
        }
    }
}