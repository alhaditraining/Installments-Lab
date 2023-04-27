using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.Shared.Entities
{
    public class MainDetailsEntity
    {
        public Guid Id { get; set; }
        public Guid HeaderId { get; set; }
        public byte[]? RowVersion { get; set; }
    }
}
