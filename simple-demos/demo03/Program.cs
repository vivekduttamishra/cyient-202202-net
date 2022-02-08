class FactorialApp
{	
	static void Main()
	{
		int n=5;

		int fn= Math.Factorial(n);		

		System.Console.WriteLine("Factorial of {0} is {1}",n, fn);

	}
}

class Math
{

	internal static int Factorial( int x )
	{
		int fx=1;
		while(x>1)
		{
			fx*=x--;
		}
		return fx;
	}
}