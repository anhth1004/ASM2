using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Drawing;
using ManagerSchool;
using System.Reflection;

namespace ASM2.Model
{
    public class Hotel 
    {
        public List<Customer> Customers = new List<Customer>();
        List<Room> Rooms = new List<Room>();
        private int hotelID;
        public int HotelID { get; set; }
        private string name;
       
        public List<Room> RoomList { get; set; }
        private DateTime CheckIn { get; set; }
        private DateTime CheckOut
        {
            get; set;
        }
        public Hotel(int hotelID)
        {
            this.HotelID = hotelID;
        }
        public Hotel()

        {
            RoomList = new List<Room>();
        }
        public void AddInformationCustomer()
        {
            Customer newCustomer = new Customer();
            newCustomer.CustomerID = ShowMenu.EnterCustomerID();
            newCustomer.InputInformation();
            Customers.Add(newCustomer);

        }
        public void PrintInformationOfCustomer()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" -----------------Customers-List-----------------");
            /*ConsoleTable.From<Customer>(Customers).Write()*/
            ;
            foreach (var Customer in Customers)
            {
                Console.WriteLine("Customer: " + Customer.CustomerID +
                    "Citizen: " + Customer.Citizen + " " + 
                    "Name: " + Customer.Name + " " +
                    "Age: "+ Customer.Age + 
                    "Gender: " + Customer.Gender + 
                    "Address: " + Customer.Address + " " );

            }

            Console.ForegroundColor = ConsoleColor.White;
            
        }
        public Customer GetCustomerByID(int idCustomerToSearch)
        {
            var customerInList = Customers.FirstOrDefault(x => x.CustomerID.Equals(idCustomerToSearch));
            return customerInList;
        }
        public bool SearchCustomerByID(int idCustomerToSearch)
        {
            var customerInList = Customers.FirstOrDefault(n => n.CustomerID.Equals(idCustomerToSearch));
            if (customerInList == null)
            {
                return false;
            }
            return true;
        }
        public bool UpdateCustomerByID(int idCustomerToUpdate,string newCitizen, string newName,int newAge, string newEmail, string newAddress)
        {
            var newCustomer = Customers.FirstOrDefault(n => n.CustomerID.Equals(idCustomerToUpdate));
            newCustomer.Citizen = newCitizen;
            newCustomer.Name = newName;
            newCustomer.Age = newAge;
            newCustomer.Address = newAddress;

            Console.WriteLine("Update successfully");
            return true;
        }
        public bool DeleteCustomerByID(int idCustomerToDelete)
        {
            var customersInList = Customers.FirstOrDefault(n => n.CustomerID.Equals(idCustomerToDelete));
            Customers.Remove(customersInList);
            return true;
        }
        public Customer SearchCustomerObject(int idCustomerToSearch)
        {
            var customerInList = Customers.FirstOrDefault(n => n.CustomerID.Equals(idCustomerToSearch));
            return customerInList;
        }
        public void AddRooms(Room rooms)
        {

            Rooms.Add(rooms);

            //Console.WriteLine("Enter room ID: ");
            //RoomID = Console.ReadLine();
            //Console.WriteLine("Enter Type Room");
            //TypeRoom = Console.ReadLine();
            //Console.WriteLine("Enter price:");
            //Price = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Floor:");
            //Floor = int.Parse(Console.ReadLine());
            //Room newRoom = new Room();
            //newRoom.RoomID = ShowMenu.EnterRoomID();
            //newRoom.InputInformationRoom();
            //Rooms.Add(newRoom);
        }
        public void PrintInformationOfRoom()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" -----------------Point-List-----------------");
            foreach (var room in Rooms)
            {
                Console.WriteLine("RoomID: " + room.RoomID +  
                    "TypeRoom:" + room.TypeRoom + 
                    "Price:" + room.Price);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
        public Room GetRoomByID(int idRoomToSearch)
        {
            var roomInList = Rooms.FirstOrDefault(x => x.RoomID.Equals(idRoomToSearch));
            return roomInList;
        }
        public bool SearchRoomByID(int idRoomToSearch)
        {
            var roomInList = Rooms.FirstOrDefault(n => n.RoomID.Equals(idRoomToSearch));
            if (roomInList == null)
            {
                return false;
            }
            return true;
        }

        public bool UpdateRoomByID(int idRoomToUpdate, string newTypeRoom, float newPrice)
        {
            var newRoom = Rooms.FirstOrDefault(n => n.RoomID.Equals(idRoomToUpdate));
            newRoom.TypeRoom = newTypeRoom;
            newRoom.Price = newPrice;
            Console.WriteLine("Update successfully");
            return true;
        }

    }
}
