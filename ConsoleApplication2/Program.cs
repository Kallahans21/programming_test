using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)

        {
            TextWriter archivotxt;
            archivotxt = new StreamWriter("archivo.txt");
            Console.Title = "Desafio practico 3";
            Console.WriteLine("¡Bienvenido al inicio de sesión del sistema!. Inicie sesión para continuar: ");
            login();
            Console.Clear();
            cargEmpleados();
            Console.ReadKey();
           
        }
        private static void login()
        {
            int attemps = 0;
            bool isLogin = false;
            string[] user = new string[2];
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.Clear();
                if (attemps == 1 || attemps == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Usuario o contraseña incorrectos. Por favor digitelos nuevamente. \nIntentos restantes (2) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (attemps == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Demasiados intentos de inicio de sesión, el usuario" + user[0] + " se encuentra bloqueado");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine("Bienvenido al programa. Por favor, inicie sesión para continuar...");
                Console.WriteLine("Usuario: ");
                user[0] = Console.ReadLine();
                Console.WriteLine("Contraseña: ");;
                user[1] = Console.ReadLine();
                if (user[0] == "Andrea" && user[1] == "1234")
                {
                    isLogin = true;
                }
                else
                {
                    Console.WriteLine("Los datos son incorrectos");
                }
                attemps += 1;
            } while (!isLogin);
            Console.WriteLine("Inicio sesion correctamente");
            Console.WriteLine(Convert.ToString(attemps));

        }
        private static void cargEmpleados()
        {
            string[] nombre;
            nombre = new string[4];
            double[] hora, salario, cargo, codigo;
            hora = new double[4];
            salario = new double[4];
            cargo = new double[4];
            codigo = new double[4];
            bool hayBono = false;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Por favor, digite el nombre del primer empleado de esta manera: Nombres, Apellidos");
            nombre[1] = Console.ReadLine();
            Console.WriteLine("Digite el código del empleado: ");
            codigo[1] = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de cargo. 1) Gerente, 2) Asistente, 3) Secretaria, 4) Otro");
            cargo[1] = double.Parse(Console.ReadLine());
            if (cargo[1] == 1)
            {
                hayBono = true;
            }
            else
            {
                hayBono = false;
            };
            do
            {
                Console.WriteLine("Ingrese las horas trabajadas del empleado 1");
                hora[1] = Convert.ToDouble(Console.ReadLine());
            } while (hora[1] <= 0);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Por favor, digite el nombre del segundo empleado de esta manera: Nombres, Apellidos");
            nombre[2] = Console.ReadLine();
            Console.WriteLine("Digite el código del empleado: ");
            codigo[2] = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de cargo. 1) Gerente, 2) Asistente, 3) Secretaria, 4) Otro");
            cargo[2] = double.Parse(Console.ReadLine());
            if (cargo[2] == 2)
            {
                hayBono = true;
            }
            else
            {
                hayBono = false;
            };
            do
            {
                Console.WriteLine("Ingrese las horas trabajadas del empleado 2");
                hora[2] = Convert.ToDouble(Console.ReadLine());
            } while (hora[2] <= 0);

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Por favor, digite el nombre del tercer empleado de esta manera: Nombres, Apellidos");
            nombre[3] = Console.ReadLine();
            Console.WriteLine("Digite el código del empleado: ");
            codigo[3] = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de cargo. 1) Gerente, 2) Asistente, 3) Secretaria, 4) Otro");
            cargo[3] = double.Parse(Console.ReadLine());
            if (cargo[3] == 2)
            {
                hayBono = true;
            }
            else
            {
                hayBono = false;
            };
            do
            {
                Console.WriteLine("Ingrese las horas trabajadas del empleado 3");
                hora[3] = Convert.ToDouble(Console.ReadLine());

            } while (hora[3] <= 0);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Resultados finales de empleados: \n ");
    if (hora[1] <= 160) {
        salario[1] = hora[1] * 9.75;
    } else {
      double restantes = hora[1] - 160;
      salario[1] = 160 * 9.75;
      salario[1] = (salario[1]) + restantes * 11.50;
      salario[1] = salario[1] - (salario[1] * 0.2213);
    }
    if (!hayBono) {
      if (cargo[1] == 1) {
          salario[1] = salario[1] + (salario[1] * 0.10);
      } else {
        if (cargo[1] == 2) {
            salario[1] = salario[1] + (salario[1] * 0.05);
        } else {
          if (cargo[1] == 3) {
              salario[1] = salario[1] + (salario[1] * 0.03);
          } else {
              salario[1] = salario[1] + (salario[1] * 0.02);
          }
        }
      }
    }

    if (hora[2] <= 160) {
        salario[2] = hora[2] * 9.75;
    } else {
      double restantes = hora[2] - 160;
      salario[2] = 160 * 9.75;
      salario[2] = (salario[2]) + restantes * 11.50;
      salario[2] = salario[2] - (salario[2] * 0.2213);
    }
    if (!hayBono) {
      if (cargo[2] == 1) {
          salario[2] = salario[2] + (salario[2] * 0.10);
      } else {
        if (cargo[2] == 2) {
            salario[2] = salario[2] + (salario[2] * 0.05);
        } else {
          if (cargo[2] == 3) {
              salario[2] = salario[2] + (salario[2] * 0.03);
          } else {
              salario[2] = salario[2] + (salario[2] * 0.02);
          }
        }
      }
    }

    if (hora[3] <= 160) {
        salario[3] = hora[3] * 9.75;
    } else {
      double restantes = hora[3] - 160;
      salario[3] = 160 * 9.75;
      salario[3] = (salario[3]) + restantes * 11.50;
      salario[3] = salario[3] - (salario[3] * 0.2213);
    }
    if (!hayBono) {
      if (cargo[3] == 1) {
        salario[3] = salario[3] + (salario[3] * 0.10);
      } else {
        if (cargo[3] == 2) {
          salario[3] = salario[3] + (salario[3] * 0.05);
        } else {
          if (cargo[3] == 3) {
            salario[3] = salario[3] + (salario[3] * 0.03);
          } else {
            salario[3] = salario[3] + (salario[3] * 0.02);
          }
        }
      }
    }
            if(salario[1]>salario[2]&&salario[1]>salario[3])
            {
               Console.WriteLine(!hayBono ? "NO HAY BONO" : "");
               Console.WriteLine("\nEl Empleado " + nombre[1] + " / " + codigo[1] + " con " + hora[1] + " horas trabajadas, tiene un descuento total de: 22.13%. \nSu sueldo liquido es de $" + salario[1]);
               Console.WriteLine("\nEl Empleado " + nombre[2] + " / " + codigo[2] + " con " + hora[2] + " horas trabajadas, tiene un descuento total de: 22.13%. \nSu sueldo liquido es de $" + salario[2]);
               Console.WriteLine("\nEl Empleado " + nombre[3] + " / " + codigo[3] + " con " + hora[3] + " horas trabajadas, tiene un descuento total de: 22.13%. \nSu sueldo liquido es de $" + salario[3]);
               Console.WriteLine("\nEl salario mayor es de $" + salario[1]);
            }
            else
            {
                if (salario[2]>salario[1])
                {
                    Console.WriteLine(!hayBono ? "NO HAY BONO" : "");
                    Console.WriteLine("\nEl Empleado " + nombre[1] + " / " + codigo[1] + " con " + hora[1] + " horas trabajadas, tiene un descuento total de: 22.13%. \nSu sueldo liquido es de $" + salario[1]);
                    Console.WriteLine("\nEl Empleado " + nombre[2] + " / " + codigo[2] + " con " + hora[2] + " horas trabajadas, tiene un descuento total de: 22.13%. \nSu sueldo liquido es de $" + salario[2]);
                    Console.WriteLine("\nEl Empleado " + nombre[3] + " / " + codigo[3] + " con " + hora[3] + " horas trabajadas, tiene un descuento total de: 22.13%. \nSu sueldo liquido es de $" + salario[3]);
                    Console.WriteLine("\nEl salario mayor es de $" + salario[2]);
                }
                else
                {
                    Console.WriteLine(!hayBono ? "NO HAY BONO" : "");
                    Console.WriteLine("\nEl Empleado " + nombre[1] + " / " + codigo[1] + " con " + hora[1] + " horas trabajadas, tiene un descuento total de: 22.13%. \nSu sueldo liquido es de $" + salario[1]);
                    Console.WriteLine("\nEl Empleado " + nombre[2] + " / " + codigo[2] + " con " + hora[2] + " horas trabajadas, tiene un descuento total de: 22.13%. \nSu sueldo liquido es de $" + salario[2]);
                    Console.WriteLine("\nEl Empleado " + nombre[3] + " / " + codigo[3] + " con " + hora[3] + " horas trabajadas, tiene un descuento total de: 22.13%. \nSu sueldo liquido es de $" + salario[3]);
                    Console.WriteLine("\nEl salario mayor es de $" + salario[3]);

                    Console.ReadKey();
                }
            }
        }

  }

        }

