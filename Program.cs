// Создать программу записи и чтения строки в файл. Создать для этого три метода,
// один считывает, второй записывает, третий выводит информацию о файле.
// Методы должны получать путь файла в качестве аргумента.
// Запись в файл должна быть осуществлена так, чтобы после каждого
// символа строки вставлялся символ "_". Чтение из файла выводит данные на консоль

using System.Text;
using System.IO;
using System.Text;
using static System.Console;
static void WriteFile(string filePath)
{
    using (FileStream fs = new FileStream(filePath,
FileMode.Create, FileAccess.Write,
FileShare.None))
{
    // получаем данные для записи в файл
    WriteLine("Enter the data to writeto the file: ");
    string writeText = ReadLine();
    // преобразуем строку в массив байт
    byte[] writeBytes = Encoding.Default.
    GetBytes(writeText);
    // записываем данные в файл
    fs.Write(writeBytes, 0, writeBytes.Length);
    WriteLine("Information recorded!");
}
}