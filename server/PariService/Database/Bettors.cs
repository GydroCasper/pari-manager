using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PariService.Database
{
    [Table("bettors")]
    public class Bettors
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("attitude_id")]
        public Guid AttitudeId { get; set; }
    }
}