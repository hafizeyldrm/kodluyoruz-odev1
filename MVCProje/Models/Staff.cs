using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProje.Models
{
    public class Staff 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public int TCNo { get; set; }
        public static List<Staff> GetSampleData()
        {
            var kisi1 = new Staff
            {
                Id = 1,
                Name = "Hafize",
                Surname = "Yıldırım",
                TCNo = 123

            };
            var kisi2 = new Staff
            {
                Id = 2,
                Name = "A",
                Surname = "Kişisi",
                TCNo = 321

            };
            var kisi3 = new Staff
            {
                Id = 3,
                Name = "B",
                Surname = "Kişisi",
                TCNo = 456

            };
            List<Staff> sampleData = new List<Staff>();
            sampleData.Add(kisi1);
            sampleData.Add(kisi2);
            sampleData.Add(kisi3);
            return sampleData;
        }
    }
    
   
}

