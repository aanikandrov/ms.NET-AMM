﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HistoricalBook.DataAccess.Entities;

[Table("Corrections")]
public class CorrectionEntity : BaseEntity
{
    public string Name { get; set; }
    public string Info { get; set; }
}