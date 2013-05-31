﻿// Guids.cs
// MUST match guids.h
using System;

namespace kavengagne.ClipboardHistory
{
    static class GuidList
    {
        public const string guidClipboardHistoryPkgString = "ce59ed1c-307e-43a2-a528-a88bde8416cf";
        public const string guidClipboardHistoryCmdSetString = "df03a06a-1a35-4449-9477-b4dbc0cf2c67";
        public const string guidToolWindowPersistanceString = "f5065328-2c0d-41f8-a374-8de3f0f19b3b";

        public static readonly Guid guidClipboardHistoryCmdSet = new Guid(guidClipboardHistoryCmdSetString);
    };
}