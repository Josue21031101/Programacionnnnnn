using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacionnnnnn.Clases
{
    internal class USUARIOS
    {
        private string USU_LOGIN;
        private string USU_PASS;
        private string USU_NOMBRE;

        public USUARIOS(string uSU_LOGIN, string uSU_PASS)
        {
            USU_LOGIN = uSU_LOGIN;
            USU_PASS = uSU_PASS;
        }
        public string CONSULTARI()
        {
            return ("SELECT * FROM TBLUSUARIOS WHERE USU_LOGIN =" +
            this.USU_LOGIN + "'and USU_PASS = dbo.MD5('" + this.USU_PASS + "')");
        }
    }
}