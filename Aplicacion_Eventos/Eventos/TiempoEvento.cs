using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion_Eventos.DTO;

namespace Aplicacion_Eventos.Eventos
{
    public class TiempoEvento
    {
        public void TiempoOcurridoEvento()
        {
            LecturaEventos lecturaEventos = new LecturaEventos();
            MesajeEventos mesajeEventos = new MesajeEventos();
            string[] eventos = lecturaEventos.LecturaAchivo(@"C:\BLUE_OCEAN\Capacitacion\AplicacionEventos\Eventos.txt");

            List<EventosDTO> lstEventos = (from evento in eventos
                              select new EventosDTO
                              {
                                  cNombreEvento=evento.Split(',')[0],
                                  dtTiempoEvento= Convert.ToDateTime(evento.Split(',')[1])
                              }
                            ).ToList();

            List<string> lstEventos2 = mesajeEventos.Mensaje(lstEventos);
            foreach (var item in lstEventos2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
