using sesion3.modelos;

namespace sesion3
{
    internal class Program
        // calcular la edad de una persona 
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            string nombre;
            DateTime fechaNac;
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento: ");
            fechaNac = DateTime.Parse(Console.ReadLine());
            persona.Nombre = nombre;
            persona.FechaNac =fechaNac;
            Console.WriteLine(persona.EvaluarEdad());

        }
    }
}