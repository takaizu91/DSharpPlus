﻿using System;

namespace DSharpPlus
{
    public class DiscordKeepAliveSentEventArgs : EventArgs
    {
        public DateTime SentAt { get; set; }
        public string JsonSent { get; set; }
    }
}