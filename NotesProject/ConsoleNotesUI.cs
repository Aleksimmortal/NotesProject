using NotesProject;
using NotesProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



bool isRun = true;

while (isRun) 
{
    Console.WriteLine("Это проект - Заметки, введите одну из следующих цифр:");
    Console.WriteLine("1 - Создать заметку");
    Console.WriteLine("2 - Посмотреть имеющиеся заметки");
    Console.WriteLine("3 - Удалить заметки на указанную дату");
    Console.WriteLine("4 - Очистить консоль");
    Console.WriteLine("5 - Выйти из приложения");

    EnumClass userinput;
    try
    {
        userinput = (EnumClass)Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.Clear();
        continue;
    }

    switch (userinput)
    {
        case EnumClass.Create:
            CreateClass.CreateNote();
            break;
        case EnumClass.View:
            ViewClassUI.ViewNote();
            break;
        case EnumClass.Del:
            DeleteClassUI.DeleteNote();
            break;
        case EnumClass.Clear:
            Console.Clear();
            break;
        case EnumClass.Exit:
            isRun = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Введено неверное значение");
            Console.WriteLine();
            break;
    }
}
