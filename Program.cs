// Создать программу записи и чтения строки в файл. Создать для этого три метода,
// один считывает, второй записывает, третий выводит информацию о файле.
// Методы должны получать путь файла в качестве аргумента.
// Запись в файл должна быть осуществлена так, чтобы после каждого
// символа строки вставлялся символ "_". Чтение из файла выводит данные на консоль

using System.Text;
using System.IO;
using System.Text;
using static System.Console;





WriteLine("Введите имя файла");
string filePath = ReadLine() + ".txt";


newfile(filePath);
readfile(filePath);

void newfile(string filePath) // TODO  метод для создания и записи 
{ 
using (FileStream fs = new FileStream(filePath,FileMode.Create))
{
    using (StreamWriter sw = new StreamWriter(fs,Encoding.Unicode))
    {
// получаем данные для записи в файл
WriteLine("Enter the data to writeto the file: ");
string writeText = ReadLine();
        // записываем данные в файл
        sw.WriteLine(writeText);
        foreach (var item in writeText)
        {
            sw.Write($"{item}_");
        }
        WriteLine("\nData recorded!");
    }
}
}
 // TODO  для чтения )
void readfile(string filePath)
{
    // выделяем массив для считывания данных из файла
    using (FileStream fs = new FileStream(filePath,
 FileMode.Open))
    {
        using (StreamReader sr =
        new StreamReader(fs,
        Encoding.Unicode))
        {
            // выводим результат на консоль
            WriteLine($"Читаем данные из файла:\n");
            WriteLine(sr.ReadToEnd()); // получаем все данные из файла

        }
    }
    Console.WriteLine($"Текст взят из файла: {filePath}");
}