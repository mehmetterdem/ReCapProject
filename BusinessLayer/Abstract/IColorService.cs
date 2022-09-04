using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IColorService
    {
        IResult Add(CarColor car);
        IResult Delete(CarColor car);
        IResult Update(CarColor car);
        IDataResult<List<CarColor>> GetAll();
    }
}
