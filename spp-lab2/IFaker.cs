using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2
{
    public interface IFaker
    {
        T Create<T>();
        object Create(Type type);
    }
}
