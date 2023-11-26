using JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.Controller;

namespace JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.App
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitaMedicaController controller = new VisitaMedicaController();
            controller.AplicarEncriptacion();
        }
    }
}
