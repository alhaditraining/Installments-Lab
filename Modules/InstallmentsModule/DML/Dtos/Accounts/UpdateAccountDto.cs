using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Dtos.Accounts
{
    public class UpdateAccountDto
    {
        [MaxLength(50)]
        public string? UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string RefId { get; set; }=string.Empty;
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
