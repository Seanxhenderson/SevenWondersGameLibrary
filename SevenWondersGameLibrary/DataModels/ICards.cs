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
        Guid Id { get; }

        string Title { get; }

        string Description { get; }

        string ImageUrl { get; }

        CardState CurrentState { get; set; }
    }

    public interface IAgeCard : ICard
    {
        Age Age { get; }

        RawMaterialResourceCost RawMaterialResourceCost { get; }

        ManufacturedMaterialResourceCost ManufacturedMaterialResourceCost { get; }

        uint GoldCost { get; }

        IEnumerable<Guid> BaseCardId { get; }

        IEnumerable<Guid> DerivedCardIds { get; }

        uint MinimumNumberOfPlayers { get; }
    }

    public interface IRawMaterialCard : IAgeCard
    {
        IEnumerable<RawMaterialResourceToken> Resources { get; }
    }

    public interface IManufacturedMaterialCard : IAgeCard
    {
        IEnumerable<ManufactoredMaterialResourceToken> Resources { get; }
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

    public interface ICommerceCard : IAgeCard
    {
        ApplicableDirection UsabilityDirection { get; }
    }

    public interface ICommerceRawMaterialDiscountCard : ICommerceCard
    {
        IEnumerable<RawMaterialResourceToken> RawMaterialTokens { get; }

        uint DiscountedCost { get; }
    }

    public interface ICommerceManufactoredMaterialDiscountCard : ICommerceCard
    {
        IEnumerable<ManufactoredMaterialResourceToken> ManufactoredMaterialTokens { get; }

        uint DiscountedCost { get; }
    }

    public interface ICommerceGoldCard : ICommerceCard
    {
        uint GoldValue { get; }
    }

    public interface IGuildCard : IAgeCard
    {

    }
}
