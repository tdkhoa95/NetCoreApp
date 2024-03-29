﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreApp.Infrastructure.ShareKernel;

namespace CoreApp.Data.Entities
{
    [Table("Colors")]
    public class Color:DomainEntity<int>
    {
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string ColorCode { get; set; }
    }
}
