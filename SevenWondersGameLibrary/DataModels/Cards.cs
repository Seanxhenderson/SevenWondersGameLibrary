using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
    [DataContract]
    public abstract class AgeCard : IAgeCard
    {
        public AgeCard(
            Guid id,
            Age age, 
            string title, 
            string description, 
            uint minimumNumberOfPlayers, 
            uint goldCost, 
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
        {
            this.Id = id;
            this.Age = age;
            this.Title = title;
            this.Description = description;
            this.MinimumNumberOfPlayers = minimumNumberOfPlayers;
            this.GoldCost = goldCost;
            this.RawMaterialResourceCost = rawMaterialResourceCost;
            this.ManufacturedMaterialResourceCost = manufacturedMaterialResourceCost;
            this.BaseCardId = baseCardId;
            this.DerivedCardIds = derivedCardIds;
            this.CurrentState = CardState.NotAvailable;
        }

        [DataMember]
        public Guid Id
        {
            get;
            private set;
        }

        [DataMember]
        public Age Age
        {
            get;
            private set;
        }

        [DataMember]
        public string Description
        {
            get;
            private set;
        }

        [DataMember]
        public uint GoldCost
        {
            get;
            private set;
        }

        [DataMember]
        public string ImageUrl
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        [DataMember]
        public uint MinimumNumberOfPlayers
        {
            get;
            private set;
        }

        [DataMember]
        public IEnumerable<Guid> BaseCardId
        {
            get;
            protected set;
        }

        [DataMember]
        public IEnumerable<Guid> DerivedCardIds
        {
            get;
            protected set;
        }

        [DataMember]
        public RawMaterialResourceCost RawMaterialResourceCost
        {
            get;
            private set;
        }

        [DataMember]
        public ManufacturedMaterialResourceCost ManufacturedMaterialResourceCost
        {
            get;
            private set;
        }

        [DataMember]
        public string Title
        {
            get;
            private set;
        }

        [DataMember]
        public CardState CurrentState
        {
            get;
            set;
        }
    }

    [DataContract]
    public sealed class RawMaterialCard : AgeCard, IRawMaterialCard
    {
        public RawMaterialCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            IEnumerable<RawMaterialResourceToken> resources,
            uint goldCost)
            : base(id, age, title, description, minimumNumberOfPlayers, goldCost, RawMaterialResourceCost.Free, ManufacturedMaterialResourceCost.Free, null, null)
        {
            this.Resources = resources;
        }

        [DataMember]
        public IEnumerable<RawMaterialResourceToken> Resources
        {
            get;
            private set;
        }
    }

    [DataContract]
    public sealed class ManufacturedGoodCard : AgeCard, IManufacturedMaterialCard
    {
        public ManufacturedGoodCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            IEnumerable<ManufactoredMaterialResourceToken> resources,
            uint goldCost)
            : base(id, age, title, description, minimumNumberOfPlayers, goldCost, RawMaterialResourceCost.Free, ManufacturedMaterialResourceCost.Free, null, null)
        {
            this.Resources = resources;
        }

        [DataMember]
        public IEnumerable<ManufactoredMaterialResourceToken> Resources 
        {
            get;
            private set;
        }
    }

    [DataContract]
    public sealed class CultureCard : AgeCard, ICultureCard
    {
        public CultureCard(
            Guid id,
            Age age, 
            string title, 
            string description, 
            uint minimumNumberOfPlayers, 
            uint victoryValue,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, 0, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        {
            this.VictoryValue = victoryValue;
        }

        [DataMember]
        public uint VictoryValue
        {
            get;
            private set;
        }
    }

    [DataContract]
    public sealed class MilitaryCard : AgeCard, IMilitaryCard
    {
        public MilitaryCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            uint militaryValue,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, 0, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        {
            this.MilitaryValue = militaryValue;
        }

        [DataMember]
        public uint MilitaryValue
        {
            get;
            private set;
        }
    }

    [DataContract]
    public sealed class ScienceCard : AgeCard, IScienceCard
    {
        public ScienceCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            ScienceType scienceType,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, 0, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        {
            this.ScienceType = scienceType;
        }

        [DataMember]
        public ScienceType ScienceType
        {
            get;
            private set;
        }
    }

    [DataContract]
    public abstract class CommerceCardBase : AgeCard, ICommerceCard
    {
        public CommerceCardBase(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            ApplicableDirection usabilityDirection,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, 0, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        {
            this.UsabilityDirection = usabilityDirection;
        }

        [DataMember]
        public ApplicableDirection UsabilityDirection
        {
            get;
            protected set;
        }
    }

    [DataContract]
    public sealed class CommerceRawMaterialDiscountCard : CommerceCardBase, ICommerceRawMaterialDiscountCard
    {
        public CommerceRawMaterialDiscountCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            uint discountValue,
            IEnumerable<RawMaterialResourceToken> rawMaterialTokens,
            ApplicableDirection usabilityDirection,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, usabilityDirection, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        {
            this.DiscountedCost = discountValue;
            this.RawMaterialTokens = rawMaterialTokens;
        }

        [DataMember]
        public uint DiscountedCost
        {
            get;
            private set;
        }

        [DataMember]
        public IEnumerable<RawMaterialResourceToken> RawMaterialTokens
        {
            get;
            private set;
        }
    }

    [DataContract]
    public sealed class CommerceManufactoredMaterialDiscountCard : CommerceCardBase, ICommerceManufactoredMaterialDiscountCard
    {
        public CommerceManufactoredMaterialDiscountCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            uint discountValue,
            IEnumerable<ManufactoredMaterialResourceToken> manufactoredMaterialTokens,
            ApplicableDirection usabilityDirection,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, usabilityDirection, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        {
            this.DiscountedCost = discountValue;
            this.ManufactoredMaterialTokens = manufactoredMaterialTokens;
        }

        [DataMember]
        public uint DiscountedCost
        {
            get;
            private set;
        }

        [DataMember]
        public IEnumerable<ManufactoredMaterialResourceToken> ManufactoredMaterialTokens
        {
            get;
            private set;
        }
    }

    [DataContract]
    public sealed class CommerceGoldCard : CommerceCardBase, ICommerceGoldCard
    {
        public CommerceGoldCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            uint goldValue,
            ApplicableDirection usabilityDirection,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, usabilityDirection, rawMaterialResourceCost, manufacturedMaterialResourceCost,  baseCardId, derivedCardIds)
        {
            this.GoldValue = goldValue;
        }

        [DataMember]
        public uint GoldValue
        {
            get;
            private set;
        }
    }

    [DataContract]
    public sealed class CommerceRewardPerSymbolCard : CommerceCardBase, ICommerceRewardPerSymbolCard
    {
        public CommerceRewardPerSymbolCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            SymbolType symbolType,
            uint victoryPointsPerSymbolType,
            uint goldPerSymbolType,
            ApplicableDirection usabilityDirection,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, usabilityDirection, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        { 
            this.SymbolType = symbolType;
            this.VictoryPointsPerSymbolType = victoryPointsPerSymbolType;
            this.GoldPerSymbolType = goldPerSymbolType;
        }

        [DataMember]
        public SymbolType SymbolType
        {
            get;
            private set;
        }

        [DataMember]
        public uint VictoryPointsPerSymbolType
        {
            get;
            private set;
        }

        [DataMember]
        public uint GoldPerSymbolType
        {
            get;
            private set;
        }
    }

    [DataContract]
    public abstract class GuildCardBase : AgeCard, IGuildCard
    {
        public GuildCardBase(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            ApplicableDirection usabilityDirection,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, 0, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        {
            this.UsabilityDirection = usabilityDirection;
        }

        [DataMember]
        public ApplicableDirection UsabilityDirection
        {
            get;
            protected set;
        }
    }

    [DataContract]
    public sealed class GuildRewardPerSymbolCard : GuildCardBase, IGuildRewardPerSymbolCard
    {
        public GuildRewardPerSymbolCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            SymbolType symbolType,
            uint victoryPointsPerSymbolType,
            ApplicableDirection usabilityDirection,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, usabilityDirection, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        {
            this.SymbolType = symbolType;
            this.VictoryPointsPerSymbolType = victoryPointsPerSymbolType;
        }

        [DataMember]
        public SymbolType SymbolType
        {
            get;
            private set;
        }

        [DataMember]
        public uint VictoryPointsPerSymbolType
        {
            get;
            private set;
        }
    }

    [DataContract]
    public sealed class GuildRewardScienceCard : GuildCardBase, IGuildRewardScienceCard
    {
        public GuildRewardScienceCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            ScienceType scienceRewardType,
            ApplicableDirection usabilityDirection,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            IEnumerable<Guid> baseCardId,
            IEnumerable<Guid> derivedCardIds)
            : base(id, age, title, description, minimumNumberOfPlayers, usabilityDirection, rawMaterialResourceCost, manufacturedMaterialResourceCost, baseCardId, derivedCardIds)
        {
            this.ScienceRewardType = scienceRewardType;
        }

        [DataMember]
        public ScienceType ScienceRewardType
        {
            get;
            private set;
        }
    }
}
