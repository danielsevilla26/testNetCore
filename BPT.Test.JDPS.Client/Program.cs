using BPT.Test.JDPS.Client.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace BPT.Test.JDPS.Client
{
    class Program
    {
        private static readonly string url = "https://localhost:44340/api/";

        private static readonly string studentMethod = "Student";

        static void Main(string[] args)
        {
            ShowMenu();
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("************************************************");
            Console.WriteLine("Menú principal");
            Console.WriteLine("1 - Administrar estudiantes");
            Console.WriteLine("2 - Administrar asignaturas");
            Console.WriteLine("3 - Salir");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                if (option == 1)
                {
                    AdminStudents();
                }

                if (option == 2)
                {

                }

            }
        }

        private static void AdminStudents()
        {
            Console.Clear();
            Console.WriteLine("1 - Agregar un estudiante");
            Console.WriteLine("2 - Actualizar estudiante");
            Console.WriteLine("3 - Eliminar estudiante");
            Console.WriteLine("4 - Obtener todos los estudiantes");
            Console.WriteLine("5 - Regresar al menú");
            
            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        GetStudents();
                        break;
                    case 5:
                        ShowMenu();
                        break;
                }

            }
        }

        private static void CreateStudent()
        {
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento (1992-01-01): ");
            string birthDate = Console.ReadLine();

        }

        private static void GetStudents()
        {
            var result = GetEvent(studentMethod);

            List<Student> students =  JsonConvert.DeserializeObject<List<Student>>(result);
            
            foreach (var student in students)
            {
                Console.WriteLine("Nombre: " + student.Name);
                Console.WriteLine("Fecha de nacimiento: " + student.Birth);
            }
        }

        private static string GetEvent(string method)
        {
            ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
            {
                return true;
            };

            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");

                string fullPath = string.Format("{0}{1}", url, method);

                return client.DownloadString(fullPath);
            }
        }
    }
}
