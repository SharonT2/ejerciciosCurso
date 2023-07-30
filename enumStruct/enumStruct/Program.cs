using System;

class Structuras
{
    enum Animales { pez, rana, caballo};
    enum Edades { edad1=12, edad2=23};

    public struct Coordenadas
    {
        double ancho;
        double largo;
        //como un cosntructor
        public Coordenadas(double ancho, double largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }
        //métodos para retornar el ancho y largo
        public double getAncho()
        {
            return this.ancho;
        }
        public double getLargo()
        {
            return this.largo;
        }
    }
    static void Main(string[] args)
    {
        //Manejando los enums
        Animales a = Animales.pez;
        Console.WriteLine(Animales.rana);//imprimiendo el valor, o texto
        Console.WriteLine((int)a);//imprimiendo la posición

        Edades e = Edades.edad1;
        Console.WriteLine(Edades.edad1);//imprimiendo el valor, o texto
        Console.WriteLine((int)Edades.edad1);//imprimiendo la posición
        Console.WriteLine(((long)e));


        //Manejando los structs
        Console.WriteLine("--------------------");
        Coordenadas cor = new Coordenadas(29.34,12.3);
        Console.WriteLine(cor.getLargo());
        Console.WriteLine(cor.getAncho());
    }
}