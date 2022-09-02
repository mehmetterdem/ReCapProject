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
        void Add(Brand car);
        void Delete(Brand car);
        void Update(Brand car);
        List<Brand> GetAll();
        
    }
}
