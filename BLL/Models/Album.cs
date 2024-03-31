using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models;

public class Album
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = null!;
    [Required]
    [StringLength(64)]
    public string Publisher { get; set; }
    [Required]
    public int Tracks { get; set; }
    [Required]
    [StringLength(32)]
    public string Genre { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public int CostPrice { get; set; }
    [Required]
    public int SellPrice { get; set; }
    public Artist Artist { get; set; }
}
