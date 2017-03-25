using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
   public interface INewMadarsaOperationsRequest
    {
       List<NewMadarsaOperationsRequestModel> NewMadarsaOperationRequestLists ();

       List<MadarsaModel> MadarsaLists ();

        List<RequestSubmitModel> RequestSubmitLists ();

        List<RequestTypeModel> RequestTypeLists ();

        List<UserModel> UserLists ();

        NewMadarsaOperationsRequestModel GetDetails(NewMadarsaOperationsRequestModel model);

        int Save(NewMadarsaOperationsRequestModel model);

        NewMadarsaOperationsRequestModel GetById(int id);

    }
}
