using TestProj.Builders.Interfaces;
using TestProj.Handlers.Interfaces;
using TestProj.Resources;
using TestProj.ServiceInterfaces;

namespace TestProj.Handlers
{
    public class ListifyHandler : IListifyHandler
    {
        private readonly IListifyResourceBuilder _builder;
        private readonly IListifyService _service;

        public ListifyHandler(IListifyResourceBuilder builder, IListifyService service)
        {
            _builder = builder;
            _service = service;
        }
        public async Task<ListifyResponseResource> HandleGet(ListifyRequestResource request)
        {
            var res = await _service.Listify(_builder.Build(request));
            return _builder.Build(request, res.ToList());
        }
    }
}
