
namespace ConsoleApp1.Domain
{
    public class Picture : BaseEntity
    {
        public virtual string Uri { get; set; }
        
        public virtual string Alt { get; set; }

        public virtual Entity Entity { get; set; }
    }
}
