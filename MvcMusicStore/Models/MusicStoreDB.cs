﻿using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreDB: DbContext
    {
        public MusicStoreDB() : base("name=MusicStoreDB")
        {

        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}