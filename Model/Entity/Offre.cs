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
    public class Offre
    {
        public int Id { get; set; }
        
        public string Intitule { get; set; }
        
        public DateTime Date { get; set; }
        
        public double Salaire { get; set; }
        
        public string Description { get; set; }
        
        public string Responsable { get; set; }
         
        public Statut Status { get; set; }
    }

    public class OffreFluent : EntityTypeConfiguration<Offre>
    {
        public OffreFluent()
        {
            ToTable("APP_Offre");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Intitule).HasColumnName("INTITULE").IsRequired().HasMaxLength(200);
            Property(c => c.Date).HasColumnName("DATE");
            Property(c => c.Salaire).HasColumnName("SALAIRE");
            Property(c => c.Description).HasColumnName("DESCRIPTION").IsRequired().HasMaxLength(200);
            Property(c => c.Responsable).HasColumnName("RESPONSABLE").IsRequired().HasMaxLength(200);

            //HasRequired(c => c.Status).WithMany(e=> e.).HasForeignKey(o => o.Status);
        }
    }
}
