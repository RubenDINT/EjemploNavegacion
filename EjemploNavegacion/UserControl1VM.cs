using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNavegacion
{
    class UserControl1VM : ObservableObject
    {
        private String mensaje;

        public String Mensaje
        {
            get { return mensaje; }
            set { SetProperty(ref mensaje, value); }
        }

        public UserControl1VM()
        {
            Mensaje = "Soy el Control de Usuario 1";
        }

    }
}
