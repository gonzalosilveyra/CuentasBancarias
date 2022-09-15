using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {        
        static void Main(string[] args)
        {
                RepositorioBanca repositorioBanca = new RepositorioBanca();
                Banca cuentaUnificada = new Banca(0,"");
                Cuenta cuentaSing = new Cuenta();
                Cuenta cuentaSingAux = new Cuenta();
                ConsoleKeyInfo tecla;
                const double DOLAR = 300;

                do
                {
                    int dni;
                    double x;
                    Console.Clear();
                    Console.Write("***CUENTAS BANCARIAS***");
                    Console.WriteLine("\n1) INGRESAR\n2) CREAR CUENTA\n3) SALIR");
                    tecla = Console.ReadKey(true);

                    if (tecla.KeyChar == '1')
                    {   
                        Console.Clear();
                        Console.WriteLine("***INGRESAR***");
                        Console.Write("NÚMERO:");
                        dni = Convert.ToInt16(Console.ReadLine());
                        cuentaUnificada = repositorioBanca.Obtener(dni);

                        if (cuentaUnificada != null)
                        {
                            Console.Clear();
                            Console.WriteLine("BIENVENIDO "+cuentaUnificada.Titular);
                            Console.WriteLine("NÚMERO: "+cuentaUnificada.Numero);
                            Console.WriteLine("\n1) CUENTA EN PESOS\n2) CUENTA EN DÓLARES\n3) SALIR");
                            tecla = Console.ReadKey(true);

                            if (tecla.KeyChar == '1')   // SELECCION CUENTA EN PESOS
                            {
                                do
                                {                            
                                    Console.Clear();
                                    Console.WriteLine("---CUENTA EN PESOS---");
                                    Console.WriteLine("\n1) MOSTRAR SALDO\n2) ACREDITAR SALDO \n3) DEBITAR SALDO\n4) TRANSFERIR A CUENTA EN PESOS\n5) REGRESAR");
                                    tecla = Console.ReadKey(true);

                                    if (tecla.KeyChar == '1')          //MOSTRAR SALDO 
                                    {
                                        Console.Clear();
                                        cuentaSing = cuentaUnificada.CuentaEnPesos;
                                        Console.WriteLine("---CUENTA EN PESOS---");
                                        Console.WriteLine("SU SALDO ES DE: "+cuentaSing.Saldo);
                                        Console.ReadKey();
                                    }
                                    else if (tecla.KeyChar == '2')     //ACREDITAR SALDO
                                    {
                                        Console.Clear();
                                        cuentaSing = cuentaUnificada.CuentaEnPesos;
                                        Console.WriteLine("---CUENTA EN PESOS---");
                                        Console.WriteLine("INGRESE CANTIDAD A ACREDITAR: ");
                                        cuentaSing.AcreditarSaldo(Convert.ToDouble(Console.ReadLine()));
                                        Console.Clear();
                                        Console.WriteLine("---CUENTA EN PESOS---");
                                        Console.WriteLine("SE REALIZÓ LA ACREDITACIÓN SATISFACTORIAMENTE");
                                        Console.ReadKey();
                                    }
                                    else if (tecla.KeyChar == '3')     //DEBITAR SALDO
                                    {
                                        Console.Clear();
                                        cuentaSing = cuentaUnificada.CuentaEnPesos;
                                        Console.WriteLine("---CUENTA EN PESOS---");
                                        Console.WriteLine("INGRESE CANTIDAD A DEBITAR: ");
                                        if (cuentaSing.DebitarSaldo(Convert.ToDouble(Console.ReadLine())) == true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("---CUENTA EN PESOS---");
                                            Console.WriteLine("DÉBITO REALIZADO SATISFACTORIAMENTE");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("---CUENTA EN PESOS---");
                                            Console.WriteLine("SALDO INSUFICIENTE");
                                            Console.ReadKey();
                                        }
                                    }
                                else if (tecla.KeyChar == '4')      //TRANSFERIR PESOS A CUENTA EN DOLARES
                                {
                                    Console.Clear();

                                    cuentaSing = cuentaUnificada.CuentaEnPesos;
                                    cuentaSingAux = cuentaUnificada.CuentaEnDolares;
                                    Console.WriteLine("---CUENTA EN PESOS---");
                                    Console.WriteLine("INGRESE CANTIDAD A TRANSFERIR:");
                                    x = Convert.ToDouble(Console.ReadLine());
                                    if (cuentaSing.DebitarSaldo(x) == true)
                                    {
                                        Console.Clear();
                                        cuentaSingAux.AcreditarSaldo(x / DOLAR);
                                        Console.WriteLine("---CUENTA EN PESOS---");
                                        Console.WriteLine("TRANSFERENCIA REALIZADA SATISFACTORIAMENTE");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("---CUENTA EN PESOS---");
                                        Console.WriteLine("SALDO INSUFICIENTE");
                                        Console.ReadKey();
                                    }
                                }
                                else if (tecla.KeyChar > '5')
                                    {                                    
                                            Console.Clear();
                                            Console.Write("¡INGRESE UNA OPCIÓN VÁLIDA!");
                                            Console.ReadKey(true);                                   
                                    }
                                }
                                while (tecla.KeyChar != '4') ;
                            }
                            else if (tecla.KeyChar == '2')          // SELECCION CUENTA EN DOLARES
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("---CUENTA EN DÓLARES---");
                                    Console.WriteLine("\n1) MOSTRAR SALDO\n2) ACREDITAR SALDO \n3) DEBITAR SALDO\n4) TRANSFERIR A CUENTA EN PESOS\n5) REGRESAR");
                                    tecla = Console.ReadKey(true);

                                    if (tecla.KeyChar == '1')          //MOSTRAR SALDO 
                                    {
                                        Console.Clear();
                                        cuentaSing = cuentaUnificada.CuentaEnDolares;
                                        Console.WriteLine("---CUENTA EN DÓLARES---");
                                        Console.WriteLine("SU SALDO ES DE: " + cuentaSing.Saldo);
                                        Console.ReadKey();
                                    }
                                    else if (tecla.KeyChar == '2')     //ACREDITAR SALDO
                                    {
                                        Console.Clear();
                                        cuentaSing = cuentaUnificada.CuentaEnDolares;
                                        Console.WriteLine("---CUENTA EN DÓLARES---");
                                        Console.WriteLine("INGRESE CANTIDAD A ACREDITAR: ");
                                        cuentaSing.AcreditarSaldo(Convert.ToDouble(Console.ReadLine()));
                                        Console.Clear();
                                        Console.WriteLine("---CUENTA EN DÓLARES---");
                                        Console.WriteLine("SE REALIZÓ LA ACREDITACIÓN SATISFACTORIAMENTE");
                                        Console.ReadKey();
                                    }
                                    else if (tecla.KeyChar == '3')     //DEBITAR SALDO
                                    {
                                        Console.Clear();
                                        cuentaSing = cuentaUnificada.CuentaEnDolares;
                                        Console.WriteLine("---CUENTA EN DÓLARES---");
                                        Console.WriteLine("INGRESE CANTIDAD A DEBITAR: ");
                                        if (cuentaSing.DebitarSaldo(Convert.ToDouble(Console.ReadLine())) == true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("---CUENTA EN DÓLARES---");
                                            Console.WriteLine("DÉBITO REALIZADO SATISFACTORIAMENTE");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("---CUENTA EN DÓLARES---");
                                            Console.WriteLine("SALDO INSUFICIENTE");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if(tecla.KeyChar == '4')      //TRANSFERIR DOLARES A CUENTA EN PESOS
                                    {
                                    Console.Clear();

                                    cuentaSing = cuentaUnificada.CuentaEnDolares;
                                    cuentaSingAux = cuentaUnificada.CuentaEnPesos;
                                    Console.WriteLine("---CUENTA EN DÓLARES---");
                                    Console.WriteLine("INGRESE CANTIDAD A TRANSFERIR:");
                                    x = Convert.ToDouble(Console.ReadLine());
                                    if (cuentaSing.DebitarSaldo(x) == true)
                                    {
                                        Console.Clear();
                                        cuentaSingAux.AcreditarSaldo(x*DOLAR);
                                        Console.WriteLine("---CUENTA EN DÓLARES---");
                                        Console.WriteLine("TRANSFERENCIA REALIZADA SATISFACTORIAMENTE");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("---CUENTA EN DÓLARES---");
                                        Console.WriteLine("SALDO INSUFICIENTE");
                                        Console.ReadKey();
                                    }
                                    }

                                else if (tecla.KeyChar > '5')
                                    {
                                        Console.Clear();
                                        Console.Write("¡INGRESE UNA OPCIÓN VÁLIDA!");
                                        Console.ReadKey(true);
                                    }
                                }
                                while (tecla.KeyChar != '5');
                            }
                            else if (tecla.KeyChar == '3')
                            {
                                Console.Clear();
                                Console.WriteLine("¡HASTA LUEGO!");
                            }

                        }
                        else
                        {
                            Console.Write("CUENTA NO ENCONTRADA");
                            Console.ReadKey();
                        }

                    }
                    else if (tecla.KeyChar == '2')      // CREAR CUENTA
                    {
                        Console.Clear();
                        Console.WriteLine("***CREAR CUENTA***");
                        Console.Write("DNI:");
                        dni = Convert.ToInt16(Console.ReadLine());
                        Console.Write("TITULAR:");
                        string tit = Convert.ToString(Console.ReadLine());
                        Banca CuentaUnificada = new Banca(dni, tit);
                        repositorioBanca.Agregar(CuentaUnificada);
                        Console.WriteLine("¡CUENTA CREADA!");
                        Console.ReadKey();
                    }
                    else if (tecla.KeyChar == '3')
                    {
                        Console.Clear();
                        Console.WriteLine("¡HASTA LUEGO!");
                    }

                    else
                    {
                        Console.Clear();
                        Console.Write("¡INGRESE UNA OPCIÓN VÁLIDA!");
                        Console.ReadKey(true);
                    }
                }
                while (tecla.KeyChar != '3');
        }
    }

}