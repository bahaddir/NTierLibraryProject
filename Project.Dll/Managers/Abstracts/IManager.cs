using Project.Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Bll.Managers.Abstracts
{
    public interface IManager<TDto> where TDto : BaseDto
    {
        Task<TDto> AddAsync(TDto dto);
        Task<TDto> UpdateAsync(TDto dto);
        Task<bool> DeleteAsync(int id);

        Task<TDto> GetByIdAsync(int id);
        Task<List<TDto>> GetAllAsync();
    }
}
