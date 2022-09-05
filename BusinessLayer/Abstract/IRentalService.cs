using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rentals);
        IResult Delete(Rental rentals);
        IResult Update(Rental rentals);
        IDataResult<List<Rental>> GetAll();
    }
}
