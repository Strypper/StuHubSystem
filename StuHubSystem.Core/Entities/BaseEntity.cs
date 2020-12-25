using System.ComponentModel.DataAnnotations;

namespace StuHubSystem.Core.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
