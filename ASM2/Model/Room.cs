using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.Generic;
using ManagerSchool;
using System.Drawing;

namespace ASM2.Model
{
    public class Room
    {
        private string roomID;
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        private string typeRoom;
        public string TypeRoom
        {
            get { return typeRoom; }
            set { typeRoom = value; }

        }
        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private Customer customer;
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        
        public Room(string roomID, string typeRoom, float price )
        {
            this.RoomID = roomID;
            TypeRoom = typeRoom;
            Price = price;

        }

        public Room()
        {
        }
        //public void InputInformationRoom()
        //{
        //    this.TypeRoom = ShowMenu.EnterTypeRoom();
        //    this.Price = ShowMenu.EnterPriceRoom();;

        //}

        //public void Input()
        //{

        //    Console.WriteLine("Enter room ID: ");
        //    RoomID = Console.ReadLine();
        //    Console.WriteLine("Enter Type Room");
        //    TypeRoom = Console.ReadLine();
        //    Console.WriteLine("Enter price:");
        //    Price = float.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter Floor:");

        //}
    }
}