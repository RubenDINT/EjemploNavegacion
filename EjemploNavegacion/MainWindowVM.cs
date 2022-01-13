using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EjemploNavegacion
{
    class MainWindowVM : ObservableObject
    {
        public RelayCommand AbrirVentanaCommand { get; }
        public RelayCommand AbrirUC1Command { get; }
        public RelayCommand AbrirUC2Command { get; }

        private UserControl opcion;

        public UserControl Opcion
        {
            get { return opcion; }
            set { SetProperty(ref opcion,value); }
        }


        public ServicioNavegacion servicioNavegacion = new ServicioNavegacion();
        public MainWindowVM()
        {
            AbrirVentanaCommand = new RelayCommand(AbrirVentana);
            AbrirUC1Command = new RelayCommand(AbrirUC1);
            AbrirUC2Command = new RelayCommand(AbrirUC2);
            Opcion = servicioNavegacion.AbrirUC1();
        }

        private void AbrirUC2()
        {
            Opcion = servicioNavegacion.AbrirUC2();
        }

        private void AbrirUC1()
        {
            Opcion = servicioNavegacion.AbrirUC1();
        }

        private void AbrirVentana()
        {
            servicioNavegacion.AbrirVentanaHija();
        }
    }
}
