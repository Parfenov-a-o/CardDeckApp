﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckApp.Additional
{
    public interface IMixer
    {
        public DeckOfCards Mix(DeckOfCards deck);
    }
}
