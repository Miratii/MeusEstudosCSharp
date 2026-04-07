using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioPratico
{

    class Program
    {
        public static void Main(string[] args)
        {
            Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
            Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);

            ford.acelerar("Ford");
            chevrolet.acelerar("Chevrolet");

        }
    }

    public class Carro
    {
        public string Modelo;
        public string Montadora;
        public string Marca;
        public int Ano;
        public int Potencia;
        public void  acelerar  (string marca)
        {
            Console.WriteLine($"O carro {marca} está acelerando");
            
            

        }
        

        public Carro(string modelo, string montadora, string marca, int ano, int potencia)
        {
            Modelo = modelo;
            Montadora = montadora;
            Marca = marca;
            Potencia = potencia;


        }

    }
}

