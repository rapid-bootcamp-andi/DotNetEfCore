using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_sendemail")]
    public class SendEmailEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("to")]
        public String To { get; set; }

        [Column("subject")]
        public String Subject { get; set; }

        [Column("from")]
        public String From { get; set; }

        [Column("message")]
        public String Message { get; set; }
    }
}

