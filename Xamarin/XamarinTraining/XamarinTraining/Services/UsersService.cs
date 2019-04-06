﻿using System.Collections.Generic;
using System.Linq;
using XamarinTraining.Models;

namespace XamarinTraining.Services
{
    public class UsersService : IUsersService
    {
        private IList<User> users = new List<User>
        {
            new User { Id = 1, Description = "My name is Jenny Dalby", Name = "Jenny Dalby" },
            new User { Id = 2, Description = "My name is Jonv", Name = "Jonv" },
            new User { Id = 3, Description = "My name is RachelMartin", Name = "RachelMartin" },
            new User { Id = 4, Description = "My name is Noy Jay", Name = "Noy Jay" },
            new User { Id = 5, Description = "My name is SanazZ", Name = "SanazZ" },
            new User { Id = 6, Description = "My name is NextLab", Name = "NextLab" },
            new User { Id = 7, Description = "My name is Alex B", Name = "AlexB" },
            new User { Id = 8, Description = "My name is Tara Chang", Name = "Tara Chang" },
            new User { Id = 9, Description = "My name is TomK", Name = "Tom K" }
        };

        public User Single(int id)
            => this.users.FirstOrDefault(u => u.Id == id);
    }
}
