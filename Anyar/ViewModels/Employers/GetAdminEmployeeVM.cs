namespace Anyar.ViewModels.Employers
{
    public class GetAdminEmployeeVM
    {
        public int Id { get; set; }

        public DateTime CreatedTime { get; set; }
        public bool IsDeleted { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }

        public string Vezife { get; set; }

        public string ImgUrl { get; set; }
    }
}
