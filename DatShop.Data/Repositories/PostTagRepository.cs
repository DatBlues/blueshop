using DatShop.Data.Infrastructure;
using DatShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
    {

    }
    class PostTagRepository: RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
