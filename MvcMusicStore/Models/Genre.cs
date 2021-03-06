﻿using System.Collections.Generic;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        public virtual int GenreID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Album> MyProperty { get; set; }
    }
}