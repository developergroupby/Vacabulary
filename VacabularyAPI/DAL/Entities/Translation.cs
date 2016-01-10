using System.ComponentModel.DataAnnotations;
using DAL.Contracts.Entities;

namespace DAL.Entities
{
    public class Translation : IEntity
    {
        public int Id { get; set; }
        public int WordId { get; set; }
        public virtual Word Word { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        [Required]
        public string Meaning { get; set; }
    }
}
