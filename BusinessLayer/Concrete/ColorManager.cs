using BusinessLayer.Abstract;
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

        public void Add(CarColor color)
        {
            _colorDal.Add(color);
        }

        public void Delete(CarColor color)
        {
            _colorDal.Delete(color);
        }

        public List<CarColor> GetAll()
        {
            return _colorDal.GetAll();
        }

        public void Update(CarColor color)
        {
            _colorDal.Update(color);
        }
    }
}
