using JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.Model.Domain;
using JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.Model.Security;
using JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.View.Console;
using System;

namespace JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.Controller
{
    public class VisitaMedicaController
    {
        private VisitaMedicaView visitaMedicaView = new VisitaMedicaView();

        public void AplicarEncriptacion()
        {
            try
            {
                VisitaMedica visita = visitaMedicaView.GetVisitaMedica();

                string nomPacienteMD5 = MD5Security.Encrypt(visita.NomPaciente);
                string diagnosticoMD5 = MD5Security.Encrypt(visita.Diagnostico);

          
                string nomPacienteSHA256 = SHA256Security.Encrypt(visita.NomPaciente);
                string diagnosticoSHA256 = SHA256Security.Encrypt(visita.Diagnostico);

        
                string nomPacienteAESEncrypted = AESSecurity.Encrypt(visita.NomPaciente);
                string diagnosticoAESEncrypted = AESSecurity.Encrypt(visita.Diagnostico);

        
                string nomPacienteAESDecrypted = AESSecurity.Decrypt(nomPacienteAESEncrypted);
                string diagnosticoAESDecrypted = AESSecurity.Decrypt(diagnosticoAESEncrypted);

      
                visitaMedicaView.ShowMessage($"NomPaciente MD5: {nomPacienteMD5}");
                visitaMedicaView.ShowMessage($"Diagnostico MD5: {diagnosticoMD5}");
                visitaMedicaView.ShowMessage($"NomPaciente SHA256: {nomPacienteSHA256}");
                visitaMedicaView.ShowMessage($"Diagnostico SHA256: {diagnosticoSHA256}");
                visitaMedicaView.ShowMessage($"NomPaciente AES Encriptado: {nomPacienteAESEncrypted}");
                visitaMedicaView.ShowMessage($"Diagnostico AES Encriptado: {diagnosticoAESEncrypted}");
                visitaMedicaView.ShowMessage($"NomPaciente AES Desencriptado: {nomPacienteAESDecrypted}");
                visitaMedicaView.ShowMessage($"Diagnostico AES Desencriptado: {diagnosticoAESDecrypted}");
            }
            catch (Exception ex)
            {
                visitaMedicaView.ShowMessage($"Error: {ex.Message}", true);
            }
        }
    }
}
