using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_game")]
    public class TokoGameEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nama")]
        public String Nama { get; set; }

        [Column("genre")]
        public String Genre { get; set; }

        [Column("jumlah")]
        public int Jumlah { get; set; }

        [Column("tahun")]
        public int Tahun { get; set; }

        [Column("harga")]
        public int Harga { get; set; }
    }
}

