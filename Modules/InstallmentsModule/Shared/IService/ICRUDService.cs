using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.Shared.IService
{
    public interface ICRUDService<Type, CreateDto, UpdateDto,GetListDto, FilterDto>
    {
        public Task<Guid> CreateAsync(CreateDto dto);
        public Task UpdateAsync(UpdateDto dto);
        public Task DeleteAsync(Guid id);
        public Task<List<GetListDto>> GetListAsync(FilterDto dto);
        public Task<Type> GetAsync(Guid id);
    }
}
