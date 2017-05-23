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
    public class Experience
    {
        public int Id { get; set; }
        
        public Employe Employe { get; set; }

        public int EmployeId { get; set; }

        public string Intitule { get; set; }
        
        public DateTime Date { get; set; }
    }

    public class ExperienceFluent : EntityTypeConfiguration<Experience>
    {
        public ExperienceFluent()
        {
            ToTable("APP_Experience");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Intitule).HasColumnName("INTITULE").IsRequired().HasMaxLength(300);
            Property(c => c.Date).HasColumnName("DATE").IsRequired();
        }
    }
}
