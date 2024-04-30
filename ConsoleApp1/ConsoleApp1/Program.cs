// See https://aka.ms/new-console-template for more information
int[,] matrix = new int[3, 3];

// Accessing elements
matrix[0, 0] = 1;
matrix[1, 1] = 1;
matrix[2,2] = 1;
// Iterating over elements
for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 3; j++)
	{
		Console.Write($"Enter values for {i} {j} th index ");
		int x = Int32.Parse(Console.ReadLine());
		matrix[i, j] = x;
		
	}
	
}
Console.Write("The Entered Values are: \n");

for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 3; j++)
	{
		Console.Write(matrix[i, j] + " ");
	}
	Console.WriteLine();
}