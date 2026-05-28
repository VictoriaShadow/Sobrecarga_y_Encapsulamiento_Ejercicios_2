using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5_sobrecarga_y_encapsulamiento
{
    public class Batería
    {
        private int _porcentajeCarga;
        private int _saludBateria;
        private bool _conectadoCargador;
        private bool _modoAhorroEnergia;

        public int PorcentajeCarga
        {
            get { return _porcentajeCarga; }
            set
            {
                if (value >= 0 && value <= 100)
                    _porcentajeCarga = value;
            }
        }
        public int SaludBateria
        {
            get { return _saludBateria; }
            set
            {
                if (value >= 0 && value <= 100)
                    _saludBateria = value;
            }
        }
        public bool ConectadoCargador
        {
            get { return _conectadoCargador; }
            set
            {
                _conectadoCargador = value;
                if (_conectadoCargador)
                {
                    Console.WriteLine("Esta conectado al cargador");
                }
                else
                {
                    Console.WriteLine("No esta conectado al cargador");
                }
            }

        }
        public bool ModoAhorroEnergia
        {
            get { return _modoAhorroEnergia; }
            set
            {
                if (value)
                {
                    _modoAhorroEnergia = value;
                    Console.WriteLine("El modo ahorro de energía esta activo");
                } else
                {
                    _modoAhorroEnergia = value;
                    Console.WriteLine("El modo ahorro de energía esta inactivo");
                }
            }
        }

        public string Estado_Texto
        {
            get
            {
                string estadoTexto = "";
                if (_conectadoCargador)
                {
                    estadoTexto = $"CARGANDO - BATERIA: {_porcentajeCarga}";
                } else
                {
                    estadoTexto = $"BATERIA: {_porcentajeCarga}";
                }
                return estadoTexto;
            }
        }

        public void AlternarCargador()
        {
            _conectadoCargador = !_conectadoCargador;
        }
        public void ConsumirEnergia(int app)
        {
            if (_porcentajeCarga < 20)
            {
                _modoAhorroEnergia = true;
            } else
            {
                if (_porcentajeCarga > 50)
                {
                    _modoAhorroEnergia = false;
                }
            }
            if (_modoAhorroEnergia)
            {
                app /= 2;
                _porcentajeCarga -= app;
            } else
            {
                    _porcentajeCarga -= app;
            }
            if (_porcentajeCarga < 0)
            {
                _porcentajeCarga = 0;
            }
        }
        public void ConsumirEnergia()
        {
            int consumo = 1;
            if (_porcentajeCarga < 20)
            {
                _modoAhorroEnergia = true;
            }
            else
            {
                if (_porcentajeCarga > 50)
                {
                    _modoAhorroEnergia = false;
                }
            }
            if ( _modoAhorroEnergia)
            {
                consumo = 1;

            }
            _porcentajeCarga -= consumo;
            if (_porcentajeCarga < 0)
            {
                _porcentajeCarga = 0;
            }
        }
        public void CicloDeCarga()
        {
            if (_porcentajeCarga < 20)
            {
                _modoAhorroEnergia = true;
            }
            else
            {
                if (_porcentajeCarga > 50)
                {
                    _modoAhorroEnergia = false;
                }
            }
            if (_conectadoCargador)
            {

                if (_porcentajeCarga < _saludBateria)
                {
                _porcentajeCarga += 1;
                if (_porcentajeCarga == 100)
                {
                    _saludBateria -= 1;
                }
                }
            } else
            {
                Console.WriteLine("No se puede cargar sin estar conectado");
            }
        }
    }
}
