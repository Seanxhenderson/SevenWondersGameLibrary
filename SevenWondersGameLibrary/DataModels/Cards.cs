using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
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
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost)
        {
            this.Id = id;
            this.Age = age;
            this.Title = title;
            this.Description = description;
            this.MinimumNumberOfPlayers = minimumNumberOfPlayers;
            this.GoldCost = goldCost;
            this.RawMaterialResourceCost = rawMaterialResourceCost;
            this.ManufacturedMaterialResourceCost = manufacturedMaterialResourceCost;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public Age Age
        {
            get;
            private set;
        }

        public string Description
        {
            get;
            private set;
        }

        public uint GoldCost
        {
            get;
            private set;
        }

        public string ImageUrl
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public uint MinimumNumberOfPlayers
        {
            get;
            private set;
        }

        public IAgeCard PreviousStageCard
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IAgeCard> NextStageCards
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public RawMaterialResourceCost RawMaterialResourceCost
        {
            get;
            private set;
        }

        public ManufacturedMaterialResourceCost ManufacturedMaterialResourceCost
        {
            get;
            private set;
        }

        public string Title
        {
            get;
            private set;
        }
    }

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
            : base(id, age, title, description, minimumNumberOfPlayers, goldCost, RawMaterialResourceCost.Free, ManufacturedMaterialResourceCost.Free)
        {
            this.Resources = resources;
        }

        public IEnumerable<RawMaterialResourceToken> Resources
        {
            get;
            private set;
        }
    }

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
            : base(id, age, title, description, minimumNumberOfPlayers, goldCost, RawMaterialResourceCost.Free, ManufacturedMaterialResourceCost.Free)
        {
            this.Resources = resources;
        }

        public IEnumerable<ManufactoredMaterialResourceToken> Resources 
        {
            get;
            private set;
        }
    }

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
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost)
            : base(id, age, title, description, minimumNumberOfPlayers, 0, rawMaterialResourceCost, manufacturedMaterialResourceCost)
        {
            this.VictoryValue = victoryValue;
        }

        public uint VictoryValue
        {
            get;
            private set;
        }
    }

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
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost)
            : base(id, age, title, description, minimumNumberOfPlayers, 0, rawMaterialResourceCost, manufacturedMaterialResourceCost)
        {
            this.MilitaryValue = militaryValue;
        }

        public uint MilitaryValue
        {
            get;
            private set;
        }
    }

    public sealed class ScienceCard : AgeCard, IScienceCard
    {
        public ScienceCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            ScienceType scienceType,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost)
            : base(id, age, title, description, minimumNumberOfPlayers, 0, RawMaterialResourceCost.Free, manufacturedMaterialResourceCost)
        {
            this.ScienceType = scienceType;
        }

        public ScienceType ScienceType
        {
            get;
            private set;
        }
    }

    public abstract class CommerceCardBase : AgeCard, ICommerceCard
    {
        public CommerceCardBase(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            ApplicableDirection usabilityDirection)
            : base(id, age, title, description, minimumNumberOfPlayers, 0, RawMaterialResourceCost.Free, ManufacturedMaterialResourceCost.Free)
        {
            this.UsabilityDirection = usabilityDirection;
        }

        public ApplicableDirection UsabilityDirection
        {
            get;
            protected set;
        }
    }

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
            ApplicableDirection usabilityDirection)
            : base(id, age, title, description, minimumNumberOfPlayers, usabilityDirection)
        {
            this.DiscountedCost = discountValue;
            this.RawMaterialTokens = rawMaterialTokens;
        }

        public uint DiscountedCost
        {
            get;
            private set;
        }

        public IEnumerable<RawMaterialResourceToken> RawMaterialTokens
        {
            get;
            private set;
        }
    }

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
            ApplicableDirection usabilityDirection)
            : base(id, age, title, description, minimumNumberOfPlayers, usabilityDirection)
        {
            this.DiscountedCost = discountValue;
            this.ManufactoredMaterialTokens = manufactoredMaterialTokens;
        }

        public uint DiscountedCost
        {
            get;
            private set;
        }

        public IEnumerable<ManufactoredMaterialResourceToken> ManufactoredMaterialTokens
        {
            get;
            private set;
        }
    }

    public sealed class CommerceGoldCard : CommerceCardBase, ICommerceGoldCard
    {
        public CommerceGoldCard(
            Guid id,
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            uint goldValue,
            ApplicableDirection usabilityDirection)
            : base(id, age, title, description, minimumNumberOfPlayers, usabilityDirection)
        {
            this.GoldValue = goldValue;
        }

        public uint GoldValue
        {
            get;
            private set;
        }
    }
}
