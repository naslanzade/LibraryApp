
using LibraryApp.Controller;
using Service.Helpers;
using System.Runtime.CompilerServices;


LibraryController librarycontroller = new();

while (true)
{
   ConsoleColor.Blue.WriteConsole("Select one option :");


    ConsoleColor.Cyan.WriteConsole("Library options: 1-Create, 2-Get by Id, 3- Delete");

    SelectOption: string option = Console.ReadLine();

    int selectedOption;

    bool isParseOption = int.TryParse(option, out selectedOption);
    if (isParseOption)
    {

        switch (selectedOption)
        {

            case 1:
                librarycontroller.Create();
                break;
            case 2:
                librarycontroller.GetById();
                break;          
               
            default:
                ConsoleColor.Red.WriteConsole("Select again true option:");
                goto SelectOption;
        }
        
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Select again true option:");
        goto SelectOption;
    }
}
