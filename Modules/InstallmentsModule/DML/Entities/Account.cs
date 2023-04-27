using InstallmentsModule.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Entities
{

    public class Account: MainEntity
    {
        public string RefId { get; set; } = string.Empty;
        public string Name { get; set; }=string.Empty;
    }
}
