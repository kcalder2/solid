using System;

internal abstract class Coche
{
	// ...
	internal abstract int precioMedioCoche();
}

internal class Renault : Coche
{
	internal override int precioMedioCoche()
	{
		return 18000;
	}
}

internal class Audi : Coche
{
	internal override int precioMedioCoche()
	{
		return 25000;
	}
}

internal class Mercedes : Coche
{
	internal override int precioMedioCoche()
	{
		return 27000;
	}
}

public static void Main(string[] args)
{

	Coche[] arrayCoches = new Coche[]
	{
		new Renault(),
		new Audi(),
		new Mercedes()
	};

	imprimirPrecioMedioCoche(arrayCoches);
}

public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
{
	foreach (Coche coche in arrayCoches)
	{
		Console.WriteLine(coche.precioMedioCoche());
	}
}