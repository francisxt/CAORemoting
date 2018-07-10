using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************
 *  Aplicaciones Distribuidas   *
 *  Francisco Gualli            *
 *  Gr1                         *
 *  Practica 05                 *
 *  ComponenteSAOSC             *
 /*******************************/
namespace ComponenteSAOSC
{
    public class ComponenteCAO : MarshalByRefObject
    {
        private static int ID = 0;
        private int id;

        public ComponenteCAO()
        {
            id = System.Threading.Interlocked.Increment(ref ID);
            Log.Imprimir("Se creo una instancia del Objeto Remoto ComponenteCAO,id={0}", id);
        }

        public string PrimeraLlamada()
        {
            Log.Imprimir("Se invoco a PrimeraLlamada()");
            return string.Format("ComponenteCAO.id={0}", id);
        }

        public string SegundaLlamada()
        {
            Log.Imprimir("Se invoco a SegundaLlamada()");
            return string.Format("ComponenteCAO.id={0}", id);
        }

    }

}
