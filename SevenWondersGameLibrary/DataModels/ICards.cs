using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
    public interface ICard
    {
        string Title { get; }

        string Description { get; }

        string ImageUrl { get; }
    }

    public interface IAgeCard : ICard
    {
        Age Age { get; }

        RawMaterialResourceCost RawMaterialResourceCost { get; }

        ManufacturedMaterialResourceCost ManufacturedMaterialResourceCost { get; }

        uint GoldCost { get; }

        IAgeCard ParentCard { get; }

        IEnumerable<IAgeCard> ChildCards { get; }

        uint MinimumNumberOfPlayers { get; }
    }

    public interface IRawMaterialCard : IAgeCard
    {
        IEnumerable<RawMaterialResourceToken> Resources { get; }
    }

    public interface IManufacturedMaterialCard : IAgeCard
    {
        IEnumerable<ManufacturedMaterialResourceToken> Resources { get; }
    }

    public interface ICultureCard : IAgeCard
    {
        uint VictoryValue { get; }
    }

    public interface IMilitaryCard : IAgeCard
    {
        uint MilitaryValue { get; }
    }

    public interface IScienceCard : IAgeCard
    {
        ScienceType ScienceType { get; }
    }

    public interface ICommercialCard : IAgeCard
    {
        ApplicableDirection Users { get; }
    }

    public interface IGuildCard : IAgeCard
    {

    }
}
