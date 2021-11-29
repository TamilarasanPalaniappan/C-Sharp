using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public enum VaccineType
    {
        Covishield = 1, Covaxin, Sputnik
    }
    public class VaccinationList
    {
        public  VaccineType type { get; set; }
        public int dosage { get; set; }
        public DateTime date { get; set; }
        public VaccinationList( VaccineType Type, int Dosage , DateTime Date)
        {
            this.type = type;
            this.dosage = Dosage;
            this.date = Date;
           
            
        }
    }
}
