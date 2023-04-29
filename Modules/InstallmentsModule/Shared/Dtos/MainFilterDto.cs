using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.Shared.Dtos
{
    public class MainFilterDto
    {  
        public string? CreatedByUserId { get; set; } = string.Empty;
        public string? LastUpdateByUserId { get; set; } = string.Empty;
        public DateTimeOffset? FromCreateDate { get; set; }
        public DateTimeOffset? ToCreateDate { get; set; }
        public DateTimeOffset? FromLastUpdateDate { get; set; }
        public DateTimeOffset? ToLastUpdateDate { get; set; }
    }
}
