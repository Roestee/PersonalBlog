﻿using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete
{
    public class Education: EntityBase, IEntity
    {
        public string Title { get; set; }
        public string School { get; set; }
        public string Duration { get; set; }
        public string Avarage { get; set; }
        public string Description { get; set; }
    }
}
