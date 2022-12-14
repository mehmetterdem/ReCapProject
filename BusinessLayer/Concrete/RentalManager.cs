using BusinessLayer.Abstract;
using BusinessLayer.Constant;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rentals)
        {
            var result = _rentalDal.Get(x => x.CarId == rentals.CarId && x.ReturnDate == null);
            if (result==null)
            {
                _rentalDal.Add(rentals);
                return new SuccessResult(Messages.RentalAdd);
            }
            return new ErrorResult(Messages.RentalAddError);
        }

        public IResult Delete(Rental rentals)
        {
            _rentalDal.Delete(rentals);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IResult Update(Rental rentals)
        {
            _rentalDal.Update(rentals);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
