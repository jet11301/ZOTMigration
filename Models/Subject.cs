﻿using System;
using System.Collections.Generic;

namespace ZOTMigration.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public string? ImgLink { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
