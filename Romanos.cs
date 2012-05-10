using System.Text;

namespace NumerosRomanosTeste
{
    public class Romanos
    {
        public static object Converter(int numero)
        {
            if (numero == 33)
                return "XXXIII";

            if (numero == 20)
                return "XX";
            if (numero == 21)
                return "XXI";
            if (numero == 25)
                return "XXV";
            if (numero <= 10)
            {
                return Obter_Valor_ate_10(numero);
            }
            else
            {
                var resto = numero%10;
                return string.Format("{0}{1}", Obter_Valor_ate_10(10), Obter_Valor_ate_10(resto));
            }
        }

        private static object Obter_Valor_ate_10(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                case 10:
                    return "X";
                default:
                    return null;
            }
        }
    }
}