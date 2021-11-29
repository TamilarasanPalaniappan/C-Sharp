using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
   
    public enum Gender
    {
        male=1,female,others
    }
  
    public class BeneficiaryClass
    {
        private static int autoincrement = 101;
        private static int Covishield = 2;
        private static int Covaxin = 2;
        private static int Sputnik = 2;
        public int registrationNo { get; }
        public string name { get; set; }
        public List<VaccinationList> vaccinelist { get; set; }
        public long phoneNumber { get; set; }
        public int age { get; set; }
        public string city { get; set; }
        public Gender gendr { get; set; }
       
        public DateTime date { get;  }
        public VaccineType type { get; set; }

        private static List<VaccinationList> person = new List<VaccinationList>();
        
        public BeneficiaryClass(string Name, long PhoneNumber, int Age, string City, Gender gender, VaccineType Type)
        {
            this.name = Name;
            this.phoneNumber = PhoneNumber;
            this.age = Age;
            this.city = City;
            this.gendr = gender;
            this.registrationNo = autoincrement;
            this.date = date;
            this.type = Type;
            autoincrement++;
           


        }
      

    }
}
