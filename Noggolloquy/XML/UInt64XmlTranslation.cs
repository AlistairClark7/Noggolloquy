﻿using Noggog;
using System;

namespace Noggolloquy
{
    public class UInt64XmlTranslation : TypicalXmlTranslation<ulong>
    {
        public readonly static UInt64XmlTranslation Instance = new UInt64XmlTranslation();

        public override TryGet<ulong?> ParseNonNullString(string str)
        {
            ulong parsed;
            if (ulong.TryParse(str, out parsed))
            {
                return TryGet<ulong?>.Success(parsed);
            }
            return TryGet<ulong?>.Failure($"Could not convert to {ElementName}");
        }
    }
}