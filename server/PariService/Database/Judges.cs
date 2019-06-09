using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PariService.Database
{
    [Table("judges")]
    public class Judges
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("pari_id")]
        public Guid PariId { get; set; }
    }
}