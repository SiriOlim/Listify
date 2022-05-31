using TestProj.Resources;

namespace TestProj.Handlers.Interfaces
{
    public interface IListifyHandler
    {
        Task<ListifyResponseResource> HandleGet(ListifyRequestResource request);
    }
}
