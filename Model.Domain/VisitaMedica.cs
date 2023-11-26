using System;

namespace JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.Model.Domain
{
    public class VisitaMedica
    {
        public int IdVisita { get; set; }
        public string NomPaciente { get; set; }
        public string NomMetge { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
    }
}
