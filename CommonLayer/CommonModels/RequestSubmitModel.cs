﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class RequestSubmitModel
    {
        public int Id { get; set; }


        public string ShortDesc { get; set; }

        public int? RequestTypeId { get; set; }

        public string RequestTypeName { get; set; }

        public string Status { get; set; }

        public int? UserId { get; set; }

        public bool? IsApproved { get; set; }

        public string Comment { get; set; }


        public DateTime? CreatedDate { get; set; }


        public DateTime? UpdateDate { get; set; }

        public List<RequestTypeModel> RequestType { get; set; }


        public List<RequestSubmitModel> RequestSubmitList{ get; set; }



    }
}
