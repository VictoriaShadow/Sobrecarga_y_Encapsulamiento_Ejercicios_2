using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4_sobrecarga_y_encapsulamiento
{
    public class Invernadero
    {
        private string _nombreSector;
        private int _temperaturaActual;
        private int _humedadSuelo;
        private bool _sistemaRiegoActivo;
        private bool _calefaccionActiva;
        private string _tipoCultivo;

        public Invernadero(string nombreSector, string tipoCultivo, int temperaturaActual, int humedadSuelo)
        {
            NombreSector = nombreSector;
            TipoCultivo = tipoCultivo;
            TemperaturaActual = temperaturaActual;
            HumedadSuelo = humedadSuelo;
            _sistemaRiegoActivo = false;
            _calefaccionActiva = false;
        }

        public string NombreSector
        {
            get { return _nombreSector; }
            set
            {
                if (value != null)
                    _nombreSector = value;
            }
        }
        public int TemperaturaActual
        {
            get { return _temperaturaActual; }
            set
            {
                if (value != 0)
                    _temperaturaActual = value;
            }
        }
        public int HumedadSuelo
        {
            get { return _humedadSuelo; }
            set
            {
                if (value > 1 && value < 100)
                {
                    _humedadSuelo = value;
                }
                
            }

        }
        public bool SistemaDeRiego
        {
            get { return _sistemaRiegoActivo; }
            set
            {
                    _sistemaRiegoActivo = value;
            }
        }
        public bool Calefaccion { 
            get { return _calefaccionActiva; } 
            set 
            { 
                    _calefaccionActiva = value;
            } 
        }
        public string TipoCultivo
        {
            get { return _tipoCultivo; }
            set { 
                if (value.ToUpper() == "TROPICAL" || value.ToUpper() == "DESERTICO")
                {
                    _tipoCultivo = value.ToUpper();
                }
                }
        }

        public string Reporte_Estado
        {
            get
            {
                string reporteEstado = "";
                reporteEstado += "SECTOR: " + _nombreSector.ToUpper();
                reporteEstado += " - " + _tipoCultivo;
                if (_tipoCultivo == "TROPICAL")
                {
                    if (_humedadSuelo < 60)
                    {
                        reporteEstado += " - ALERTA: BAJA HUMEDAD";
                    } else
                    {
                        if (_temperaturaActual < 20 || _temperaturaActual > 28)
                        {
                            reporteEstado += " - ALERTA: TEMPERATURA INADECUADA";
                        }
                    }
                } else
                {
                    if (_tipoCultivo == "DESERTICO")
                    {
                        if (_humedadSuelo > 20)
                        {
                            reporteEstado += " - ALERTA: ALTA HUMEDAD";
                        }
                        else
                        {
                            if (_temperaturaActual < 25 || _temperaturaActual > 35)
                            {
                                reporteEstado += " - ALERTA: TEMPERATURA INADECUADA";
                            }
                        }
                    }
                }
                return reporteEstado;
            }
        }

        public void SimularClima(int humedad, int temperatura)
        {
            if (_humedadSuelo == 100)
            {
                _sistemaRiegoActivo = false;
                _humedadSuelo = humedad;
            } else
            {
                _humedadSuelo = humedad;
            }
            if (_temperaturaActual > 45)
            {
                _calefaccionActiva = false;
                _temperaturaActual = temperatura;
            } else
            {
                _temperaturaActual = temperatura;
            }
        }
        public void SimularClima()
        {
            _humedadSuelo -= 5;
            _temperaturaActual += 1;
        }
        public void ControlAutomatico()
        {
            if (_tipoCultivo == "TROPICAL")
            {
                if (_humedadSuelo < 60)
                {
                    Console.WriteLine("Activando sistema de riego");
                    _sistemaRiegoActivo = true;
                }
                else
                {
                    _sistemaRiegoActivo = false;
                }
                if (_temperaturaActual < 20 || _temperaturaActual > 28)
                {
                    Console.WriteLine("Activando sistema de calefacción");
                    _calefaccionActiva = true;
                } else
                {
                    _calefaccionActiva = false;
                }
            } else
            {
                if (_tipoCultivo == "DESERTICO")
                {
                    if (_humedadSuelo > 20)
                    {
                        Console.WriteLine("Recalibrando sistema de riego");
                        _sistemaRiegoActivo = true;
                    }
                    else
                    {
                        _sistemaRiegoActivo = false;
                    }
                    if (_temperaturaActual < 25 || _temperaturaActual > 35)
                    {
                        Console.WriteLine("Activando sistema de calefacción");
                        _calefaccionActiva = true;
                    } else
                    {
                        _calefaccionActiva = false;
                    }
                }
            }
        }
    }
}