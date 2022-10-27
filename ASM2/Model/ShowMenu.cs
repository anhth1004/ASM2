using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSchool
{
    class ShowMenu
    {
        public static void Title()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("** Welcom to Management Room Customers System **");
            Console.WriteLine("*********************************************");
        }

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Add Room");
            Console.WriteLine("3. View Customer");
            Console.WriteLine("4. View Room");
            Console.WriteLine("5. UpdateCustomerbyID");
            Console.WriteLine("6. UpdateRoombyID");
            Console.WriteLine("7. DeleteCustomerID");
            Console.WriteLine("8. DeleteRoomID");
            Console.WriteLine("9. SearchCustomerByID");
            Console.WriteLine("10. SearchRoomByID");
            Console.WriteLine("11. Logout");
            Console.WriteLine();
            Console.WriteLine("Please choose your option");

        }
        //public static void MenuForCustomer()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("1. View Room");
        //    Console.WriteLine("2. View Customer");
        //    Console.WriteLine("3. Search Room");
        //    Console.WriteLine("4. Search Customer");
        //    Console.WriteLine("5. Logout");
        //    Console.WriteLine();
        //    Console.WriteLine("Please choose your option");

        //}

        public static int EnterRoomID()
        {
            Console.Write("* Enter Room ID: ");
            return int.Parse(Console.ReadLine());
        }
        public static int EnterPriceRoom()
        {
            Console.Write("* Enter PriceRoom: ");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterTypeRoom()
        {
            Console.Write("* Enter TypeRoom: ");
            return Console.ReadLine();
        }


        public static string TypeExitToFinish()
        {
            Console.WriteLine("Type Exit to Finish Option!!!");
            return Console.ReadLine();
        }
        public static void UpdateSuccessful()
        {
            Console.WriteLine("Update successfully!!!");
        }
        public static void UpdateFail()
        {
            Console.WriteLine("Update Fail!!!");
            Console.WriteLine("Please enter ID Again!!!");
        }
        public static void SearchFail()
        {
            Console.WriteLine("Invalid Result!!!");
            Console.WriteLine("Please enter ID Again!!!");
        }
        public static void SearchNameCustomerFail()
        {
            Console.WriteLine("Invalid Result!!!");
            Console.WriteLine("Please enter Name Again!!!");
        }
        public static void DeleteFail()
        {
            Console.WriteLine("Delete Fail!!!");
            Console.WriteLine("Please enter ID Again!!!");
        }
        public static void AddSuccessful()
        {
            Console.WriteLine("Add Successfully!!!");
        }
        public static void DeleteSuccessful()
        {
            Console.WriteLine("Delete successfully!!!");
        }
        public static int EnterCustomerID()
        {
            Console.Write("* Enter Customer ID: ");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterCustomerCitizen()
        {
            Console.Write("* Enter Citizen Customer: ");
            return Console.ReadLine();
        }
        public static string EnterCustomerName()
        {
            Console.Write("* Enter Customer Name: ");
            return Console.ReadLine();
        }       
        public static int EnterCustomerAge()
        {
            Console.Write("* Enter Customer Age: ");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterCustomerAddress()
        {
            Console.Write("* Enter Customer Address: ");
            return Console.ReadLine();
        }
        public static string EnterCustomerGender()
        {
            Console.Write("* Enter Customer Gender: ");
            return Console.ReadLine();
        }
        public static void IdAlreadyExist()
        {
            Console.WriteLine("Id Already Exist. Please Enter Another ID !!!");
        }
        
    }
}