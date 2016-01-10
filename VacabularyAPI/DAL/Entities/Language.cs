using System.ComponentModel.DataAnnotations;
using DAL.Contracts.Entities;

namespace DAL.Entities
{
    public class Language : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
