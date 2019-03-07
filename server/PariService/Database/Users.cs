using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PariService.Database
{
    [Table("users")]
    public class Users
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("display_name")]
        public string DisplayName { get; set; }
    }
}