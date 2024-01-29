// See https://aka.ms/new-console-template for more information
int[,] myArray = new int[3, 3];
int count = 0;
for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        count += 1;
        Console.Write($"Enter Number {count} : ");
        myArray[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}

double determinant = myArray[0, 0] * (myArray[1, 1] * myArray[2, 2] - myArray[2, 1] * myArray[1, 2])
                        - myArray[0, 1] * (myArray[1, 0] * myArray[2, 2] - myArray[2, 0] * myArray[1, 2])
                        + myArray[0, 2] * (myArray[1, 0] * myArray[2, 1] - myArray[2, 0] * myArray[1, 1]);

Console.WriteLine(determinant);
