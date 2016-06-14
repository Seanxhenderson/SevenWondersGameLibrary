using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
    [DataContract]
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

        [DataMember]
        public Guid ParentWonderBoardId
        {
            get;
            private set;
        }

        [DataMember]
        public uint Level
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
        public ManufacturedMaterialResourceCost ManufacturedMaterialResourceCost
        {
            get;
            private set;
        }

        [DataMember]
        public RawMaterialResourceCost RawMaterialResourceCost
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public uint VictoryPointsAwarded
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public uint MilitaryPointsAwarded
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public uint SciencePointsAwarded
        {
            get;
            private set;
        }

        [DataMember]
        public IEnumerable<ScienceType> AvailableScienceTypes
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public uint RawMaterialPointsAwarded
        {
            get;
            private set;
        }

        [DataMember]
        public IEnumerable<RawMaterialType> AvailableRawMaterialTypes
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public uint ManufactoredMaterialPointsAwarded
        {
            get;
            private set;
        }

        [DataMember]
        public IEnumerable<ManufactoredMaterialType> AvailableManufactoredMaterialTypes
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public uint GoldAwarded
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public uint GoldAwarded
        {
            get;
            private set;
        }

        [DataMember]
        public uint MilitaryPointsAwarded
        {
            get;
            private set;
        }

        [DataMember]
        public uint VictoryPointsAwarded
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public IEnumerable<Age> AvailableAges
        {
            get;
            private set;
        }

        [DataMember]
        public uint NumberOfCardsPerAge
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public uint NumberOfCardsGained
        {
            get;
            private set;
        }
    }

    [DataContract]
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

        [DataMember]
        public string Description
        {
            get;
            private set;
        }

        [DataMember]
        public Guid Id
        {
            get;
            private set;
        }

        [DataMember]
        public string ImageUrl
        {
            get { throw new NotImplementedException(); }
        }

        [DataMember]
        public string Name
        {
            get;
            private set;
        }

        [DataMember]
        public uint NumberOfStages
        {
            get;
            private set;
        }

        [DataMember]
        public ResourceToken PrimaryResource
        {
            get;
            private set;
        }

        [DataMember]
        public IEnumerable<IStage> Stages
        {
            get;
            private set;
        }
    }
}
