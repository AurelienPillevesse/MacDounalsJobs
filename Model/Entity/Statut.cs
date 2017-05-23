using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Statut
    {
        public int Id { get; set; }

        public string Libelle { get; set; } 
    }

    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("APP_Statut");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Libelle).HasColumnName("LIBELLE").IsRequired().HasMaxLength(400);
        }
    }
}
