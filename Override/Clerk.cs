using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Override
{
    internal class Clerk
    {
        private string full_name;
        private string date_of_birth;
        private string phone_number;
        private string email;
        private string position;
        private string position_description;
        private uint salary;
        public Clerk()
        {
            full_name = string.Empty;
            date_of_birth = string.Empty;
            phone_number = string.Empty;
            email = string.Empty;
            position = string.Empty;
            position_description = string.Empty;
            salary = 0;
        }
        public Clerk(string full_name, string date_of_birth, string phone_number, string email, string position, string position_description, uint salary)
        {
            this.full_name = full_name;
            this.date_of_birth = date_of_birth;
            this.phone_number = phone_number;
            this.email = email;
            this.position = position;
            this.position_description = position_description;
            this.salary = salary;
        }

        public void Print() => Console.WriteLine("Full Name - " + full_name + "\nDate of birth - " + date_of_birth + "\nPhone number - " + phone_number + "\nEmail - " + email + "\nPosition - " + position + "\nPosition Description: " + position_description);
        public void Input()
        {
            Console.Write("Enter Full name: ");
            full_name = Console.ReadLine();
            Console.Write("Enter Date of birth: ");
            date_of_birth = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            phone_number = Console.ReadLine();
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            Console.Write("Position: ");
            position = Console.ReadLine();
            Console.Write("Enter Position description: ");
            position_description = Console.ReadLine();
            Console.Write("Enter Salary: ");
            salary = Convert.ToUInt32(Console.ReadLine());
        }
        public string Full_Name
        {
            get { return full_name; }
            set
            {
                full_name = value;
            }
        }
        public string Date_of_birth
        {
            get { return date_of_birth; }
            set { date_of_birth = value; }
        }
        public string Phone_Number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string Position_Description
        {
            get { return position_description; }
            set
            {
                position_description = value;
            }
        }
        public uint Salary
        {
            get { return salary; }
            set
            {
                salary = value;
            }
        }

        public override string ToString()
        {
            return "Full Name - " + full_name + "\nDate of birth - " + date_of_birth + "\nPhone number - " + phone_number + "\nEmail - " + email + "\nPosition - " + position + "\nPosition Description: " + position_description + "\nSalary - " + salary;
        }
        public bool Equals(Clerk op2)
        {
            if(full_name == op2.full_name && date_of_birth == op2.date_of_birth && phone_number == op2.phone_number && email == op2.email && position == op2.position
                && position_description == op2.position_description && salary == op2.salary) {
                return true;
            }
            else
                return false;
            
        }
        public static Clerk operator +(Clerk op1, uint op2)
        {
            op1.salary += op2;
            return op1;
        }
        public static Clerk operator -(Clerk op1, uint op2)
        {
            op1.salary -= op2;
            return op1;
        }
        public static bool operator ==(Clerk op1, Clerk op2)
        {
            return op1.salary == op2.salary;
        }
        public static bool operator !=(Clerk op1, Clerk op2)
        {
            return op1.salary != op2.salary;
        }
        public static bool operator >(Clerk op1, Clerk op2)
        {
            return op1.salary > op2.salary;
        }
        public static bool operator <(Clerk op1, Clerk op2)
        {
            return op1.salary < op2.salary;
        }
    }
}