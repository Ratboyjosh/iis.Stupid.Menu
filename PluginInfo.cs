﻿namespace iiMenu
{
    public class PluginInfo
    {
        public const string GUID = "org.iidk.gorillatag.iimenu";
        public const string Name = "ii's Stupid Menu";
        public const string Description = "Created by @goldentrophy with love <3";
        public const string BuildTimestamp = "2025-06-26T07:55:30Z";
        public const string Version = "6.4.1";

#if DEBUG
        public static bool BetaBuild = true;
#else
        public static bool BetaBuild = false;
#endif
    }
}
