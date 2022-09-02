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
        void Add(CarColor car);
        void Delete(CarColor car);
        void Update(CarColor car);
        List<CarColor> GetAll();
    }
}
