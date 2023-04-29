using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.Shared.Entities
{
    public class MainEntity
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string CreatedByUserId { get; set; } = string.Empty;
        public DateTimeOffset CreatedDatetime { get; set; }
        [MaxLength(50)]
        public string? LastUpdateByUserId { get; set; } = string.Empty;
        public DateTimeOffset? LastUpdateDatetime { get; set; }
        public byte[]? RowVersion { get; set; }

        public void Create(string userid)
        {
            CreatedByUserId = userid;
            CreatedDatetime = DateTimeOffset.Now;
        }
        public void Update(string userid)
        {
            LastUpdateByUserId = userid;
            LastUpdateDatetime = DateTimeOffset.Now;
        }
    }
}
