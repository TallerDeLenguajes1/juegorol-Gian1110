using System;
using System.Collections.Generic;
using System.Linq;

namespace juego_de_rol
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadDeJugadores;
            List<Personaje> jugadores = new List<Personaje>();
            CreadorDePersonaje creadorDePersonaje = new CreadorDePersonaje();
            pelea vs = new pelea();

            do
            {
                Console.WriteLine("\nIngrese el numero de jugadores: ");
                
            } while (!int.TryParse(Console.ReadLine(), out cantidadDeJugadores) || cantidadDeJugadores < 2);

            for (int i = 0; i < cantidadDeJugadores; i++)
            {
                jugadores.Add(creadorDePersonaje.CrearPersonajeAleatorio());
            }

            for (int i = 0; i < cantidadDeJugadores; i++)
            {
                jugadores[i].MostrarPersonaje();
            }

            Personaje aux;
            while (jugadores.Count>1)
            {
                aux = vs.Combate(jugadores[0], jugadores[1]);
                Console.WriteLine("el jugador " + aux.Nombre + " gano");
                if (!aux.Equals(jugadores[0]))
                {
                    jugadores.RemoveAt(0);
                }
                else
                {
                    jugadores.RemoveAt(1);
                }
            }
        }
    }
}