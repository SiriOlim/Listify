using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProj.Domain;

namespace TestProj.ServiceInterfaces
{
    public interface IListifyService
    {
        Task<IList<int>> Listify(ListifyRequest request);
    }
}
