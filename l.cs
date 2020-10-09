using System;

public static void imprimirNumAsientos(Coche[] arrayCoches)
{
		foreach (Coche coche in arrayCoches)
		{
			Console.WriteLine(coche.numAsientos());
		}
}

imprimirNumAsientos(arrayCoches);
abstract class Coche
{

	// ...
	abstract int numAsientos();
}
//{
//
//	// ...
//	@@Override int numAsientos()
//	{
//		return 5;
//	}
//}
// ...
