using InstallmentsModule.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Entities
{

    public class Account: MainEntity
    {
        [MaxLength(50)]
        public string RefId { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Name { get; set; }=string.Empty;
    }
}
