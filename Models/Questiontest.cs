using System;
using System.Collections.Generic;

namespace ZOTMigration.Models;

public partial class Questiontest
{
    public int TestId { get; set; }

    public int? TestDetailId { get; set; }

    public int? QuestionId { get; set; }

    public int? AnswerId { get; set; }

    public virtual Answer? Answer { get; set; }

    public virtual Question? Question { get; set; }

    public virtual Testdetail? TestDetail { get; set; }
}
