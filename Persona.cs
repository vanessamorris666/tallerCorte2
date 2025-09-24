using System;

namespace tallerCorte2;

public class Persona
{
    //Crear una clase llamada Persona que contenga como atributos principales: nombre, peso (kg) y altura (m).
    public string nombre { get; set; }
    public float peso { get; set; }
    public float altura { get; set; }
    //Agregar 5 atributos adicionales a la clase Persona: los que el programador desee.
    public int edad { get; set; }
    public string genero { get; set; }
    public string direccion { get; set; }
    public string telefono { get; set; }
    public string email { get; set; }

    //Incluir un constructor para inicializar los atributos. Para inicializar los atributos, los datos deben ser capturados desde la consola.
    public Persona()
    {
        this.nombre = "";
        this.peso = 0.0f;
        this.altura = 0.0f;
        this.edad = 0;
        this.genero = "";
        this.direccion = "";
        this.telefono = "";
        this.email = "";
    }

    //Solo lo voy a usar para mostrar que los datos se guardan correctamente
    public void mostrarDatos()
    {
        System.Console.WriteLine("¡Sus datos personales!");
        System.Console.WriteLine("Nombre: " + nombre + ", Peso: " + peso + " kg, Altura: " + altura + " m");
        System.Console.WriteLine("Edad: " + edad + ", Género: " + genero + ", Dirección: " + direccion);
        System.Console.WriteLine("Teléfono: " + telefono + ", Email: " + email);
    }

    //Implementar un método llamado CalcularIMC() que retorne el valor del IMC (peso / altura2).
    public float CalcularIMC()
    {
        return peso / (altura * altura);
    }
}