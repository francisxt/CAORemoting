using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ComponenteCAO
{
         /********************************
          *  Aplicaciones Distribuidas   *
          *  Francisco Gualli            *
          *  Gr1                         *
          *  Practica 05                 *
          *  ComponenteCAO               *
          /*******************************/
    public class Log
    {
        private Log()
        {
        }
        public static void Imprimir(string texto, params object[] args)
        {
            RealizarLog("", texto, args);
        }
        public static void Informacion(string texto, params object[] args)
        {
            RealizarLog("INFO: ", texto, args);
        }
        public static void Advertencia(string texto, params object[] args)
        {
            RealizarLog("ADVERTENCIA: ", texto, args);
        }
        public static void Error(string texto, params object[] args)
        {
            RealizarLog("!!!ERROR!!! ", texto, args);
        }
        public static void EsperarParaTerminar()
        {
            EsperarParaTerminar("Presione ENTER para terminar...");
        }
        public static void EsperarParaTerminar(string mensaje)
        {
            Console.WriteLine();
            Console.WriteLine();
            RealizarLog("", mensaje);
            Console.ReadLine();
        }
        private static void RealizarLog(string prefijo, string texto, params object[]
        args)
        {
            int idHilo = Thread.CurrentThread.ManagedThreadId;
            Console.Write("[{0:D4}] [{1}] ",
            idHilo,
            DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            Console.Write(prefijo);
            Console.WriteLine(texto, args);
        }

    }
}
