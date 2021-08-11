using System;

namespace bolillero.core
{
    public class Bolillero
    {
        byte cantidad {get; set;}
        byte indiceAzar {get; set;}
        List<byte> Afuera {get; set;}
        List<byte> Adentro {get; set;}
        Random r;
        public Bolillero()
        {
            Afuera = new List<byte>{};
            Adentro = new List<byte>{};
            r = new Random();
        }



    }
}
