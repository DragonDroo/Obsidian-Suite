﻿using System.Collections.Generic;
using Slats.Models.Enum;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slats.Models
{
    public class Question
    {
        public Question()
        {
            this.Alternatives = new Collection<Alternative>();
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public QuestionType Type { get; set; }

        public int? QuizId { get; set; }
        [ForeignKey("QuizId")]
        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<Alternative> Alternatives { get; set; }
    }
}
