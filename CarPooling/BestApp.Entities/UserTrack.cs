﻿using BestApp.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestApp.Entities
{
    public class UserTrack : BaseEntity<int>
    {
        public User User { get; set; }
        public Track Track { get; set; }
        public EnumUserType UserType { get; set; }
        public TimeSpan JoinHour { get; set; }
        // JoinHour reprezinta   ora de plecare a pasagerului/ora de plecare a soferului
    }
}
