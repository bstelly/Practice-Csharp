﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.IO;

namespace BackpackWinform
{
    public interface IPackable
    {
        string Name { get; set; }
        bool PickedUp { get; set; }
        string ImageDirectory { get; set; }
        void Pack(Backpack backpack);
    }
}
