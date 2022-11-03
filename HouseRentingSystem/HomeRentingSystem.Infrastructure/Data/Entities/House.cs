using HouseRentingSystem.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeRentingSystem.Infrastructure.Data.DataConstants.House;

namespace HomeRentingSystem.Infrastructure.Data.Entities
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(HouseTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(HouseAddressMaxLength)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(HouseDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(HouseImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        public string? RenterId { get; set; }

        [ForeignKey(nameof(RenterId))]
        public IdentityUser? Renter { get; set; }
    }
}
