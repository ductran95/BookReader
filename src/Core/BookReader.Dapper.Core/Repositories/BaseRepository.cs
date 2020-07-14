using System;
using System.Collections.Generic;
using System.Text;
using BookReader.Infrastructure.Core.Entities;
using BookReader.Infrastructure.Core.Repositories;

namespace BookReader.Dapper.Core.Repositories
{
    public class BaseRepository<T>: IBaseRepository<T> where T : BaseEntity
    {
    }
}
