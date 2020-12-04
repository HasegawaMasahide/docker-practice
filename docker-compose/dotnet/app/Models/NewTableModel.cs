using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("NewTable")]
    public class NewTableModel
    {
        [Key]
        [Column(name : "id")]
        public int Id { get; set; }

        [Column(name : "title")]
        public string Title { get; set; }

        [Column(name : "contents")]
        public string Contents { get; set; }
    }
}