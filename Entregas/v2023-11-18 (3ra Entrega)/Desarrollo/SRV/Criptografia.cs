using System;
using System.Text;

namespace SRV
{
    public static class Criptografia
    {
        public static string Encriptar(string pCadena)
        {
            byte[] encriptado = Encoding.Unicode.GetBytes(pCadena);
            string resultado = Convert.ToBase64String(encriptado);
            return resultado;
        }

        public static string Desencriptar(this string pCadena)
        {
            byte[] desencriptado = Convert.FromBase64String(pCadena);
            string resultado = Encoding.Unicode.GetString(desencriptado);
            return resultado;
        }
    }
}
