using BusinessLayer.Abstract;
using BusinessLayer.Constant;
using CoreLayer.Utilities.BusinessRules;
using CoreLayer.Utilities.Helpers.FileHelper;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckCarImageLimit(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagePathConstant);
            carImage.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (carImage.ImagePath==null)
            {
                carImage.ImagePath += "DefaultImages.png";
            }
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage carImages)
        {
            _fileHelper.Delete(PathConstants.ImagePathConstant + carImages.ImagePath);
            _carImageDal.Delete(carImages);
            return new SuccessResult(Messages.ImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImagesListed);
        }

        public IDataResult<List<CarImage>> GetByCarId(int id)
        {
            var result = BusinessRules.Run(CheckCarImage(id));
            if (!(result != null))
            {
                return new ErrorDataResult<List<CarImage>>(GetDefaultImage(id).Data);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(x => x.CarId == id));
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(x => x.Id == id));
        }

        public IResult Update(IFormFile file, CarImage carImages)
        {
            carImages.ImagePath = _fileHelper.Update(file, PathConstants.ImagePathConstant + carImages.ImagePath, PathConstants.ImagePathConstant);
            carImages.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _carImageDal.Update(carImages);
            return new SuccessResult(Messages.ImageUpdated);
        }


        private IResult CheckCarImageLimit(int carid)
        {

            var result = _carImageDal.GetAll(x => x.CarId == carid).Count();
            if (result>= 5)
            {
                return new ErrorResult("En fazla 5 adet resim eklenebilir");
            }
            return new SuccessResult();
        }
        private IResult CheckCarImage(int id)
        {
            var result = _carImageDal.GetAll(x => x.CarId == id);
            if (result.Count >= 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        private IDataResult<List<CarImage>> GetDefaultImage(int id)
        {
            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage
            {
              
                CarId = id,
                Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                ImagePath=PathConstants.ImagePathConstant+ "DefaultImages.png"

            });

            return new SuccessDataResult<List<CarImage>>(carImage);
        }

    }
}
