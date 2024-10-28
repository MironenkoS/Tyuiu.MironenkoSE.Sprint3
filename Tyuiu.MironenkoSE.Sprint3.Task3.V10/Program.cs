using Tyuiu.MironenkoSE.Sprint3.Task3.V10.Lib;
namespace Tyuiu.MironenkoSE.Sprint3.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Мироненко С.Э.                             | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #3                                                               #");
            Console.WriteLine("# Тема: Оператор цикла foreach                                            #");
            Console.WriteLine("# Задание #3                                                              #");
            Console.WriteLine("# Вариант #29                                                             #");
            Console.WriteLine("# Выполнил Мироненко Сергей Эдуардович | АСОиУб-24-1                      #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Используя цикл foreach удалить из строки все буквы p в строке:          #");
            Console.WriteLine("# gdfppf vfppt p                                                          #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            string value = "gdfppf vfppt p";
            char item = 'p';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Удаляемый символ = " + item);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Преобразованная строка = " + ds.DeleteCharInString(value, item));
            Console.ReadKey();
        }
    }
}
