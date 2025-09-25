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

    //Agregar un método que clasifique el resultado de acuerdo con los rangos de la OMS, mostrando tanto la composición corporal como el riesgo asociado
    public void ClasificarIMC()
    {
        float imc = CalcularIMC();
        if (imc < 18.5)
        {
            System.Console.WriteLine("Composición corporal: Bajo peso");
            System.Console.WriteLine("Riesgo asociado: Riesgo de deficiencias nutricionales, anemia y osteoporosis.");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            System.Console.WriteLine("Composición corporal: Normal");
            System.Console.WriteLine("Riesgo asociado: Riesgo bajo; estado saludable.");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            System.Console.WriteLine("Composición corporal: Sobrepeso");
            System.Console.WriteLine("Riesgo asociado: Riesgo aumentado de enfermedades cardiovasculares, hipertensión y diabetes.");
        }
        else if (imc >= 30 && imc <= 34.9)
        {
            System.Console.WriteLine("Composición corporal: Obesidad Tipo I (moderada)");
            System.Console.WriteLine("Riesgo asociado: Riesgo alto de diabetes tipo 2, hipertensión y problemas cardiovasculares.");
        }
        else if (imc >= 35 && imc <= 39.9)
        {
            System.Console.WriteLine("Composición corporal: Obesidad Tipo II (severa)");
            System.Console.WriteLine("Riesgo asociado: Riesgo muy alto de complicaciones graves: infartos, apnea del sueño, artrosis.");
        }
        else
        {
            System.Console.WriteLine("Composición corporal: Obesidad Tipo III (mórbida)");
            System.Console.WriteLine("Riesgo asociado: Riesgo extremadamente alto: enfermedades cardiovasculares, metabólicas y mayor mortalidad.");
        }
    }
}