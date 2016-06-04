﻿using System;
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
            Age age, 
            string title, 
            string description, 
            uint minimumNumberOfPlayers, 
            uint goldCost, 
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost)
        {
            this.Age = age;
            this.Title = title;
            this.Description = description;
            this.MinimumNumberOfPlayers = minimumNumberOfPlayers;
            this.GoldCost = goldCost;
            this.RawMaterialResourceCost = rawMaterialResourceCost;
            this.ManufacturedMaterialResourceCost = manufacturedMaterialResourceCost;
        }

        public Age Age
        {
            get;
            private set;
        }

        public IEnumerable<IAgeCard> ChildCards
        {
            get
            {
                throw new NotImplementedException();
            }
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

        public IAgeCard ParentCard
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
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            IEnumerable<RawMaterialResourceToken> resources,
            uint goldCost)
            : base(age, title, description, minimumNumberOfPlayers, goldCost, RawMaterialResourceCost.Free, ManufacturedMaterialResourceCost.Free)
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
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            IEnumerable<ManufactoredMaterialResourceToken> resources,
            uint goldCost)
            : base(age, title, description, minimumNumberOfPlayers, goldCost, RawMaterialResourceCost.Free, ManufacturedMaterialResourceCost.Free)
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
            Age age, 
            string title, 
            string description, 
            uint minimumNumberOfPlayers, 
            uint victoryValue,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost)
            : base(age, title, description, minimumNumberOfPlayers, 0, rawMaterialResourceCost, manufacturedMaterialResourceCost)
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
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            uint militaryValue,
            RawMaterialResourceCost rawMaterialResourceCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost)
            : base(age, title, description, minimumNumberOfPlayers, 0, rawMaterialResourceCost, manufacturedMaterialResourceCost)
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
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            ScienceType scienceType,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost)
            : base(age, title, description, minimumNumberOfPlayers, 0, RawMaterialResourceCost.Free, manufacturedMaterialResourceCost)
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
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            ApplicableDirection usabilityDirection)
            : base(age, title, description, minimumNumberOfPlayers, 0, RawMaterialResourceCost.Free, ManufacturedMaterialResourceCost.Free)
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
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            uint discountValue,
            IEnumerable<RawMaterialResourceToken> rawMaterialTokens,
            ApplicableDirection usabilityDirection)
            : base(age, title, description, minimumNumberOfPlayers, usabilityDirection)
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
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            uint discountValue,
            IEnumerable<ManufactoredMaterialResourceToken> manufactoredMaterialTokens,
            ApplicableDirection usabilityDirection)
            : base(age, title, description, minimumNumberOfPlayers, usabilityDirection)
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
            Age age,
            string title,
            string description,
            uint minimumNumberOfPlayers,
            uint goldValue,
            ApplicableDirection usabilityDirection)
            : base(age, title, description, minimumNumberOfPlayers, usabilityDirection)
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
