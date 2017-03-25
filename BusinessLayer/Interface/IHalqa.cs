using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IHalqa
    {
        List<HalqaModel> HalqaList();

        HalqaModel GetDetails(HalqaModel model);

        int Save(HalqaModel model);

        HalqaModel GetById(int id);

        //void Delete(HalqaModel entity);
    }
}
