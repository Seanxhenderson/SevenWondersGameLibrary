using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary
{
    [Flags]
    public enum RawMaterialType
    {
        Clay = 0x00,
        Ore = 0x01,
        Stone = 0x02,
        Wood = 0x04
    }

    [Flags]
    public enum ManufacturedGoodType
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

    interface ICard
    {
        string Title { get; }

        string Description { get; }

        string ImageUrl { get; }
    }

    interface IAgeCard : ICard
    {
        Age Age { get; }

        IReadOnlyDictionary<RawMaterialType, uint> RawMaterialCost { get; }

        IReadOnlyDictionary<ManufacturedGoodType, uint> ManufacturedGoodCost { get; }

        IAgeCard CardCost { get; }
    }

    interface RawMaterialCard : IAgeCard
    {
        RawMaterialType Type { get; }

        uint Amount { get; }
    }

    interface ManufacturedGoodTypeCard : IAgeCard
    {
        ManufacturedGoodType Type { get; }

        uint Amount { get; }
    }

    interface IMilitaryCard : IAgeCard
    {
        uint Strength { get; }
    }

    interface IScienceCard : IAgeCard
    {
        ScienceType ScienceType { get; }
    }

    interface ICivilianStructureCard : IAgeCard
    {
        uint VictoryPoints { get; }
    }

    interface ICommercialStructureCard : IAgeCard
    {

    }

    interface IGuildCard : IAgeCard
    {

    }
}
