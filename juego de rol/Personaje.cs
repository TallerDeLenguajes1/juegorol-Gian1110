using System;
using System.Collections.Generic;
using System.Text;

namespace juego_de_rol
{
    public enum tipoPersonaje
    {
        maga,
        enano,
        ogro,
        asesino,
        gordo,
        loco,
        miguelito,
        ckreto,
        lloron,
        mellizo,
        negro
    }
    public class Personaje
    {
        readonly Random random = new Random();

        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;
        private tipoPersonaje tipo;
        private string nombre;
        private string apodo;
        private DateTime FechaNacimiento;
        private int edad;
        private float salud;

        public void MostrarPersonaje()
        {
            Console.WriteLine("\nDatos del jugador:");
            Console.WriteLine($"Nombre: " + Nombre);
            Console.WriteLine($"Apodo: "+ Apodo);
            Console.WriteLine($"Fecha de nacimiento: " + FechaNacimiento);
            Console.WriteLine($"Edad: " + Edad);
            Console.WriteLine($"Tipo: " + Tipo);
            Console.WriteLine("\nCaracteristicas del jugador:");
            Console.WriteLine($"Nivel: " + Nivel);
            Console.WriteLine($"Velocidad: " + Velocidad);
            Console.WriteLine($"Destreza: " + Destreza);
            Console.WriteLine($"Fuerza: " + Fuerza);
            Console.WriteLine($"Armadura: "+ Armadura);
        }

        public void Atacar(Personaje defensor)
        {
            //Valores de Ataque
            float Ataque = Destreza * Fuerza * Nivel;
            float acierto = (float)random.Next(1, 101);
            float ValorAtaque = Ataque * acierto;

            //Valores de Defensa
            float Resistencia = (float)(defensor.Armadura * defensor.Velocidad);
            float DañoMaximo = 50000;

            //Enfrentamiento
            float DañoProvocado = ((ValorAtaque * acierto - Resistencia)/DañoMaximo)*100;

            defensor.Salud -= DañoProvocado;
        }

        public override bool Equals(object obj)
        {
            return obj is Personaje personaje &&
                   EqualityComparer<Random>.Default.Equals(random, personaje.random) &&
                   velocidad == personaje.velocidad &&
                   destreza == personaje.destreza &&
                   fuerza == personaje.fuerza &&
                   nivel == personaje.nivel &&
                   armadura == personaje.armadura &&
                   tipo == personaje.tipo &&
                   nombre == personaje.nombre &&
                   apodo == personaje.apodo &&
                   FechaNacimiento == personaje.FechaNacimiento &&
                   edad == personaje.edad &&
                   salud == personaje.salud &&
                   Velocidad == personaje.Velocidad &&
                   Destreza == personaje.Destreza &&
                   Fuerza == personaje.Fuerza &&
                   Nivel == personaje.Nivel &&
                   Armadura == personaje.Armadura &&
                   Tipo == personaje.Tipo &&
                   Nombre == personaje.Nombre &&
                   Apodo == personaje.Apodo &&
                   FechaNac == personaje.FechaNac &&
                   Edad == personaje.Edad &&
                   Salud == personaje.Salud;
        }

        public int Velocidad { 
            get => velocidad;
            set => velocidad = value; 
        }
        public int Destreza { 
            get => destreza; 
            set => destreza = value; 
        }
        public int Fuerza { 
            get => fuerza; 
            set => fuerza = value; 
        }
        public int Nivel { 
            get => nivel; 
            set => nivel = value; 
        }
        public int Armadura { 
            get => armadura; 
            set => armadura = value; 
        }
        public tipoPersonaje Tipo { 
            get => tipo; 
            set => tipo = value; 
        }
        public string Nombre { 
            get => nombre; 
            set => nombre = value; 
        }
        public string Apodo { 
            get => apodo; 
            set => apodo = value;
        }
        public DateTime FechaNac { 
            get => FechaNacimiento;
            set => FechaNacimiento = value; 
        }
        public int Edad {
            get => edad; 
            set => edad = value; 
        }
        public float Salud
        {
            get => salud;
            set
            {
                salud = value;
                if (salud < 0)
                {
                    Salud = 0;
                }
            }
        }
       
    }
}