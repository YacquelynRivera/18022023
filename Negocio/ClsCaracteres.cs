using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _18022023.Entidades;

namespace _18022023.Negocio
{
    public class ClsCaracteres
    {
        public static int[] PalabrasCaracteres(string frase){
            int palabras = 0;
            int caracterestotales = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ' || frase[i] == '.')
                {
                    palabras++;
                }
            }
            int[] PalabrasCaracteres = new int[2];
            caracterestotales = frase.Length - palabras;
            PalabrasCaracteres[0] = palabras;
            PalabrasCaracteres[1] = caracterestotales ;
            return PalabrasCaracteres;
            }

    }
}