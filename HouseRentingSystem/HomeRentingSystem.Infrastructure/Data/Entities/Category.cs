using HomeRentingSystem.Infrastructure.Data.Entities;
using System.ComponentModel.DataAnnotations;
using static HomeRentingSystem.Infrastructure.Data.DataConstants.Category;

namespace HouseRentingSystem.Infrastructure.Data.Entities
{
    public class Category
    {
        public Category()
        {
            Houses = new List<House>();
        }


        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryNameMaxLength)]
        public string Name { get; set; } = null!;

        public List<House> Houses { get; set; }
    }
}