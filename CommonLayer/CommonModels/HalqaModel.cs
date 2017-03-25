using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{

    
    public class HalqaModel
    {
   

        public int Id { get; set; }

        public string Name { get; set; }

        public int? Ameer { get; set; }

        public int? Nayab { get; set; }

        public DateTime? CreatedDate { get; set; }

        public List<HalqaModel> HalqaLists { get; set; }
    }
}
