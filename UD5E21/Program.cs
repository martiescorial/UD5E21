using System;

namespace UD5E21
{
    class Program
    {
        static void Main(string[] args)
        {
			
			string texto = "Introduce un tamaño";
			int[] tam= new int[Convert.ToInt32(texto)];

			int ultimoDigito;
			do
			{
				texto = "Introduce numero entre 0 y 9";
				ultimoDigito = Convert.ToInt32(texto);
			} while (!(ultimoDigito >= 0 && ultimoDigito <= 9));

			
			fillNumAleatorio(tam, 1, 300);

			
			int[] DigFinal = numDigFinal(tam, ultimoDigito);

			
			showDigFinal(DigFinal);

		}
		public static void fillNumAleatorio(int[] array, int a, int b)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Random aleatorio = new Random();
				array[i] = (aleatorio.Next() * (a - b) + b);
			}
		}

		public static void showDigFinal(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
			
				if (array[i] != 0)
				{
					Console.WriteLine("El numero " + array[i] + " acaba en el numero deseado");
				}
			}
		}

		public static int[] numDigFinal(int[] tam, int ultimo_numero)
		{

			
			int[] DigFinal = new int[tam.Length];

			int numeroFinal = 0;

			for (int i = 0; i < DigFinal.Length; i++)
			{

				
				numeroFinal = tam[i] - (tam[i] / 10 * 10);

				
				if (numeroFinal == ultimo_numero)
				{
					DigFinal[i] = tam[i];
				}
			}

			return DigFinal;

		}
	}
}
