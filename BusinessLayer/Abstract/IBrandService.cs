using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand car);
        IResult Delete(Brand car);
        IResult Update(Brand car);
        IDataResult<List<Brand>> GetAll();
        
    }
}
