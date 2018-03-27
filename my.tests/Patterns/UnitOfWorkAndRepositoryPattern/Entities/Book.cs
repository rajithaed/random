using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace my.tests.Patterns.UnitOfWorkAndRepositoryPattern.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("AuthorID")]
        public virtual Author Author { get; set; }
    }
}