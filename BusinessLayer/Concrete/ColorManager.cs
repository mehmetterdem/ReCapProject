using BusinessLayer.Abstract;
using BusinessLayer.Constant;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ColorManager : IColorService

    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(CarColor color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(CarColor color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<CarColor>> GetAll()
        {
            return new SuccessDataResult<List<CarColor>>(_colorDal.GetAll(), Messages.ProductListed);
        }

        public IResult Update(CarColor color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}

