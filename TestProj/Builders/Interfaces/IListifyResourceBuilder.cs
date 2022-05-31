using TestProj.Domain;
using TestProj.Resources;

namespace TestProj.Builders.Interfaces
{
    public interface IListifyResourceBuilder
    {
        ListifyResponseResource Build(ListifyRequestResource resource, List<int> list);
        ListifyRequest Build(ListifyRequestResource resource);

    }
}
