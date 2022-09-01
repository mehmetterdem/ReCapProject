using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IColorService
    {
        void Add(Color car);
        void Delete(Color car);
        void Update(Color car);
        List<Color> GetAll();
    }
}
