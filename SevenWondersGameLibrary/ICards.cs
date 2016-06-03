using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary
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

    public abstract class ResourceToken
    {
        public ResourceToken(uint tokenValue)
        {
            this.TokenValue = tokenValue;
        }

        public uint TokenValue { get; private set; }
    }

    public class RawMaterialResourceToken : ResourceToken
    {
        public RawMaterialResourceToken(RawMaterialType type, uint tokenValue)
            : base(tokenValue)
        {
            this.Type = type;
        }

        public RawMaterialType Type { get; private set; }

        public static RawMaterialResourceToken EmptyToken
        {
            get { return null; }
        }

        public static RawMaterialResourceToken UnitClayToken
        {
            get { return new RawMaterialResourceToken(RawMaterialType.Clay, 1); }
        }

        public static RawMaterialResourceToken DoubleClayToken
        {
            get { return new RawMaterialResourceToken(RawMaterialType.Clay, 2); }
        }

        public static RawMaterialResourceToken UnitOreToken
        {
            get { return new RawMaterialResourceToken(RawMaterialType.Ore, 1); }
        }

        public static RawMaterialResourceToken DoubleOreToken
        {
            get { return new RawMaterialResourceToken(RawMaterialType.Ore, 2); }
        }

        public static RawMaterialResourceToken UnitStoneToken
        {
            get { return new RawMaterialResourceToken(RawMaterialType.Stone, 1); }
        }

        public static RawMaterialResourceToken DoubleStoneToken
        {
            get { return new RawMaterialResourceToken(RawMaterialType.Stone, 2); }
        }

        public static RawMaterialResourceToken UnitWoodToken
        {
            get { return new RawMaterialResourceToken(RawMaterialType.Wood, 1); }
        }

        public static RawMaterialResourceToken DoubleWoodToken
        {
            get { return new RawMaterialResourceToken(RawMaterialType.Wood, 2); }
        }
    }

    public class ManufacturedMaterialResourceToken : ResourceToken
    {
        public ManufacturedMaterialResourceToken(ManufacturedMaterialType type, uint tokenValue)
            : base(tokenValue)
        {
            this.Type = type;
        }

        public ManufacturedMaterialType Type { get; private set; }

        public static ManufacturedMaterialResourceToken EmptyToken
        {
            get { return null; }
        }

        public static ManufacturedMaterialResourceToken UnitGlassToken
        {
            get { return new ManufacturedMaterialResourceToken(ManufacturedMaterialType.Glass, 1); }
        }

        public static ManufacturedMaterialResourceToken DoubleGlassToken
        {
            get { return new ManufacturedMaterialResourceToken(ManufacturedMaterialType.Glass, 2); }
        }

        public static ManufacturedMaterialResourceToken UnitLoomToken
        {
            get { return new ManufacturedMaterialResourceToken(ManufacturedMaterialType.Loom, 1); }
        }

        public static ManufacturedMaterialResourceToken DoubleLoomToken
        {
            get { return new ManufacturedMaterialResourceToken(ManufacturedMaterialType.Loom, 2); }
        }

        public static ManufacturedMaterialResourceToken UnitPapyrusToken
        {
            get { return new ManufacturedMaterialResourceToken(ManufacturedMaterialType.Papyrus, 1); }
        }

        public static ManufacturedMaterialResourceToken DoublePapyrusToken
        {
            get { return new ManufacturedMaterialResourceToken(ManufacturedMaterialType.Papyrus, 2); }
        }
    }

    public class RawMaterialResourceCost : IEnumerable<RawMaterialResourceToken>
    {
        private List<RawMaterialResourceToken> resourceTokens = null;

        private RawMaterialResourceCost()
            : this(0,0,0,0)
        {
        }

        public RawMaterialResourceCost(uint clayCost, uint oreCost, uint stoneCost, uint woodCost)
        {
            this.resourceTokens = new List<RawMaterialResourceToken>
            {
                new RawMaterialResourceToken(RawMaterialType.Clay, clayCost),
                new RawMaterialResourceToken(RawMaterialType.Ore, oreCost),
                new RawMaterialResourceToken(RawMaterialType.Stone, stoneCost),
                new RawMaterialResourceToken(RawMaterialType.Wood, woodCost)
            };
        }
    
        public RawMaterialResourceToken this[int index]
        {
            get { return resourceTokens[index]; }
            set { resourceTokens.Insert(index, value); }
        }

        public static RawMaterialResourceCost Free
        {
            get { return new RawMaterialResourceCost(); }
        }

        public bool IsFree
        {
            get
            {
                return (this.Sum((token) => { return token.TokenValue; }) == 0);
            }
        }

        public IEnumerator<RawMaterialResourceToken> GetEnumerator()
        {
            return resourceTokens.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    public class ManufacturedMaterialResourceCost : IEnumerable<ManufacturedMaterialResourceToken>
    {
        private List<ManufacturedMaterialResourceToken> resourceTokens = null;

        private ManufacturedMaterialResourceCost()
            : this(0, 0, 0)
        {
        }

        public ManufacturedMaterialResourceCost(uint glassCost, uint loomCost, uint papyrusCost)
        {
            this.resourceTokens = new List<ManufacturedMaterialResourceToken>
            {
                new ManufacturedMaterialResourceToken(ManufacturedMaterialType.Glass, glassCost),
                new ManufacturedMaterialResourceToken(ManufacturedMaterialType.Loom, loomCost),
                new ManufacturedMaterialResourceToken(ManufacturedMaterialType.Papyrus, papyrusCost)
            };
        }

        public ManufacturedMaterialResourceToken this[int index]
        {
            get { return resourceTokens[index]; }
            set { resourceTokens.Insert(index, value); }
        }

        public static ManufacturedMaterialResourceCost Free
        {
            get { return new ManufacturedMaterialResourceCost(); }
        }

        public bool IsFree
        {
            get
            {
                return (this.Sum((token) => { return token.TokenValue; }) == 0);
            }
        }

        public IEnumerator<ManufacturedMaterialResourceToken> GetEnumerator()
        {
            return resourceTokens.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

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

        // TODO: processed resource cost

        uint GoldCost { get; }

        IAgeCard ParentCard { get; }

        IEnumerable<IAgeCard> ChildCards { get; }

        uint MinimumNumberOfPlayers { get; }
    }

    public interface IRawMaterialCard : IAgeCard
    {
        RawMaterialType ResourceType { get; }

        uint Amount { get; }
    }

    public interface IManufacturedGoodCard : IAgeCard
    {
        ManufacturedMaterialType ResourceType { get; }

        uint Amount { get; }
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
