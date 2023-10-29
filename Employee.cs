using System.ComponentModel.DataAnnotations;

namespace hashi_project.Models
{

    public class Employee
    {
        public Employee()
        {
            Name = string.Empty;
            Surname = string.Empty;
            BirthDate = DateTime.Now;
            Position = string.Empty;
            Image = string.Empty;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
    }



}