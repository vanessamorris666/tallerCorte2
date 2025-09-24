using System;

namespace tallerCorte2;

public class validar
{
    public float validarDecimal(string texto) //validar que sean 3 opciones
    {
        while (true)
        {
            Console.WriteLine(texto);
            string campo = Console.ReadLine(); //se guarda el valor ingresado
            if (float.TryParse(campo, out float valor)) //si es un número decimal
            {
                if (valor > 0f) //si es mayor a 0
                {
                    return valor; //retorna el valor
                }
                else //si no es mayor a 0
                {
                    Console.WriteLine("El valor debe ser mayor a 0.");
                }
            }
            else //si no es un número
            {
                Console.WriteLine("ERROR!!, debe ingresar un número válido.");
            }

        }
    } 

    public int validarEntero(string texto) //validar que sean 3 opciones
    {
        while (true)
        {
            Console.WriteLine(texto); 
            string campo = Console.ReadLine(); //se guarda el valor ingresado
            if (int.TryParse(campo, out int valor)) //si es un número decimal
            {
                if (valor > 0) //si es mayor a 0
                {
                    return valor; //retorna el valor
                }
                else //si no es mayor a 0
                {
                    Console.WriteLine("El valor debe ser mayor a 0.");
                }
            }
            else //si no es un número
            {
                Console.WriteLine("ERROR!!, debe ingresar un número válido.");
            }
           
        }
    }
}

