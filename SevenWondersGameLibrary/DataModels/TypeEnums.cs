using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
    public enum ApplicableDirection
    {
        Self,
        Left,
        Right,
        Both
    }

    [Flags]
    public enum RawMaterialType
    {
        Clay = 0x00,
        Ore = 0x01,
        Stone = 0x02,
        Wood = 0x04
    }

    [Flags]
    public enum ManufacturedMaterialType
    {
        Glass = 0x00,
        Loom = 0x01,
        Papyrus = 0x02
    }

    public enum Age
    {
        One,
        Two,
        Three
    }

    public enum ScienceType
    {
        Gear,
        Tools,
        Glyph
    }
}
