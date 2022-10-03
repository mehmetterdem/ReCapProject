using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file,CarImage carImage);
        IResult Delete(CarImage carImages);
        IResult Update(IFormFile file,CarImage carImages);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetByCarId(int id);
    }
}
