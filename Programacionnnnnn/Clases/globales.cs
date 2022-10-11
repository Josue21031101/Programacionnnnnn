using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacionnnnnn.Clases
{
    internal static class globales
    {
        static public string dbn = "Programacionnnnnn";
        static public string server = "LAPTOP-I3VRBKPN";
        static public string password = "*****";
        static public string seguridad = "integrated security=true";
        static public string UserId = "Administrador";
        static public string miconexion = "@DAtaSource = " + server + "Initial Catalog =" +
            dbn + "; Persist Security Info =  True; User ID = Administrador; Password =" + password;

        static public byte nivel = 0;

        static public bool nive = false;


    }
}
