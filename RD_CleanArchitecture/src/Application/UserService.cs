using System.IO.Compression;
using UserDomain;

namespace UserApplication;

class UserService
{
    private User[] UserArr = [
        new User("Ramon", 20, new DateOnly(2005, 12, 09)),
        new User("VivianS", 25, new DateOnly(2000, 05, 04)),
        new User("Jango", 42, new DateOnly(1965, 05, 17)),
        new User("Lucia", 33, new DateOnly(1998, 08, 21))
    ];

    public void UsersData()
    {
        for(int z = 0; z < UserArr.Length; z++)
        {
            Console.WriteLine(z + 1 + " - " + UserArr[z].Name);       
        }

        Console.Write("Select a number to view data: ");
        var SelectNum = Console.ReadLine();

        if(!string.IsNullOrWhiteSpace(SelectNum))
        {
            try
            {
                int AlreadySelectedNum = int.Parse(SelectNum);
                if(AlreadySelectedNum <= UserArr.Length && AlreadySelectedNum != 0)
                {
                    User SelectedUser = UserArr[AlreadySelectedNum - 1];
                    SelectedUser.ViewData();
                }
                else
                {
                    Console.WriteLine("User not found. Please choose a number from the list.");
                }
            } catch(FormatException)
            {
                Console.WriteLine("Error: Format incompatible, write a number.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Error: This number is too big for our system!");
            }
        }
        else
        {
            Console.WriteLine("Warning: Select a number.");
        }
    }
}