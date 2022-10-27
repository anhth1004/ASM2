using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2.Model
{
    public abstract class User
    {        
        private string citizen;
        public string Citizen
        {
            get { return citizen; } 
            set { citizen = value; }    
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;

            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; } 
        }

        public User( string citizen, string name, int age, string address)
        {
            this.citizen = citizen;
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public User()
        {
        }
        public abstract void InputInformation();

    }

}
