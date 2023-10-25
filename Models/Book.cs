
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace CRUDusingEntityFremeWk.Models
{
    //this class alse called entity class/BO(Business Object)/poco(plan old CLR Object) class
    [Table("Book")]//Map Class with table in DB//Must match in DB Table Name
    public class Book
    {
        [Key]//this is pk colom in Db
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        public int Price { get; set; }

    }
}
