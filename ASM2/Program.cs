using ASM2.Model;
using ManagerSchool;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace ASM2;

class Program

{
    private static Hotel hotel = new Hotel();
    private static Customer customer = new Customer();

    private static char isEndApp;
    static void Main(string[] args)
    {
        ShowMenu.Menu();
        int choose;
        do
        {              
                choose = int.Parse(Console.ReadLine());
            
                switch (choose)
                {
                    case 1:
                    /*InputHotel(hotels);*/
                    hotel.AddInformationCustomer();
                    ShowMenu.Menu();
                    break;
                    case 2:
                    /*DisplayHotel(hotels);*/
                    // Add Point
                    try
                    {
                        // Not genarate ID
                        Console.WriteLine("Enter Room ID: ");
                        int roomID = int.Parse(Console.ReadLine());

                        // Enter student ID
                        //Customer newCustomer = new Customer();
                        //newCustomer.CustomerID = ShowMenu.EnterCustomerID();

                        //while (!hotel.SearchCustomerByID(newCustomer.CustomerID))
                        //{
                        //    Console.ForegroundColor = ConsoleColor.Red;
                        //    Console.WriteLine("Customer ID not Exist. Please Enter Customer ID again");
                        //    Console.ForegroundColor = ConsoleColor.White;
                        //    newCustomer.CustomerID = ShowMenu.EnterCustomerID();
                        //}

                        //Customer customerObject = hotel.SearchCustomerObject(newCustomer.CustomerID);


                        // Enter the rest of info
                        Console.WriteLine("Enter TypeRoom: ");
                        string RoomID = Console.ReadLine();
                        Console.WriteLine("Enter TypeRoom: ");
                        string TypeRoom = (Console.ReadLine());
                        Console.WriteLine("Enter price: ");
                        float Price = float.Parse(Console.ReadLine());
                        Room newRoom = new Room(RoomID, TypeRoom, Price);


                        // Add new point to point list in student 
                        hotel.RoomList.Add(newRoom);
                        ShowMenu.AddSuccessful();
                        ShowMenu.Menu();

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Please enter the number\n" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error " + ex.Message);
                    }
                    break;
                    case 3:
                    /*Booking(customers, hotels, books);*/
                    // View Student
                    hotel.PrintInformationOfCustomer();
                    ShowMenu.Menu();
                    break;
                case 4:
                    hotel.PrintInformationOfRoom();
                    ShowMenu.Menu();
                    break;
                case 5:
                    //Update Student
                    try
                    {
                        int idCustomerToUpdate = ShowMenu.EnterCustomerID();

                        while (!hotel.SearchCustomerByID(idCustomerToUpdate))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            ShowMenu.UpdateFail();
                            Console.ForegroundColor = ConsoleColor.White;
                            idCustomerToUpdate = ShowMenu.EnterCustomerID();
                        }
                        string NewCitizen = ShowMenu.EnterCustomerCitizen();
                        string NewName = ShowMenu.EnterCustomerName();
                        int NewAge = ShowMenu.EnterCustomerAge();
                        string NewAddress = ShowMenu.EnterCustomerAddress();
                        string NewGender = ShowMenu.EnterCustomerGender();

                        hotel.UpdateCustomerByID(idCustomerToUpdate, NewCitizen, NewName, NewAge, NewAddress, NewGender);
                        Console.ForegroundColor = ConsoleColor.Green;
                        ShowMenu.UpdateSuccessful();
                        Console.ForegroundColor = ConsoleColor.White;
                        ShowMenu.Menu();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Please enter the number\n" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error " + ex.Message);
                    }
                    break;
                case 6:
                    // Update Point
                    try
                    {
                        int idRoomToUpdate = ShowMenu.EnterRoomID();
                        while (!hotel.SearchRoomByID(idRoomToUpdate))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            ShowMenu.UpdateFail();
                            Console.ForegroundColor = ConsoleColor.White;
                            idRoomToUpdate = ShowMenu.EnterRoomID();
                        }
                        string TypeRoom = ShowMenu.EnterTypeRoom();
                        float Price = ShowMenu.EnterPriceRoom();
                       hotel.UpdateRoomByID(idRoomToUpdate, TypeRoom, Price);
                        Console.ForegroundColor = ConsoleColor.Green;
                        ShowMenu.UpdateSuccessful();
                        Console.ForegroundColor = ConsoleColor.White;
                        ShowMenu.Menu();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Please enter the number\n" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error " + ex.Message);
                    }
                    break;

                default:
                        Console.WriteLine("ENter Wrong");
                        break;
                }

            } while (choose != 15);
        }
        

      
}