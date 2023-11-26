using JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.Model.Domain;
using System;

namespace JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.View.Console
{
    public class VisitaMedicaView
    {
        public VisitaMedica GetVisitaMedica()
        {
            VisitaMedica visita = new VisitaMedica();
            System.Console.Write("Introduce el ID de la Visita: ");
            visita.IdVisita = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Introduce el Nombre del Paciente: ");
            visita.NomPaciente = System.Console.ReadLine();

            System.Console.Write("Introduce el Nombre del Médico: ");
            visita.NomMetge = System.Console.ReadLine();

            System.Console.Write("Introduce la Fecha (yyyy-mm-dd): ");
            visita.Fecha = DateTime.Parse(System.Console.ReadLine());

            System.Console.Write("Introduce el Diagnóstico: ");
            visita.Diagnostico = System.Console.ReadLine();

            return visita;
        }

        public void ShowVisitaMedica(VisitaMedica visita)
        {
            System.Console.WriteLine($"ID Visita: {visita.IdVisita}");
            System.Console.WriteLine($"Nombre del Paciente: {visita.NomPaciente}");
            System.Console.WriteLine($"Nombre del Médico: {visita.NomMetge}");
            System.Console.WriteLine($"Fecha: {visita.Fecha.ToString("yyyy-MM-dd")}");
            System.Console.WriteLine($"Diagnóstico: {visita.Diagnostico}");
        }

        public void ShowMessage(string message, bool isError = false)
        {
            if (isError)
            {
                System.Console.Error.WriteLine(message);
            }
            else
            {
                System.Console.WriteLine(message);
            }
        }
    }
}
