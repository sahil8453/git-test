// only public instances can be initialized through object initializers.

using System;
class abcd
{
	public int a;
	public abcd():this(10)
	{
		a= 10;
	}
	public abcd(int a)
	{
		Console.WriteLine("This is overloaded Contructor:");
	}
	public void display(int a)
	{
		//this(ref a);
		Console.WriteLine("display method:");
	}
	public void display(ref int a)
	{
		Console.WriteLine("display2 method:");
	}
	public void dis()
	{
		Console.WriteLine("A:"+a);
	}
}
class first
{
	static void Main(string[] argc)
	{
		new abcd(){a = 55}.dis();
	}
}
