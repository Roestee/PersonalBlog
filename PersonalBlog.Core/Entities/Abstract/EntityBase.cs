namespace PersonalBlog.Core.Entities.Abstract
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime ModifiedTime { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = false;
        public bool IsDelete { get; set; } = false;
        public string CreatedBy { get; set; } = "Admin";
        public string ModifiedBy { get; set; } = "Admin";
    }
}
