namespace Schematic.Core
{
    public interface IResourceContext<T> 
    {
        ResourceModel<T> OnPrepare(ResourceModel<T> model);

        ResourceModel<T> OnReturn(ResourceModel<T> model);
    }
}