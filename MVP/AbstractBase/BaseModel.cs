namespace iLeif.MVP.AbstractBase
{
    public abstract class BaseModel : IModel
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
    }
}
