using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProj.Domain;
using TestProj.ServiceInterfaces;

namespace TestProj.Services
{
    public class ListifyService : IListifyService
    {
        public async Task<IList<int>> Listify(ListifyRequest request)
        {
            IEnumerable<int> l = Enumerable.Range(request.BegRange, request.EndRange);
            return await Task.FromResult(l.ToList());
        }
    }
}
