using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using ComponenteCAO;

       /********************************
       *  Aplicaciones Distribuidas   *
       *  Francisco Gualli            *
       *  Gr1                         *
       *  Practica 05                 *
       *  ServidorCAO                 *
       /*******************************/

//Lance otro ClienteSAO (puede ir a la carpeta Debug, buscar el ejecutable y presionar doble
//clic). Cuál es el resultado?

//Se puede ejecutar multiples clientes simultaneamente.
namespace ServidorCAO
{
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("ServidorCAO.exe.config");
            Utilidades.MostrarTodosLosDatos();
            Log.EsperarParaTerminar("Presione ENTER para detener al servidor...");
        }
    }
}
