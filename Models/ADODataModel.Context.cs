﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestaoPatrimonio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GestaoPatrimonioEntities : DbContext
    {
        public GestaoPatrimonioEntities()
            : base("name=GestaoPatrimonioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Centro> Centro { get; set; }
        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Filial> Filial { get; set; }
        public virtual DbSet<RadioBase> RadioBase { get; set; }
        public virtual DbSet<Setor> Setor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tag_Div> Tag_Div { get; set; }
        public virtual DbSet<Tag_HTML> Tag_HTML { get; set; }
        public virtual DbSet<Tag_Hyperlink> Tag_Hyperlink { get; set; }
        public virtual DbSet<Tag_Item_li> Tag_Item_li { get; set; }
        public virtual DbSet<Tag_SVG_Symbol> Tag_SVG_Symbol { get; set; }
        public virtual DbSet<UnidadeNegocio> UnidadeNegocio { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Manutencao> Manutencao { get; set; }
        public virtual DbSet<Patrimonio> Patrimonio { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
    }
}
