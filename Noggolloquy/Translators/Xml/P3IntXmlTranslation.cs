﻿using Noggog;
using System;

namespace Noggolloquy.Xml
{
    public class P3IntXmlTranslation : TypicalXmlTranslation<P3Int>
    {
        public readonly static P3IntXmlTranslation Instance = new P3IntXmlTranslation();

        protected override string GetItemStr(P3Int? item)
        {
            if (!item.HasValue) return null;
            return $"{item.Value.X}, {item.Value.Y}, {item.Value.Z}";
        }

        protected override P3Int ParseNonNullString(string str)
        {
            if (P3Int.TryParse(str, out P3Int parsed))
            {
                return parsed;
            }
            throw new ArgumentException($"Could not convert to {ElementName}");
        }
    }
}
