using System;

class PracticaEvaluable1 {
	static void Main() {
		int size = 1;
		do {
			try {
				Console.WriteLine("Introduzca un número superior a 2 e impar, que será el tamaño de la X: ");
				size = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException) {
					Console.WriteLine("Debes introducir un número.");
			}
			
		}
		while ((size <= 2) || (size % 2 == 0));
		for (int i = 1; i <= size; i++) {
			for (int j = 1; j <= size; j++) {
					if ((i == j) || (i+j == size+1))
						Console.Write("*");
					else
						Console.Write(" ");
			}
			Console.WriteLine();
		}
		
	}
}
