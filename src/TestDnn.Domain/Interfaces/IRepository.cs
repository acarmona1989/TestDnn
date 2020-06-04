using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDnn.Domain.MainContext;

namespace TestDnn.Domain.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
