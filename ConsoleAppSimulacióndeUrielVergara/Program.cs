using System;

namespace ConsoleAppSimulacióndeUrielVergara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SimulacionDeUrielVergara";

            int horas;
            int minutos;
            int segundos;

            try
            {
                Console.Write("Ingrese la hora deseada ");
                horas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese los minutos deseados ");
                minutos = int.Parse(Console.ReadLine());
                Console.Write("Ingrese los segundos deseados ");
                segundos = int.Parse(Console.ReadLine());
                Console.Write("Seleccione el indicador deseado (AM) o (PM) ");
                var indicador = Console.ReadLine();

                if (indicador.ToUpper() == "AM" || indicador.ToUpper() == "PM")
                {
                    if (horas >= 0 || horas <= 11)
                    {
                        if (indicador.ToUpper() == "AM")
                        {
                            Console.WriteLine($"La hora seleccionada es {horas} AM");
                            if (minutos <= 60 && minutos >= 0)
                            {
                                Console.WriteLine($"Los minutos ingresados son {minutos}");
                                if (segundos >= 0 && segundos <= 60)
                                {
                                    Console.WriteLine($"Los segundos son {segundos} ");

                                    Console.WriteLine($"La hora es {horas}:{minutos}:{segundos} AM");
                                }
                                else
                                {
                                    Console.WriteLine("Los segundos no son contemplados");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Los minutos ingresados no sirven");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"La hora seleccionada {horas} es PM");
                            if (minutos <= 60 && minutos >= 0)
                            {
                                Console.WriteLine($"Los minutos son {minutos} ");

                                if (segundos <= 60 && segundos >= 0)
                                {
                                    Console.WriteLine($"Los segundos son {segundos}");
                                    horas = horas + 12;
                                    Console.WriteLine($"La hora es {horas}:{minutos}:{segundos} PM");
                                }
                                else
                                {
                                    Console.WriteLine("Los segundos no son comtemplados");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Los minutos ingresados no sirven");
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine("El indicador seleccionado es errone...");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Los datos ingresados son erroneos -_-");
            }

            Console.ReadLine();

        }
    }
}
