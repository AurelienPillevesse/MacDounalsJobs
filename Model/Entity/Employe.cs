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
    public class Employe
    {
        public int Id { get; set; }
        
        public string Nom { get; set; }
        
        public string Prenom { get; set; }
        
        public DateTime DateNaissance { get; set; }

        public int Anciennete { get; set; }

        public string Biographie { get; set; }

        public ICollection<Postulation> LesPostulations { get; set; }

        public ICollection<Formation> LesFormations { get; set; }

        public ICollection<Experience> LesExperiences { get; set; }
    }

    public class EmployeFluent : EntityTypeConfiguration<Employe>
    {
        public EmployeFluent()
        {
            ToTable("APP_Employe");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nom).HasColumnName("NOM").IsRequired().HasMaxLength(200);
            Property(c => c.Prenom).HasColumnName("PRENOM").IsRequired().HasMaxLength(200);
            Property(c => c.DateNaissance).HasColumnName("DATENAISSANCE").IsRequired();
            Property(c => c.Anciennete).HasColumnName("ANCIENNETE").IsRequired();
            Property(c => c.Biographie).HasColumnName("BIOGRAPHIE").IsRequired().HasMaxLength(400);

            HasMany(c => c.LesExperiences).WithRequired(cc => cc.Employe).HasForeignKey(cc => cc.EmployeId);
            HasMany(c => c.LesFormations).WithRequired(cc => cc.Employe).HasForeignKey(cc => cc.EmployeId);
            HasMany(c => c.LesPostulations).WithRequired(cc => cc.Employe).HasForeignKey(cc => cc.EmployeId);
        }
    }
}
