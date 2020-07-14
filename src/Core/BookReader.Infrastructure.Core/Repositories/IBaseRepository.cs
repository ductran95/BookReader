using System;
using System.Collections.Generic;
using System.Text;
using BookReader.Infrastructure.Core.Entities;

namespace BookReader.Infrastructure.Core.Repositories
{
    public interface IBaseRepository<T> where T: BaseEntity
    {
    }
}
