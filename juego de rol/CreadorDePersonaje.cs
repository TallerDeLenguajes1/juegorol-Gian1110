using System;
using System.Collections.Generic;
using System.Text;

namespace juego_de_rol
{
    public enum NombrePersonaje
    {
        nobru,
        gni,
        gulmi,
        ratata,
        ella,
        judio,
        noc
    }

    public class CreadorDePersonaje
    {
        public List<Personaje> personajes = new List<Personaje>();

        readonly Random random = new Random();

        public Personaje CrearPersonajeAleatorio()
        {
            Personaje nuevoPersonaje = new Personaje
            {
                Salud = 100,
                Nivel = 1,
                Nombre = GeneradorDeNombre(),
                Tipo = GenerarTipoDePersonaje(),
                FechaNac = GenerarFechaNacimiento(),
                Velocidad = random.Next(1,11),
                Destreza = random.Next(1,11),
                Fuerza = random.Next(1, 11),
                Armadura = random.Next(1, 11)

            };
            nuevoPersonaje.Apodo = nuevoPersonaje.Nombre;
            nuevoPersonaje.Edad = CalcularEdad(nuevoPersonaje.FechaNac);

            return nuevoPersonaje;
        }

        string GeneradorDeNombre()
        {
            Array nombrepersonaje = Enum.GetValues(typeof(NombrePersonaje));
            return ((NombrePersonaje)nombrepersonaje.GetValue(random.Next(nombrepersonaje.Length))).ToString();
        }

        DateTime GenerarFechaNacimiento()
        {
            TimeSpan years = new TimeSpan(random.Next(0, 301) * 365, 0, 0, 0);
            return DateTime.Now - years;
        }

        int CalcularEdad(DateTime fecha)
        {
            DateTime diaActual = DateTime.Now;
            return diaActual.Year - fecha.Year;
        }

        tipoPersonaje GenerarTipoDePersonaje()
        {
            Array valuesTipoPje = Enum.GetValues(typeof(tipoPersonaje));
            return (tipoPersonaje)valuesTipoPje.GetValue(random.Next(valuesTipoPje.Length));
        }

    }
}