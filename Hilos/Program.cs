using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos
{
    class Program
    {
        public void Mostrar1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escribiendo desde ==> 1");
                Thread.Sleep(1000);
            }
        }

        public void Mostrar2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escribiendo desde ==> 2");
                Thread.Sleep(1000);
            }
        }
    }
    public void Mostrar3()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Escribiendo desde ==> 3");
            Thread.Sleep(1000);
        }
    }

    public void Mostrar4()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Escribiendo desde ==> 4");
            Thread.Sleep(1000);
        }
    }

    public void Mostrar5()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Escribiendo desde ==> 5");
            Thread.Sleep(1000);
        }
    }

    public void Mostrar6()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Escribiendo desde ==> 6");
            Thread.Sleep(1000);
        }
    }



    public class Ejemplo
    {

        public static void Main()
        {
            Mensajes msg = new Mensajes();

            Thread th1 = new Thread(new ThreadStart(msg.Mostrar1));
            Thread th2 = new Thread(new ThreadStart(msg.Mostrar2));
            Thread th3 = new Thread(new ThreadStart(msg.Mostrar3));
            Thread th4 = new Thread(new ThreadStart(msg.Mostrar4));
            Thread th5 = new Thread(new ThreadStart(msg.Mostrar5));
            Thread th6 = new Thread(new ThreadStart(msg.Mostrar6));

            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
            th5.Start();
            th6.Start();

            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();
            th5.Join();
            th6.Join();
        }

    }
}