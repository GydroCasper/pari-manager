using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PariService.Database
{
    [Table("paris")]
    public class Paris
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }
    }
}