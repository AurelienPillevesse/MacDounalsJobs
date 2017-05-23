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
    public class Postulation
    {
        public int Id { get; set; }
        
        public Employe Employe { get; set; }
        
        public Offre Offre { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Status { get; set; }

        public int EmployeId { get; set; }
    }

    public class PostulationFluent : EntityTypeConfiguration<Postulation>
    {
        public PostulationFluent()
        {
            ToTable("APP_Postulation");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Status).HasColumnName("STATUS").IsRequired().HasMaxLength(400);
            Property(c => c.Date).HasColumnName("DATE");

            //offre
        }
    }
}
