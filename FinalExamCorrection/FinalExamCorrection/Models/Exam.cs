﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FinalExamCorrection.Models;

public partial class Exam
{
    public int ExamId { get; set; }

    public int? Duration { get; set; }

    public DateOnly? Date { get; set; }

    public int? TotalMarks { get; set; }

    public int CrsId { get; set; }

    public string StudId { get; set; }

    public int? Score { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Course Crs { get; set; }

    public virtual Student Stud { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}