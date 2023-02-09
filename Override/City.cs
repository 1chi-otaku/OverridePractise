using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Override
{
    class City
    {
        private string city_name;
        private string country;
        private string phone_code;
        private string[] areas;
        private uint residents;

        public City()
        {
            city_name = "N/A";
            country = "N/A";
            phone_code = "N/A";
            areas = new string[1] { "N/A" };
            residents = 0;
        }
        public City(string city_name, string country, string phone_code, int areas, uint residents)
        {
            this.city_name = city_name;
            this.country = country;
            this.phone_code = phone_code;
            this.areas = new string[areas];
            this.residents = residents;
        }

        public void Print()
        {
            Console.WriteLine("City Name - " + city_name + "\nCountry - " + country + "\nPhone code - " + phone_code + "\nResidents - " + residents);
            for (int i = 0; i < areas.GetLength(0); i++)
            {
                Console.WriteLine(areas[i]);
            }
        }
        public void Input()
        {
            Console.Write("Enter City name: ");
            city_name = Console.ReadLine();
            Console.Write("Enter Country: ");
            country = Console.ReadLine();
            Console.Write("Enter Phone code: ");
            phone_code = Console.ReadLine();
            for (int i = 0; i < areas.GetLength(0); i++)
            {
                Console.WriteLine("Enter area #" + (i + 1));
                areas[i] = Console.ReadLine();
            }
            Console.Write("Enter Residents amount: ");
            residents = Convert.ToUInt32(Console.ReadLine());

        }
        public string City_Name
        {
            get { return city_name; }
            set
            {
                city_name = value;
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }
        public string Phone_Code
        {
            get { return phone_code; }
            set { phone_code = value; }
        }

        public uint Residents
        {
            get { return residents; }
            set
            {
                residents = value;
            }
        }

        public override string ToString()
        {
            return "City Name - " + City_Name + "\nCountry - " + country + "\nPhone code - " + phone_code + "\nResidents - " + residents;
        }

        public static City operator +(City op1, uint op2)
        {
            op1.residents += op2;
            return op1;
        }
        public static City operator -(City op1, uint op2)
        {
            op1.residents -= op2;
            return op1;
        }
        public static bool operator == (City op1, City op2)
        {
           return op1.residents == op2.residents;
        }
        public static bool operator !=(City op1, City op2)
        {
            return op1.residents != op2.residents;
        }
        public static bool operator >(City op1, City op2)
        {
            return op1.residents > op2.residents;
        }
        public static bool operator <(City op1, City op2)
        {
            return op1.residents < op2.residents;
        }

    }
}