using System.ComponentModel.DataAnnotations;
using DAL.Contracts.Entities;

namespace DAL.Entities
{
    public class Word : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }
}
