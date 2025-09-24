using System;

namespace tallerCorte2;
internal class Program
{
    private static void Main(string[] args)
    {
        Persona p = new Persona();
        validar v = new validar();
        Console.WriteLine("¡Bienvenido a la calculadora IMC!");
        System.Console.WriteLine("Ingrese sus datos personales:");
        System.Console.WriteLine("Nombre: ");
        p.nombre = Console.ReadLine();
        p.peso = v.validarDecimal("Peso en kilogramos (use coma): ");
        p.altura = v.validarDecimal("Altura en metros (use coma): ");
        p.edad = v.validarEntero("Edad: ");
        System.Console.WriteLine("Género: ");
        p.genero = Console.ReadLine();
        System.Console.WriteLine("Dirección: ");
        p.direccion = Console.ReadLine();
        System.Console.WriteLine("Teléfono: ");
        p.telefono = Console.ReadLine();
        System.Console.WriteLine("Email: ");
        p.email = Console.ReadLine();

        p.mostrarDatos();
    }
}