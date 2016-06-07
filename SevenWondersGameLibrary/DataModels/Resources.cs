using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
    public abstract class ResourceToken
    {
        public ResourceToken(uint tokenValue)
        {
            this.TokenValue = tokenValue;
            this.AvaliableForUse = true;
        }

        public uint TokenValue { get; private set; }

        public bool AvaliableForUse { get; set; }
    }

    public class RawMaterialResourceToken : ResourceToken
    {
        public RawMaterialResourceToken(RawMaterialType type, uint tokenValue)
            : base(tokenValue)
        {
            this.Type = type;
        }

        public RawMaterialType Type { get; private set; }

        public static RawMaterialResourceToken GetUnitToken(RawMaterialType type)
        {
            return new RawMaterialResourceToken(type, 1);
        }

        public static RawMaterialResourceToken GetDoubleToken(RawMaterialType type)
        {
            return new RawMaterialResourceToken(type, 2);
        }
    }

    public class ManufactoredMaterialResourceToken : ResourceToken
    {
        public ManufactoredMaterialResourceToken(ManufactoredMaterialType type, uint tokenValue)
            : base(tokenValue)
        {
            this.Type = type;
        }

        public ManufactoredMaterialType Type { get; private set; }

        public static ManufactoredMaterialResourceToken GetUnitToken(ManufactoredMaterialType type)
        {
            return new ManufactoredMaterialResourceToken(type, 1);
        }

        public static ManufactoredMaterialResourceToken GetDoubleToken(ManufactoredMaterialType type)
        {
            return new ManufactoredMaterialResourceToken(type, 2);
        }
    }

    public class GoldResourceToken : ResourceToken
    {
        public GoldResourceToken(uint tokenValue)
            : base(tokenValue)
        {
        }

        public static GoldResourceToken GetUnitToken()
        {
            return new GoldResourceToken(1);
        }

        public static GoldResourceToken GetDoubleToken()
        {
            return new GoldResourceToken(2);
        }
    }

    public class RawMaterialResourceCost : IEnumerable<RawMaterialResourceToken>
    {
        private List<RawMaterialResourceToken> resourceTokens = null;

        private RawMaterialResourceCost()
            : this(0, 0, 0, 0)
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

    public class ManufacturedMaterialResourceCost : IEnumerable<ManufactoredMaterialResourceToken>
    {
        private List<ManufactoredMaterialResourceToken> resourceTokens = null;

        private ManufacturedMaterialResourceCost()
            : this(0, 0, 0)
        {
        }

        public ManufacturedMaterialResourceCost(uint glassCost, uint loomCost, uint papyrusCost)
        {
            this.resourceTokens = new List<ManufactoredMaterialResourceToken>
            {
                new ManufactoredMaterialResourceToken(ManufactoredMaterialType.Glass, glassCost),
                new ManufactoredMaterialResourceToken(ManufactoredMaterialType.Loom, loomCost),
                new ManufactoredMaterialResourceToken(ManufactoredMaterialType.Papyrus, papyrusCost)
            };
        }

        public ManufactoredMaterialResourceToken this[int index]
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

        public IEnumerator<ManufactoredMaterialResourceToken> GetEnumerator()
        {
            return resourceTokens.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
