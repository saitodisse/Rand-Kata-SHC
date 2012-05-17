using System.Collections.Generic;
using System.Linq;

namespace NumerosRomanosTeste
{
    public class NumeroRomanoLista : List<NumeroRomano>
    {
        public string GetNome(int numero)
        {
            NumeroRomano numeroRomano = this.First(x => x.NumeroDecimal == numero);
            return numeroRomano.NomeRomano;
        }
    }
}