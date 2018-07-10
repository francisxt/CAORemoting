using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using ComponenteCAO;
namespace ClienteCAO
{
       /********************************
       *  Aplicaciones Distribuidas   *
       *  Francisco Gualli            *
       *  Gr1                         *
       *  Practica 05                 *
       *  ClienteCAO                  *
       /*******************************/
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("ClienteCAO.exe.config");
            Utilidades.MostrarTodosLosDatos();
            string resultado;
            Log.EsperarParaTerminar("1) Presione ENTER para crear el objeto remoto…");
            ComponenteCAO.ComponenteCAO miComponente = new ComponenteCAO.ComponenteCAO();
            Log.Imprimir("miComponente ha sido creado. Es Proxy? {0}", (RemotingServices.IsTransparentProxy(miComponente) ? "SI" : "NO"));
            Log.EsperarParaTerminar("2) Presione ENTER para usar el primer metodo…");
            resultado = miComponente.PrimeraLlamada();
            Log.Imprimir("miComponente.PrimeraLlamada() retorno: {0}", resultado);
            Log.EsperarParaTerminar("3) Presione ENTER para usar el segundo metodo…");
            resultado = miComponente.SegundaLlamada();
            Log.Imprimir("miComponente.SegundaLlamada() retorno: {0}", resultado);
            Log.EsperarParaTerminar("4) Presione ENTER para crear un nuevo objeto remoto…");
            ComponenteCAO.ComponenteCAO otroComponente = new ComponenteCAO.ComponenteCAO();
            Log.Imprimir("otroComponente ha sido creado. Es Proxy? {0}", (RemotingServices.IsTransparentProxy(otroComponente) ? "SI" : "NO"));
            Log.EsperarParaTerminar("5) Presione ENTER para usar el primer metodo…");
            resultado = otroComponente.PrimeraLlamada();
            Log.Imprimir("otroComponente.PrimeraLlamada() retorno: {0}", resultado);
            Log.EsperarParaTerminar("Presione ENTER para salir...");
        }
    }
}
