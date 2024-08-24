using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Entity_frame_work.Entities
{
    internal class Employee
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }




        //  [Key]
        //  [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //  public int Id { get; set; }
        //[Required]
        //[StringLength(50)]
        // [Column(TypeName ="varchar(50)")]
        //  public string? Name { get; set; }
        //  [Column(TypeName ="money")]
        //  public double Salary { get; set; }
        //  [Required]
        //  [StringLength(50)]
        //  public int? Age { get; set; }
        //  [Phone]
        //  public string phone {  get; set; }
        //  [EmailAddress]
        //  public string Email {  get; set; }
        //  [NotMapped]
        //  public double TotalSalary {  get; set; }


    }
}
