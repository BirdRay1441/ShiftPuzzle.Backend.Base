using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

public class Companion
{
    public int ID { get; set; }
    [StringLength(255, MinimumLength = 3)]
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd/}")]
    public DateTime? Date { get; set; }
    public int Reward { get; set; }
    public string? Origin { get; set; }
    public string? Destination { get; set; }     
}