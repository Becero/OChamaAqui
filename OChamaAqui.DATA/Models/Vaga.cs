﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OChamaAqui.DATA.Models
{
    public partial class Vaga
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Valor { get; set; }
        [Required]
        [StringLength(10)]
        public string Local { get; set; }
    }
}