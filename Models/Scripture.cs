using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
	public class Scripture
	{
        public int ID { get; set; }

        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string Book { get; set; } = string.Empty;

        [StringLength(5)]
        [Required]
        public string Chapter { get; set; } = string.Empty;

        [StringLength(10)]
        [Required]
        public string Verses { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Notes { get; set; } = string.Empty;

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; } = DateTime.Now;
    }
}

