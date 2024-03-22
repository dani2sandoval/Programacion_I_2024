using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                List<string> tareas = new List<string>();

            

                do
                {
                    Console.WriteLine("1. Agregar tarea");
                    Console.WriteLine("2. Editar tarea");
                    Console.WriteLine("3. Eliminar tarea");
                    Console.WriteLine("4. Salir");

                    Console.Write("Seleccione una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Ingrese la nueva tarea: ");
                            string nuevaTarea = Console.ReadLine();
                            tareas.Add(nuevaTarea);
                            Console.WriteLine("Tarea agregada correctamente.");
                            break;

                        case "2":
                            if (tareas.Count == 0)
                            {
                                Console.WriteLine("No hay tareas para editar.");
                                break;
                            }

                            Console.WriteLine("Lista de tareas:");

                            for (int i = 0; i < tareas.Count; i++)
                            {
                                Console.WriteLine(tareas[i]);
                            }

                            Console.Write("Ingrese qué índice de tarea desea editar: ");
                            int tareaIndex = int.Parse(Console.ReadLine()) - 1;
                            if (tareaIndex >= 0 && tareaIndex < tareas.Count)
                            {
                                Console.Write("Ingrese la nueva descripción para la tarea: ");
                                string descripcion = Console.ReadLine();
                                tareas[tareaIndex] = descripcion;
                                Console.WriteLine("Tarea editada correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("No existe esa tarea.");
                            }
                            break;

                        case "3":
                            if (tareas.Count == 0)
                            {
                                Console.WriteLine("No hay tareas para eliminar.");
                                break;
                            }

                            Console.WriteLine("Lista de tareas:");

                            for (int i = 0; i < tareas.Count; i++)
                            {
                                Console.WriteLine(tareas[i]);
                            }

                            Console.Write("Ingrese el índice de la tarea que desea eliminar: ");
                            int eliminarIndex = int.Parse(Console.ReadLine()) - 1;
                            if (eliminarIndex >= 0 && eliminarIndex < tareas.Count)
                            {
                                tareas.RemoveAt(eliminarIndex);
                                Console.WriteLine("Tarea eliminada correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("No existe esa tarea.");
                            }
                            break;

                        case "4":
                            return;

                        default:
                            Console.WriteLine("Seleccione una opción correcta.");
                            break;
                    }
                } while (true);
            }



        }




    }

