﻿using PersonalBlog.Core.Data.Abstract;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Abstract
{
    public interface IAdminRepository: IEntityRepository<Admin>
    {

    }
}