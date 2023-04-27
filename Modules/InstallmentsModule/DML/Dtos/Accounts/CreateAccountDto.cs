using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Dtos.Accounts
{
    public class CreateAccountDto
    {

        public string? UserId { get; set; }
        [Required]
        public string RefId { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
