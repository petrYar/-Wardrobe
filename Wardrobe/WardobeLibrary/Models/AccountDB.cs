﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardobeLibrary.Models
{
    [Table("tblAccountDB")]
    public class AccountDB
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; private set; }

        public string Password { get; set; }

        public string Token { get; set; }

        [ForeignKey("ClothesOf")]
        public int IdClothes { get; set; }


        public virtual ICollection<ClothesDB> ClothesOf { get; set; }
    }
}
