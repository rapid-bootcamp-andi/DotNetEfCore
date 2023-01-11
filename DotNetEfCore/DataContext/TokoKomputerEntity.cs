using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_tokokomputer")]
    public class TokoKomputerEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nama")]
        public String Nama { get; set; }

        [Column("kategori")]
        public String Kategori { get; set; }

        [Column("jumlah")]
        public int Jumlah { get; set; }

        [Column("harga")]
        public int Harga { get; set; }
    }
}

