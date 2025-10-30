﻿namespace DatabaseTask.Core.Domain
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string Morning { get; set; } = string.Empty;
        public string MorningSnack { get; set; } = string.Empty;
        public string Lunch { get; set; } = string.Empty;
        public string DinnerSnack { get; set; } = string.Empty;
        public string Dinner { get; set; } = string.Empty;
        public DateTime DateFood { get; set; }
        public int Portions { get; set; }

        public IEnumerable<Group> Groups { get; set;  } 
            = new List<Group>();
    }
}
