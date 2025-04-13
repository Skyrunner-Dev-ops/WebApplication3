using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Option> Options { get; set; }
    }

    public class Option
    {
        public string Text { get; set; }
        // Traits is a list of personality traits (natures) that this answer represents.
        public List<string> Traits { get; set; }
    }
}