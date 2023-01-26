/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();

Console.Clear();
  
void main()
{
   Console.WriteLine("Введите 8 чисел с запятой")
   string n= Console.ReadLine()!;
   translate(slog n);
}

string[] slog(string pal)
{
   string[]stady = new string[8];
   stady =pal.Split(",");  //разделяем запятой строку
   return stady;
}
void translate(string[] stady)
{
   System.Console.WriteLine(String.Join(",", stady));
}
main();
