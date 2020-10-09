internal interface IAve
{
	void comer();
}
internal interface IAveVoladora
{
	void volar();
}

internal interface IAveNadadora
{
	void nadar();
}

internal class Loro : IAve, IAveVoladora
{

	public virtual void volar()
	{
		//...
	}

	public virtual void comer()
	{
		//...
	}
}

internal class Pinguino : IAve, IAveNadadora
{

	public virtual void nadar()
	{
		//...
	}