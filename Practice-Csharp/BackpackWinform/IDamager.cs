﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackpackWinform
{
    public interface IDamager
    {
        void Equip(Player player);
        void DoDamage(Entity enemy);
        int AttackValue { get; set; }
    }
}
