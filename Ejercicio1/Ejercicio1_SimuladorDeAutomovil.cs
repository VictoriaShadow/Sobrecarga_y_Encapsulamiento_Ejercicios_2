using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1_sobrecarga_y_encapsulamiento
{
    public class Automovil
    {
        private string _marca;
        private bool _motorEncendido;
        private int _velocidadActual;
        private bool _cajaAutomatica;
        private bool _modoCrucero;
        public string Marca
        {
            get { return _marca; }
            set
            {
                if (value != null)
                    _marca = value;
            }
        }
        public bool MotorEncendido
        {
            get { return _motorEncendido; }
            set
            {
                _motorEncendido = value;
                if (_motorEncendido)
                {
                    Console.WriteLine("Motor Encendido");
                } else
                {
                    Console.WriteLine("Motor Apagado");
                }
            }
        }
        public int VelocidadActual
        {
            get { return _velocidadActual; }
            set
            {
                if (value >= 0)
                {
                    _velocidadActual = value;
                }
            } }
        public bool CajaAutomatica
        {
            get { return _cajaAutomatica; }
            set {
                _cajaAutomatica = value;
            }
        }
        public bool ModoCrucero
        {
            get { return _modoCrucero; }
            set
            {
                if (_motorEncendido && _velocidadActual > 60)
                {
                    _modoCrucero = value;
                    Console.WriteLine("Ingresando a modo crucero....");
                    Console.WriteLine("Se ha ingresado al modo crucero");
                } else
                {
                    Console.WriteLine("Se debe tener el motor encendido y superar los 60 km/h para entrar al modo crucero");
                }
            }
        }
        public string Identificador {
            get {
                string identificador = "";
                identificador += _marca.Substring(0, 3).ToUpper();
                if (_cajaAutomatica == true)
                {
                    identificador += "-AUTO-";
                }
                else
                {
                    identificador += "-MAN-";
                }
                identificador += DateTime.Now.Year;
                return identificador;
            } 
        }
        public void EncenderApagar()
        {
            _motorEncendido = !_motorEncendido;
            if (!_motorEncendido)
            {
                _velocidadActual = 0;
            }
        }
        public void Acelerar(int km)
        {
            int velocidadMaxima = 0;
            if (_cajaAutomatica)
            {
                velocidadMaxima = 220;
            }
            else
            {
                velocidadMaxima = 180;
            }
            if (_motorEncendido == true)
            {
               _velocidadActual += km;
                if (_velocidadActual > velocidadMaxima)
                {
                    _velocidadActual = velocidadMaxima;
                }
            } else
            {
                Console.WriteLine("No se puede acelerar con el motor apagado");
            }
        }
        public void Acelerar()
        {
            int velocidadMaxima = 0;
            if (_cajaAutomatica)
            {
                velocidadMaxima = 220;
            } else
            {
                velocidadMaxima = 180;
            }
            if (_motorEncendido == true)
            {
                _velocidadActual += 10;
                if (_velocidadActual > velocidadMaxima)
                {
                    _velocidadActual = velocidadMaxima;
                }
            }
            else
            {
                Console.WriteLine("No se puede acelerar con el motor apagado");
            }
        }
        public void Frenar(int km)
        {
            if (_motorEncendido)
            {
            _velocidadActual -= km;
            if (_velocidadActual < 0) {
                _velocidadActual = 0;
                }
                _modoCrucero = false;
            }
            else
            {
                Console.WriteLine("No se puede frenar con el motor apagado");
            }
        }
        public void Frenar()
        {
            if (_motorEncendido == true)
            {
                _velocidadActual = 0;
                _modoCrucero = false;
            }
            else
            {
                Console.WriteLine("No se puede frenar con el motor apagado");
            }
        }
    }
}