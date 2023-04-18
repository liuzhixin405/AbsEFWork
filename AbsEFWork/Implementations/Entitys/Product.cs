﻿using BaseEntityFramework.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseEntityFramework.Implementations.Entitys
{
    public class Product:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(28,16)")]
        public decimal Price { get; set; }
    }
}
