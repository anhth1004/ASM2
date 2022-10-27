using ManagerSchool;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ASM2.Model
{
    public class Customer : User
    {
        List<Room> rooms = new List<Room>();
        public int CustomerID { get; set; }
        public List<Room> Rooms { get => rooms; set => rooms = value; }

        public Customer(int customerID)
        {
            CustomerID = customerID;
        }
        public Customer()
        {

        }
        public override void InputInformation()
        {
            this.Citizen = ShowMenu.EnterCustomerCitizen();
            this.Name = ShowMenu.EnterCustomerName();
            this.Age = ShowMenu.EnterCustomerAge();
            this.Address = ShowMenu.EnterCustomerAddress();
            this.Gender = ShowMenu.EnterCustomerGender();

        }        
    }
    
}
