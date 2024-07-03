using System.ComponentModel.DataAnnotations;

namespace CURDOperation.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int PhoneNo { get; set; }
       

    }
}
//ms entityframework
//m