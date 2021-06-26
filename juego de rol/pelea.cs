using System;
using System.Collections.Generic;
using System.Text;

namespace juego_de_rol
{
    class pelea
    {
        public Personaje Combate(Personaje Personaje1, Personaje Personaje2)
        {

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("\n"+ Personaje1.Nombre + " vs " + Personaje2.Nombre);

            while (Personaje1.Salud > 0 && Personaje2.Salud > 0)
            {
                Personaje1.Atacar(Personaje2);
                if (Personaje2.Salud > 0)
                {
                    Personaje2.Atacar(Personaje1);
                }
            }
            if(Personaje1.Salud > 0)
            {
                return Personaje1;
            }
            return Personaje2;
        }

    }
}