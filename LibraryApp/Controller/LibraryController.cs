using Domain.Entities;
using Service.Helpers;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Controller
{
    public class LibraryController
    {
        private readonly LibraryService _libraryService;

        public LibraryController()
        {
            _libraryService= new LibraryService();
        }


        public void Create()
        {
            try
            {

                ConsoleColor.Yellow.WriteConsole("Add library name:");
                string name = Console.ReadLine();

                ConsoleColor.Yellow.WriteConsole("Add library seat count:");
            SeatCount: string seatCountStr = Console.ReadLine();
                int seatCount;

                bool isParseSeatCount = int.TryParse(seatCountStr, out seatCount);

                if (isParseSeatCount)
                {
                    Library library = new()
                    {
                        Name = name,
                        SeatCount = seatCount,
                    };

                    //library = null;

                    var result = _libraryService.Create(library);
                    ConsoleColor.Green.WriteConsole($"Id:{result.Id},Name:{result.Name},SeatCount:{result.SeatCount}");

                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct seat count");
                    goto SeatCount;
                }

            }
            catch (Exception ex)
            {

                ConsoleColor.Red.WriteConsole(ex.Message);
            }
                

        }

        public void GetById()
        {
            try
            {

                ConsoleColor.Yellow.WriteConsole("Add library Id:");
                Id: string idStr = Console.ReadLine();
                int id;
                bool isParseId=int.TryParse(idStr, out id);
                if (isParseId)
                {
                    var result=_libraryService.GetById(id);
                    if(result is null)
                    {
                        ConsoleColor.Red.WriteConsole("Not Found.Please try again");
                        goto Id;
                    }
                    ConsoleColor.Green.WriteConsole($"Id:{result.Id},Name:{result.Name},SeatCount:{result.SeatCount}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct id");
                    goto Id;
                }


            }
            catch (Exception ex)
            {

                ConsoleColor.Red.WriteConsole(ex.Message);
            }
        }
    }
}
