using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Interfaces
{
    public interface IPostManager
    {
        Task<PostDTO> GetPostByIdAsync();

        Task<IEnumerable<PostDTO>> GetAllPostsAsync();

        Task<IEnumerable<PostDTO>> GetAllPostsByUserIdAsync(int userId);

        Task<IEnumerable<PostDTO>> GetAllPostsByTermIdsAsync(IEnumerable<int> termId);
    }
}
