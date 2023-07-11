using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DereceliToDoUygulama.Model
{
    public class ToDoModel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Comment { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string Ranked { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string Type { get; set; }
    }
}
