namespace Anyar.Models
{
    public class Employee : BaseEntity
    {
        public string FullName { get; set; }
        public string Description { get; set; }

        public string  Vezife { get; set; }

        public string ImgUrl { get; set; }
    }
}
