using Volo.Abp.Domain.Entities.Auditing;

namespace ABPCourse.Demo1.Categories
{
    public class Category : FullAuditedEntity<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
    }
}