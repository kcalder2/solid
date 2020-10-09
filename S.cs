internal class Coche
{
	internal string marca;

	internal Coche(string marca)
	{
		this.marca = marca;
	}

	internal virtual string MarcaCoche
	{
		get
		{
			return marca;
		}
	}
}

internal class CocheDB
{
	internal virtual void guardarCocheDB(Coche coche)
	{
		...
	}
	internal virtual void eliminarCocheDB(Coche coche)
	{
//JAVA TO C# CONVERTER TODO TASK: The following line uses invalid syntax:
//		... }