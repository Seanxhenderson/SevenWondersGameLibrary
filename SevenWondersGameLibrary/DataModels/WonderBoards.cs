using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
    public abstract class Stage : IStage
    {
        public Stage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
        {
            this.ParentWonderBoardId = parentWonderBoardId;
            this.Level = level;
            this.Description = description;
            this.GoldCost = goldCost;
            this.ManufacturedMaterialResourceCost = manufacturedMaterialResourceCost;
            this.RawMaterialResourceCost = rawMaterialResourceCost;
        }

        public Guid ParentWonderBoardId
        {
            get;
            private set;
        }

        public uint Level
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

        public ManufacturedMaterialResourceCost ManufacturedMaterialResourceCost
        {
            get;
            private set;
        }

        public RawMaterialResourceCost RawMaterialResourceCost
        {
            get;
            private set;
        }
    }

    public class VictoryAwardStage : Stage
    {
        public VictoryAwardStage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            uint victoryPointsAwarded,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
            : base(parentWonderBoardId, level, description, goldCost, manufacturedMaterialResourceCost, rawMaterialResourceCost)
        {
            this.VictoryPointsAwarded = victoryPointsAwarded;
        }

        public uint VictoryPointsAwarded
        {
            get;
            private set;
        }
    }

    public class MilitaryAwardStage : Stage
    {
        public MilitaryAwardStage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            uint militaryPointsAwarded,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
            : base(parentWonderBoardId, level, description, goldCost, manufacturedMaterialResourceCost, rawMaterialResourceCost)
        {
            this.MilitaryPointsAwarded = militaryPointsAwarded;
        }

        public uint MilitaryPointsAwarded
        {
            get;
            private set;
        }
    }

    public class ScienceAwardStage : Stage
    {
        public ScienceAwardStage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            uint sciencePointsAwarded,
            IEnumerable<ScienceType> availableScienceTypes,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
            : base(parentWonderBoardId, level, description, goldCost, manufacturedMaterialResourceCost, rawMaterialResourceCost)
        {
            this.SciencePointsAwarded = sciencePointsAwarded;
            this.AvailableScienceTypes = availableScienceTypes;
        }

        public uint SciencePointsAwarded
        {
            get;
            private set;
        }

        public IEnumerable<ScienceType> AvailableScienceTypes
        {
            get;
            private set;
        }
    }

    public class RawMaterialAwardStage : Stage
    {
        public RawMaterialAwardStage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            uint rawMaterialPointsAwarded,
            IEnumerable<RawMaterialType> availableRawMaterialTypes,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
            : base(parentWonderBoardId, level, description, goldCost, manufacturedMaterialResourceCost, rawMaterialResourceCost)
        {
            this.RawMaterialPointsAwarded = rawMaterialPointsAwarded;
            this.AvailableRawMaterialTypes = availableRawMaterialTypes;
        }

        public uint RawMaterialPointsAwarded
        {
            get;
            private set;
        }

        public IEnumerable<RawMaterialType> AvailableRawMaterialTypes
        {
            get;
            private set;
        }
    }

    public class ManufactoredMaterialAwardStage : Stage
    {
        public ManufactoredMaterialAwardStage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            uint manufactoredMaterialPointsAwarded,
            IEnumerable<ManufactoredMaterialType> availableManufactoredMaterialTypes,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
            : base(parentWonderBoardId, level, description, goldCost, manufacturedMaterialResourceCost, rawMaterialResourceCost)
        {
            this.ManufactoredMaterialPointsAwarded = manufactoredMaterialPointsAwarded;
            this.AvailableManufactoredMaterialTypes = availableManufactoredMaterialTypes;
        }

        public uint ManufactoredMaterialPointsAwarded
        {
            get;
            private set;
        }

        public IEnumerable<ManufactoredMaterialType> AvailableManufactoredMaterialTypes
        {
            get;
            private set;
        }
    }

    public class GoldAwardStage : Stage
    {
        public GoldAwardStage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            uint goldAwarded,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
            : base(parentWonderBoardId, level, description, goldCost, manufacturedMaterialResourceCost, rawMaterialResourceCost)
        {
            this.GoldAwarded = goldAwarded;
        }

        public uint GoldAwarded
        {
            get;
            private set;
        }
    }

    public class TriplePointsAwardStage : Stage
    {
        public TriplePointsAwardStage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            uint goldAwarded,
            uint militaryPointsAwarded,
            uint victoryPointsAwarded,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
            : base(parentWonderBoardId, level, description, goldCost, manufacturedMaterialResourceCost, rawMaterialResourceCost)
        {
            this.GoldAwarded = goldAwarded;
            this.MilitaryPointsAwarded = militaryPointsAwarded;
            this.VictoryPointsAwarded = victoryPointsAwarded;
        }

        public uint GoldAwarded
        {
            get;
            private set;
        }

        public uint MilitaryPointsAwarded
        {
            get;
            private set;
        }

        public uint VictoryPointsAwarded
        {
            get;
            private set;
        }
    }

    public class FreeCardAwardStage : Stage
    {
        public FreeCardAwardStage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            IEnumerable<Age> availableAges,
            uint numberOfCardsPerAge,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
            : base(parentWonderBoardId, level, description, goldCost, manufacturedMaterialResourceCost, rawMaterialResourceCost)
        {
            this.AvailableAges = availableAges;
            this.NumberOfCardsPerAge = numberOfCardsPerAge;
        }

        public IEnumerable<Age> AvailableAges
        {
            get;
            private set;
        }

        public uint NumberOfCardsPerAge
        {
            get;
            private set;
        }
    }

    public class DiscardedCardAwardStage : Stage
    {
        public DiscardedCardAwardStage(
            Guid parentWonderBoardId,
            uint level,
            string description,
            uint numberOfCardsGained,
            uint goldCost,
            ManufacturedMaterialResourceCost manufacturedMaterialResourceCost,
            RawMaterialResourceCost rawMaterialResourceCost)
            : base(parentWonderBoardId, level, description, goldCost, manufacturedMaterialResourceCost, rawMaterialResourceCost)
        {

            this.NumberOfCardsGained = numberOfCardsGained;
        }

        public uint NumberOfCardsGained
        {
            get;
            private set;
        }
    }

    public class WonderBoard : IWonderBoard
    {
        public WonderBoard(Guid id, string name, string description, ResourceToken primaryResource, uint numberOfStages, IEnumerable<IStage> stages)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.PrimaryResource = primaryResource;
            this.NumberOfStages = numberOfStages;
            this.Stages = stages;
        }

        public string Description
        {
            get;
            private set;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public string ImageUrl
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get;
            private set;
        }

        public uint NumberOfStages
        {
            get;
            private set;
        }

        public ResourceToken PrimaryResource
        {
            get;
            private set;
        }

        public IEnumerable<IStage> Stages
        {
            get;
            private set;
        }
    }
}
