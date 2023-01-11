using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_datatamu")]
    public class DataTamuEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nama")]
        public String Nama { get; set; }

        [Column("kota")]
        public String Kota { get; set; }

        [Column("nowa")]
        public int NoWa { get; set; }

        [Column("notlp")]
        public int NoTlp { get; set; }
    }
}

