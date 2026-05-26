using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3_sobrecarga_y_encapsulamiento
{
    public class Microondas
    {
        private int _potencia;
        private int _tiempoSegundos;
        private bool _puertaAbierta;
        private bool _enFuncionamiento;

        public int Potencia
        {
            get { return _potencia; }
            set
            {
                if (value >= 1 && value <= 10)
                    _potencia = value;
            }
        }
        public int TiempoSegundos
        {
            get { return _tiempoSegundos; }
            set
            {
                if (value >= 0)
                {
                    _tiempoSegundos = value;
                }
                if (_tiempoSegundos > 3600)
                {
                    _tiempoSegundos = 3600;
                }
            }
        }
        public bool PuertaAbierta
        {
            get { return _puertaAbierta; }
            set
            {
                _puertaAbierta = value;
                if (_puertaAbierta)
                {
                    Console.WriteLine("La puerta del microondas esta abierta");
                }
                else
                {
                    Console.WriteLine("La puerta del microondas esta cerrada");
                }
            }

        }
        public bool EnFuncionamiento
        {
            get { return _enFuncionamiento; }
            set
            {
                if (value)
                {
                    _enFuncionamiento = value;
                    Console.WriteLine("El microondas esta en funcionamiento");
                } else
                {
                    _enFuncionamiento = value;
                    Console.WriteLine("El microondas no esta en funcionamiento");
                }
            }
        }

        public string Pantalla_Tiempo
        {
            get
            {
                string pantallaTiempo = "";
                int minutos = _tiempoSegundos / 60;
                int segundos = _tiempoSegundos % 60;
                pantallaTiempo += $"{minutos:D2}:{segundos:D2}";
                return pantallaTiempo;
            }
        }

        public void AgregarTiempo(int segundos)
        {
            _tiempoSegundos += segundos;
            if (_tiempoSegundos > 3600)
            {
                _tiempoSegundos = 3600;
            }
        }
        public void AgregarTiempo()
        {
            _tiempoSegundos += 30;
            if (_tiempoSegundos > 3600)
            {
                _tiempoSegundos = 3600;
            }
        }
        public void Iniciar()
        {
            if (_puertaAbierta == true || _tiempoSegundos == 0)
            {
                Console.WriteLine("No se puede iniciar el microondas si la puerta se encuentra abierta");
            } else
            {
                _enFuncionamiento = true;
            }
        }
        public void Detener()
        {
            if (_enFuncionamiento)
            {
                _enFuncionamiento = !_enFuncionamiento;
            } else
            {
                _tiempoSegundos = 0;
            }
        }
        public void AbrirCerrarPuerta()
        {
            _puertaAbierta = !_puertaAbierta;
            if (_puertaAbierta == true && _enFuncionamiento == true)
            {
                _enFuncionamiento = false;
            }
        }

    }
}