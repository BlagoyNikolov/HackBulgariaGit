﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary {
    class Honda : Car {
        protected override bool IsEcoFriendly(bool testing) {
            return true;
        }
    }
}
