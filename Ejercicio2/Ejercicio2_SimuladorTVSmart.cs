using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2_sobrecarga_y_encapsulamiento
{
    public class SmartTV
    {
        private string _marca;
        private int _pulgadas;
        private bool _encendido;
        private int _canalActual;
        private int _volumen;
        private bool _esPremium;

        public SmartTV(string marca, int pulgadas, bool esPremium)
        {
            _marca = marca;
            _pulgadas = pulgadas;
            _esPremium = esPremium;
            _encendido = false;
            _canalActual = 1;
            _volumen = 20;
        } 

        public string Marca
        {
            get { return _marca; }
            set
            {
                if (value != null)
                    _marca = value;
            }
        }
        public int Pulgadas
        {
            get { return _pulgadas; }
            set
            {
                if (value != 0)
                    _pulgadas = value;
            }
        }
        public bool Encendido
        {
            get { return _encendido; }
            set
            {
                _encendido = value;
                if (_encendido)
                {
                    Console.WriteLine("Smart TV encendida");
                }
                else
                {
                    Console.WriteLine("Smart TV apagada");
                }
            }

        }
        public int CanalActual
        {
            get { return _canalActual; }
            set
            {
                if (value >= 1)
                    _canalActual = value;
            }
        }
        public int Volumen
        {
            get { return _volumen; }
            set
            {
                if (value < 100)
                {
                    _volumen = value;
                }
            }
        }
        public bool EsPremium
        {
            get { return _esPremium; }
            set { _esPremium = value; }
        }

        public string CodigoConfig
        {
            get
            {
                string codigoConfig = "";
                codigoConfig += _marca.ToUpper();
                codigoConfig += "-" + _pulgadas + "-";
                if (_esPremium)
                {
                    codigoConfig += "PREM";
                }
                else
                {
                    codigoConfig += "STD";
                }
                return codigoConfig;
            }
        }

        public void Power()
        {
            _encendido = !_encendido;
        }
        public void CambiarCanal(int canal)
        {
            int max = 0;
            if (_esPremium)
            {
                max = 500;
            }
            else
            {
                max = 100;
            }
            if (_encendido)
            {
                _canalActual = canal;

                if (_canalActual > max)
                {
                    _canalActual = 1;
                }
            }
            else
            {
                Console.WriteLine("Se requiere que la TV este encendida");
            }
        }
        public void CambiarCanal()
        {
            int max = 0;
            if (_esPremium)
            {
                max = 500;
            }
            else
            {
                max = 100;
            }
            if (_encendido)
            {
                _canalActual += 1;
                if (_canalActual > max)
                {
                    _canalActual = 1;
                }
            }
            else
            {
                Console.WriteLine("Se requiere que la TV este encendida");
            }
        }
        public void RegularVolumen(bool volumen)
        {
            if (_encendido)
            {
                if (volumen)
                {
                    _volumen += 2;
                }
                else
                {
                    _volumen -= 2;
                }
                if (_volumen > 100)
                {
                    _volumen = 100;
                }
                else
                {
                    if (_volumen <= 0)
                    {
                        _volumen = 0;
                        Console.WriteLine("MUTE");
                    }
                }
            }
            else
            {
                Console.WriteLine("Se requiere que la TV este encendida");
            }
        }

    }
}