﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HistoricalBook.DataAccess.Entities;

[Table("Persons")]
public class PersonEntity : BaseEntity
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime DeathDate { get; set; }
}