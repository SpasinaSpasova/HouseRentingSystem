using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeRentingSystem.Infrastructure.Data.DataConstants.Agent;

namespace HouseRentingSystem.Core.Models.Agent
{
    public class BecomeAgentModel
    {
        [Required]
        [StringLength(AgentPhoneNumberMaxLength, MinimumLength = AgentPhoneNumberMinLength)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;
    }
}
