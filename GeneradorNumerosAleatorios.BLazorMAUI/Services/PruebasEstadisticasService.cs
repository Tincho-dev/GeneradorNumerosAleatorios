using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorNumerosAleatorios.BLazorMAUI.Services
{
    internal class PruebasEstadisticasService :IPruebasEstadisticasService
    {
        public static bool Promedios(List<double> numeros,double zc) {
            zc = zc > 0 ? double.Parse($"0.{zc}") : zc;
            double promedio = numeros.Sum(x => x)/numeros.Count;
            double estadistico = (promedio-0.5)*Math.Sqrt(numeros.Count)
                /Math.Sqrt(1/12);
            if(Math.Abs(estadistico)<zc)
            {
                return true;
            }
            return false;
        }

        public static bool Frecuencia(List<double> numeros, int cantidadDeIntervalos, double chiCuadrado)
        {
            var limite = 1.0 / cantidadDeIntervalos;
            var limiteRecorrido = limite;
            var frecuenciaEsperada = numeros.Count / cantidadDeIntervalos;
            List<int> frecuenciasObservadas = new List<int>(new int[cantidadDeIntervalos]); // Inicializar la lista con ceros

            int i = 0;
            while (limiteRecorrido < 1)
            {
                foreach (var numero in numeros.ToArray()) // Usamos ToArray para evitar una excepción de modificación concurrente
                {
                    if (numero <= limiteRecorrido)
                    {
                        numeros.Remove(numero);
                        frecuenciasObservadas[i]++;
                    }
                }
                limiteRecorrido += limite;
                i++;
            }

            // Realizar el cálculo del estadístico de chi-cuadrado
            double chiCuadradoCalculado = 0.0;
            foreach (var frecuenciaObservada in frecuenciasObservadas)
            {
                double diferencia = frecuenciaObservada - frecuenciaEsperada;
                chiCuadradoCalculado += (diferencia * diferencia) / frecuenciaEsperada;
            }

            // Comparar el chi-cuadrado calculado con el valor crítico para determinar si pasa la prueba
            return chiCuadradoCalculado <= chiCuadrado;
        }


        public static bool serie(List<double> numeros, int X) {
            var n = numeros.Count();
            //var counter = 0;
            int[,] matriz = new int[X,X];
            InicializacionMatriz(matriz);

			var fe = n / (Math.Pow(X,2)); // Frecuencia Esperada

			foreach (int numero in numeros)
			{
                if (numero>=0.6) { 
                
                }
			}


			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					var sumatoria = Math.Pow((matriz[i, j] - fe),);
				}
			}


			return true;

        }

        public static bool Serie() {
            return true;
        }
        public static bool Ks() { 
            return true;
        }
        public static bool CorridaArribaYCorridaMedia() { 
            return true;
        }



        public static void InicializacionMatriz(int [,] matriz) {
			// Inicializar la matriz con contadores en 0
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					matriz[i, j] = 0;
				}
			}
        }
    }
}
