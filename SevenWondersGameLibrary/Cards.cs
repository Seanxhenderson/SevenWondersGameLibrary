using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary
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

    //public sealed class RawMaterialCard : AgeCard, IRawMaterialCard
    //{
    //    public uint Amount
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public RawMaterialType ResourceType
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}

    //public sealed class ManufacturedGoodCard : AgeCard, IManufacturedGoodCard
    //{
    //    public uint Amount
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public ManufacturedGoodType ResourceType
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}

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
}
