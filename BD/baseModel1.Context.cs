﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class katalogEntities : DbContext
    {
        private static katalogEntities _context;
        public katalogEntities()
            : base("name=katalogEntities")
        {
        }
        public static katalogEntities GetContext()
        {
            if (_context == null)
                _context = new katalogEntities();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Garantiya> Garantiya { get; set; }
        public virtual DbSet<Key_illumination_color> Key_illumination_color { get; set; }
        public virtual DbSet<keyboard> keyboard { get; set; }
        public virtual DbSet<keyboard_type> keyboard_type { get; set; }
        public virtual DbSet<Kreslo> Kreslo { get; set; }
        public virtual DbSet<kreslo_type> kreslo_type { get; set; }
        public virtual DbSet<Micro_ushi> Micro_ushi { get; set; }
        public virtual DbSet<Microfon> Microfon { get; set; }
        public virtual DbSet<microfon_type> microfon_type { get; set; }
        public virtual DbSet<Mouse> Mouse { get; set; }
        public virtual DbSet<Mouse_type> Mouse_type { get; set; }
        public virtual DbSet<naushniki> naushniki { get; set; }
        public virtual DbSet<Naushniki_type> Naushniki_type { get; set; }
        public virtual DbSet<number_user> number_user { get; set; }
        public virtual DbSet<proizvoditel> proizvoditel { get; set; }
        public virtual DbSet<roll> roll { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
