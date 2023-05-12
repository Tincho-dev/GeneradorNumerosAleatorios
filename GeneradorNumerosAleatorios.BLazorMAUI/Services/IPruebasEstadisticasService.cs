using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorNumerosAleatorios.BLazorMAUI.Services
{
    internal interface IPruebasEstadisticasService
    {
        bool Promedios();
        bool Frecuencia();
        bool Serie();
        bool Ks();
        bool CorridaArribaYCorridaMedia();
    }
}
