using TestProj.Builders.Interfaces;
using TestProj.Domain;
using TestProj.Resources;

namespace TestProj.Builders
{
    public class ListifyResourceBuilder : IListifyResourceBuilder
    {
        public ListifyResponseResource Build(ListifyRequestResource resource, List<int> list)
        {
            var res = new ListifyResponseResource();
            res.Listified = list;
            res.Index = resource.Index;
            res.Value = list[resource.Index];
            res.BegRange = resource.BegRange;
            res.EndRange = resource.EndRange;
            return res;
        }

        public ListifyRequest Build(ListifyRequestResource resource)
        {
            var req = new ListifyRequest();
            req.BegRange = resource.BegRange;
            req.EndRange = resource.EndRange;
            return req;
        }
    }
}
