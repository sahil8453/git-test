using System;
class abcd
{
	int a;
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
}
class first
{
	static void Main(string[] argc)
	{
		var x = "MS";
		float y = 20.223f;
		int i = 10;
		Console.WriteLine("x:"+x+"\ty:"+y);
		Console.WriteLine("{0,5} Jaatre {1:#.##}",x,y);
		Console.WriteLine("Multiply:"+(i<<3));
		abcd a = new abcd();
		a.display(10);
		int b = 20;
		a.display(ref b);
	}
}
