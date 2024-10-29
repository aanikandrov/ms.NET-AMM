﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HistoricalBook.DataAccess.Entities;

[Table("Events")]
public class EventEntity : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
}