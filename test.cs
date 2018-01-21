using System;
					
public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		decimal sum=0;
	for(int i=0; i<n; i++)
	{
		decimal number1 = decimal.Parse(Console.ReadLine());
		sum=sum+number1;
	}	
		Console.WriteLine(sum);
	}
}
