using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
    public enum CardState
    {
        // The card is not applicable for the current setting (e.g. wrong age, etc)
        NotAvailable,

        // The card is available to use but currently not used (e.g. one of the available cards in the age not used by anyone)
        AvailableNotUsed,

        // The card is discarded (i.e. by the users choice or is the last card of an age)
        Discarded,

        // The card is taken by a user and used according to its ability (e.g. it is part of a user's collection of cards)
        FaceUpUsed,

        // The card is taken by a user but used as a facedown card (e.g. for building wonders)
        FaceDownUsed
    }

    [Flags]
    public enum SymbolType
    {
        RawResource = 0x00,
        ManufactoredResource,
        Science,
        Culture,
        Military,
        Commerce,
        Guild,
        WonderStage
    }

    public enum ApplicableDirection
    {
        None,
        Self,
        Left,
        Right,
        LeftAndRight,
        LeftAndSelf,
        RightAndSelf,
        All
    }

    [Flags]
    public enum RawMaterialType
    {
        Clay = 0x00,
        Ore,
        Stone,
        Wood
    }

    [Flags]
    public enum ManufactoredMaterialType
    {
        Glass = 0x00,
        Loom,
        Papyrus
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
