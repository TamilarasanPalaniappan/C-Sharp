using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class Program
    {
       private static List<BeneficiaryClass> Person = new List<BeneficiaryClass>();
        private static List<VaccinationList> person = new List<VaccinationList>();
        static void Main(string[] args)
        {
            Program person = new Program();
            var firstPerson = new BeneficiaryClass("Tamil", 9488520632, 22, "Namakkal", (Gender)1,(VaccineType) 1);
            var secondPerson = new BeneficiaryClass("Ram", 9488520632, 23, "Chennai", (Gender)2,(VaccineType)1);
            Person.Add(firstPerson);
            Person.Add(secondPerson);
            string opinion = "no";
            do { Console.WriteLine("---------Main menu-----------");
                Console.WriteLine("1.Add beneficiary detils\n2.Vaccination Details\n3.Exit\n------------------------");
                Console.Write("Enter the option: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        person.BeneficiaryRegistration();
                        break;
                    case 2:
                        person.Vaccination();
                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;

                }
                Console.WriteLine("Do you want to continue to Main menu:");
                 opinion = Console.ReadLine();
            } while (opinion=="yes");

             Console.ReadKey();
        }
        public void BeneficiaryRegistration()
        {
            Console.WriteLine("--------Enter your Details------------");
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter your City: ");
            string City = Console.ReadLine();
            Console.Write("Enter your PhoneNumber: ");
            long PhoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter your Age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Gender");
            Console.WriteLine("1.male\n2.Female\n3.others");
            Gender gender = (Gender)int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Vaccine Type:");
            Console.WriteLine("1.Covishiled\n2.Covaxin\n3.Sputnik");
            VaccineType type = (VaccineType)int.Parse(Console.ReadLine());
            
            
            if (Age>18)
            {

                var detail = new BeneficiaryClass(Name,PhoneNumber,Age,City,(Gender)gender, type);
                Person.Add(detail);
                int number = detail.registrationNo;
                Console.WriteLine($"Your Registration ID id {detail.registrationNo}");
            }
        }        
        public void Vaccination()
        {
            int count = 0;
            do
            {
                Console.Write("Enter your Registration Numebr:");
                int Number = int.Parse(Console.ReadLine());
                Program person = new Program();
             
                foreach (var detail in Person)
                {
                    if (Number == detail.registrationNo)
                    {
                        count+=1;
                        Console.WriteLine("----------Menu----------");
                        Console.WriteLine("a.Take Vaccination\nb.Vaccination History\nc.Next Due date\nd.Exit");
                        Console.WriteLine("-------------------------");
                        char option = char.Parse(Console.ReadLine());
                        switch(option)
                        {
                            case 'a':
                                person.TakeVaccination();
                                break;
                            case 'b':                              
                                Console.WriteLine($"{detail.name} has vaccinated on {detail.date}");     
                                break;
                            case 'c':                                
                                Console.WriteLine($"your next due date is {detail.date.AddDays(72)}");
                                break;
                            case 'd':
                                break;
                        }
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Invalid Registration number.Please enter valid one");

                }
            } while (count == 0);
        }
        public void TakeVaccination()
        {
            Console.WriteLine("1.Covishiled\n2.Covaxin\n3.Sputnik");
            Console.Write("Enter your Vaccine Type:");
            VaccineType type = (VaccineType)int.Parse(Console.ReadLine());
            Console.Write("Enter the Dosage:");
            int dosage = int.Parse(Console.ReadLine());
            DateTime date = DateTime.Now;
            var vaccine = new VaccinationList(type, dosage, date);
            person.Add(vaccine);
        }
       
       
     }
           
}
    

    

