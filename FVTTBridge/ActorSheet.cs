﻿using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;

namespace FVTTBridge
{
    [External]
    [Namespace(false)]
    public class ActorSheet
    {
        public ActorSheet()
        {
            Console.WriteLine("made an ActorSheet");
        }
    }
}
