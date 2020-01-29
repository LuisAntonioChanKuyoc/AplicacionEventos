using Dominio.EventosUI;
using System;
using System.Collections.Generic;

namespace EventosUI.Eventos
{
    public class VisualizadorEventos : IVisualizadorEventos
    {
        public void VisualizarEventos(List<string> lstEvento)
        {
            foreach (string oEvento in lstEvento)
            {
                Console.WriteLine(oEvento);
            }

            Console.ReadLine();
        }
    }
}
