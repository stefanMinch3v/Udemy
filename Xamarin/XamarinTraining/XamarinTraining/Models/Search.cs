using System;

namespace XamarinTraining.Models
{
    public class Search
    {
        public int Id { get; set; }

        public string Location { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public string Period => $"{this.CheckIn.ToShortDateString()} - {this.CheckOut.ToShortDateString()}";
    }
}
