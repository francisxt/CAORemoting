using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace ComponenteCAO
{
       /********************************
       *  Aplicaciones Distribuidas   *
       *  Francisco Gualli            *
       *  Gr1                         *
       *  Practica 05                 *
       *  ComponenteCAO               *
       /*******************************/
    public class Utilidades
    {
        private static void MostrarTipoDeDatos(Array arregloDatos)
        {
            foreach (object obj in arregloDatos)
            {
                Log.Imprimir(" {0}: {1}", obj.GetType().Name, obj);
            }
        }
        public static void MostrarTodosLosDatos()
        {
            Log.Imprimir("TIPOS DE DATOS REGISTRADOS EN REMOTING -(INICIO)- ---------");
            MostrarTipoDeDatos(RemotingConfiguration.GetRegisteredActivatedClientTypes());
            MostrarTipoDeDatos(RemotingConfiguration.GetRegisteredActivatedServiceTypes());
            MostrarTipoDeDatos(RemotingConfiguration.GetRegisteredWellKnownClientTypes());
            MostrarTipoDeDatos(RemotingConfiguration.GetRegisteredWellKnownServiceTypes());
            Log.Imprimir("TIPOS DE DATOS REGISTRADOS EN REMOTING -(FIN)- ---------");
        }
    }
}
