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

        // Constructor
        public Automovil(string marca, bool cajaAutomatica)
        {
            _marca = marca;
            _cajaAutomatica = cajaAutomatica;
            _motorEncendido = false;
            _velocidadActual = 0;
            _modoCrucero = false;
        }

        public string Marca
        {
            get { return _marca; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _marca = value;
                }
            }
        }

        // Propiedad MotorEncendido
        public bool MotorEncendido
        {
            get { return _motorEncendido; }
            set
            {
                _motorEncendido = value;

                if (_motorEncendido)
                {
                    Console.WriteLine("Motor encendido");
                }
                else
                {
                    Console.WriteLine("Motor apagado");
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
            }
        }

        public bool CajaAutomatica
        {
            get { return _cajaAutomatica; }
            set
            {
                _cajaAutomatica = value;
            }
        }

        public bool ModoCrucero
        {
            get { return _modoCrucero; }
            set
            {
                if (_motorEncendido && _velocidadActual >= 60)
                {
                    _modoCrucero = value;
                    Console.WriteLine("Ingresando a modo crucero...");
                    Console.WriteLine("Modo crucero activado");
                }
                else
                {
                    Console.WriteLine("Debe tener el motor encendido y al menos 60 km/h");
                }
            }
        }

        public string Identificador
        {
            get
            {
                string identificador = "";

                if (_marca.Length >= 3)
                {
                    identificador += _marca.Substring(0, 3).ToUpper();
                }
                else
                {
                    identificador += _marca.ToUpper();
                }

                if (_cajaAutomatica)
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

            if (_motorEncendido)
            {
                Console.WriteLine("Motor encendido");
            }
            else
            {
                _velocidadActual = 0;
                _modoCrucero = false;
                Console.WriteLine("Motor apagado");
            }
        }

        public void Acelerar(int km)
        {
            int velocidadMaxima;

            if (_cajaAutomatica)
            {
                velocidadMaxima = 220;
            }
            else
            {
                velocidadMaxima = 180;
            }

            if (_motorEncendido)
            {
                _velocidadActual += km;

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


        public void Acelerar()
        {
            Acelerar(10);
        }

        // Frenar con parámetro
        public void Frenar(int km)
        {
            if (_motorEncendido)
            {
                _velocidadActual -= km;

                if (_velocidadActual < 0)
                {
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
            if (_motorEncendido)
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
