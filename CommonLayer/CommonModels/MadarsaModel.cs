using System;
using System.Collections.Generic;

namespace CommonLayer.CommonModels
{
    public class MadarsaModel
    {

        public int Id { get; set; }

       
        public string Name { get; set; }

      
        public string Location { get; set; }

        public int? HeadUserId { get; set; }

        public string UserName { get; set; }
        public string ZoneName { get; set; }

       
        public string Mobile { get; set; }

        public int? ZoneId { get; set; }

      
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }


        public List<MadarsaModel> MadarsaList { get; set; }

        public List<UserModel> UserList { get; set; }

        public List<ZoneModel> ZoneList { get; set; }
       
    }
}
