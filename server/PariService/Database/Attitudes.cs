using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PariService.Database
{
    [Table("attitudes")]
    public class Attitudes
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("pari-id")]
        public Guid PariId { get; set; }
    }
}