namespace NumerosAleatoriosIO.Services
{
    public class GeneradorService
    {
        public List<double> ParteCentralDelCuadrado(int digitosDeseados, int semilla, int totalDeNumerosaGenerar)
        {
            
            List<double> u = new List<double>();
            for (int i = 1;i <= totalDeNumerosaGenerar;i++)
            {
                int x = semilla * semilla;
                semilla = ((x.ToString().Length - digitosDeseados) % 2 == 0)
                            ? NumerosCentrales(digitosDeseados, x)
                            : NumerosCentrales(digitosDeseados, x * 10);
                u.Add(double.Parse("0," + semilla));
            }
            return u;
        }

        private int NumerosCentrales(int numeroDeDigitosDeseados, int cuadradoDeLaSemilla)
        {
            string xstr = cuadradoDeLaSemilla.ToString();
            int digitosDescartados = (xstr.Length - numeroDeDigitosDeseados) / 2;
            xstr = xstr.Remove(0, digitosDescartados);
            xstr = xstr.Remove(xstr.Length - digitosDescartados, digitosDescartados);
            int numerosCentrales = Int32.Parse(xstr);
            return numerosCentrales;
        }

        public List<double> MetodoDeLehmer(int semilla, int kDigitos)
        {
            var some = semilla * kDigitos;

            return null;
        }
    }
}
