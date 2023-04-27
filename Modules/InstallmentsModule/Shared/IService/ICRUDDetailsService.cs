using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.Shared.IService
{
    public interface ICRUDDetailsService<Type>
    {
        public Task CreateAsync(List<Type> entities);
        public Task UpdateAsync(Guid headerId,List<Type> entities);
        public Task DeleteByHeaderIdAsync(Guid headerId);
        public Task<List<Type>> GetByHeaderIdAsync(Guid headerId);
    }
}
