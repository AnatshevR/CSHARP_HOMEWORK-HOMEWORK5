// Написать программу масштабирования фигуры

// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
//Написать программу копирования массива

void FillArray(int[,] coordinates)
{
    int count = 1;
    int countY = 1;
    int countX = 1;
    for (int i =0; i<coordinates.GetLength(0); i++)
    {
        for (int j = 0; j<coordinates.GetLength(1); j++)
        {
            if (count%2==0)
            {
                Console.WriteLine("enter Y coordinate for " + countY + " point");
                countY++;
            }
            else 
            {
                Console.WriteLine("enter X coordinate for " + countX + " point");
                countX++;
            }
            coordinates [i,j] = int.Parse(Console.ReadLine()!);
            count++;
            
        }
    }
}
void PrintArray(int [,] coordinates)
{
    for (int i = 0; i < coordinates.GetLength(0); i++)
    {
        for (int j = 0; j < coordinates.GetLength(1); j++)
        {
            Console.Write($"{coordinates[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ScaleArray(int [,] coordinates)
{
    Console.WriteLine("enter scale cooficient for example 2,3,4 etc...");
    int k = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < coordinates.GetLength(0);i++)
    {
        for (int j = 0; j< coordinates.GetLength(1); j++)
        {
            coordinates [i,j] = coordinates[i,j] * k;
           
        }
        
    }
}

Console.WriteLine("enter amount of vertexes in your figure");
int VertexNumber = int.Parse(Console.ReadLine()!); 
int [,] coordinates = new int [VertexNumber, 2];
FillArray(coordinates);
PrintArray(coordinates);
ScaleArray(coordinates);
Console.WriteLine();
Console.WriteLine("new coordinates for your points");
PrintArray(coordinates);
