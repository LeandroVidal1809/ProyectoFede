using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("┌───────────────────────────────────┐");
            Console.WriteLine("│BIENVENIDOS A LA APLICACION DE FEDE│");
            Console.WriteLine("└───────────────────────────────────┘");
            List<Persona> listaPersonas = new List<Persona>();
            Persona persona = new Persona();
            bool deseaContinuar = true;
            while(true)
            {
                string opcion = GenerarMenuDeOpciones();
                if (opcion.ToUpper() == "A")
                {
                    deseaContinuar = true;
                    while (deseaContinuar == true)
                    {

                        Persona persona_nueva = CargarNuevaPersona();
                        listaPersonas.Add(persona_nueva);
                        deseaContinuar = DebeContinuarCargando();
                    }
                }
                if (opcion.ToUpper() == "B")
                {
                    GenerarInformePersonas(listaPersonas);
                }
                if (opcion.ToUpper() == "C")
                {
                    Environment.Exit(0);
                }
            }
        }
      
        private static bool DebeContinuarCargando()
        {
            Console.Write("Desea continuar? (s/n): ");
            string datoContinuar = Console.ReadLine();
            if (datoContinuar == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Persona CargarNuevaPersona()
        {
            Console.Clear();
            Persona persona_aux = new Persona();
            persona_aux.Nombre = PedirDatoAlUsuario("Ingrese el nombre de la persona: ");
            persona_aux.Apellido = PedirDatoAlUsuario("Ingrese Apellido de la persona: ");
            persona_aux.Edad = Int32.Parse(PedirDatoAlUsuario("Ingrese edad de la persona: "));
            persona_aux.Peso = Int32.Parse(PedirDatoAlUsuario("Ingrese peso de la persona: "));

            string doc = PedirDatoAlUsuario("Ingrese documento de la persona: ");
            doc = doc.Replace(".", string.Empty);
            persona_aux.Documento = Double.Parse(doc);

            string alturaAux = PedirDatoAlUsuario("Ingrese Altura de la persona: ");
            alturaAux = alturaAux.Replace(".", string.Empty);
            persona_aux.Altura = Double.Parse(alturaAux);
            return persona_aux;
        }

        public static string PedirDatoAlUsuario(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

        public static void GenerarInformePersonas(List<Persona> listaPersonas)
        {
            double promedio = 0;
            bool esPrimerPersona = true;
            int edadMasJoven = 0;
            string nombreMasJoven = "";
            Console.WriteLine("------------------------");
            Console.WriteLine("INFORME DE LAS PERSONAS");
            foreach (var persona_aux in listaPersonas)
            {
                Console.WriteLine($"El Nombre de la persona es: {persona_aux.Nombre}");
                Console.WriteLine($"La edad de la persona  es: {persona_aux.Edad}");
                Console.WriteLine($"El apellido de la persona es: {persona_aux.Apellido}");
                Console.WriteLine($"El documento de la persona es: {persona_aux.Documento}");

                Console.WriteLine($"El peso de la persona es; {persona_aux.Peso}");
                //Console.WriteLine($"La fecha de nacimiento de la persona  es: {persona.FechaNacimiento.Date}");
                Console.WriteLine($"La altura de la persona  es: {persona_aux.Altura}");
                Console.WriteLine($"El nombre completo es: {persona_aux.TraerNombreCompleto()}");
                Console.WriteLine("---------------------------------------------------");
                promedio += persona_aux.Edad;
                if (esPrimerPersona || persona_aux.Edad < edadMasJoven)
                {
                    esPrimerPersona = false;
                    edadMasJoven = persona_aux.Edad;
                    nombreMasJoven = persona_aux.Nombre;
                }
            }
            if (listaPersonas.Count > 0)
            {
                promedio = promedio / listaPersonas.Count;
            }
            Console.WriteLine($"El promedio de edad de estas personas es de: {promedio}");
            Console.WriteLine($"La persona mas joven es: {nombreMasJoven}");
            Console.WriteLine($"----------------------------------------------");



        }

        public static string GenerarMenuDeOpciones()
        {
            Console.WriteLine("Por favor, Elija una opcion");
            Console.WriteLine("A: Agregar Nuevo Usuario a la lista");
            Console.WriteLine("B: Mostrar Informe De Usuarios");
            Console.WriteLine("C: Salir Del Programa");
            return Console.ReadLine();
            
        } 
          
    }
}
