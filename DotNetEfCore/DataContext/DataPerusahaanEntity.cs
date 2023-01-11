using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_dataperusahaan")]
    public class DataPerusahaanEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("divisi")]
        public String Divisi { get; set; }

        [Column("leader")]
        public String Leader { get; set; }

        [Column("pkrwnt")]
        public String PkrWnt { get; set; }

        [Column("pkrpri")]
        public String PkrPri { get; set; }
    }
}

