﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class BackCommand : Command
    {
        public BackCommand() : base()
        {
            this.Name = "back";
        }

        override
        public bool Execute(Player player)
        {
            if (this.HasSecondWord())
            {
                player.OutputMessage("\nInvalid Command");
            }
            else
            {
                player.Back();
            }
            return false;
        }
    }
}
