using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNavegacion
{
    class UserControl2VM : ObservableObject
    {
        private String mensaje;

        public String Mensaje
        {
            get { return mensaje; }
            set { SetProperty(ref mensaje, value); }
        }

        public UserControl2VM()
        {
            Mensaje = "Soy el Control de Usuario 2";
        }
    }
}
