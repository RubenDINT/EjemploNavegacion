using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EjemploNavegacion
{
    class ServicioNavegacion
    {
        public ServicioNavegacion()
        {

        }
        public bool? AbrirVentanaHija()
        {
            VentanaHija nueva = new VentanaHija();
            return nueva.ShowDialog();
        }

        internal UserControl AbrirUC1()
        {
            return new UserControl1();
        }

        internal UserControl AbrirUC2()
        {
            return new UserControl2();
        }
    }
}
