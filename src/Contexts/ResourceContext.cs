namespace Schematic.Core
{
    public class ResourceContext<T> : IResourceContext<T>
    {
        public ResourceModel<T> OnCreate(ResourceModel<T> model) => model;

        public ResourceModel<T> OnNew(ResourceModel<T> model) => model;

        public ResourceModel<T> OnRead(ResourceModel<T> model) => model;

        public ResourceModel<T> OnUpdate(ResourceModel<T> model) => model;
    }
}