using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM.Classes
{
    public class GrupoUser
    {
        public enum GrupoUsuario
        {
            ClasificacionBines = 0,
            AsignacionMP = 1,
            GestionFormulasyOrdenes = 2,
            Ninguna = 3,
            Administradores = 4

        }
        public GrupoUsuario GrupoUsuarioActivo;

        public GrupoUser()
        {
            GrupoUsuarioActivo = GrupoUsuario.Administradores;
        }
    }
}
