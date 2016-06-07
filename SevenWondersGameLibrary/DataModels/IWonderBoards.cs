using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
    public interface IStage
    {
        Guid ParentWonderBoardId { get; }

        uint Level { get; }
   
        string Description { get; }

        RawMaterialResourceCost RawMaterialResourceCost { get; }

        ManufacturedMaterialResourceCost ManufacturedMaterialResourceCost { get; }

        uint GoldCost { get; }
    }

    public interface IWonderBoard
    {
        Guid Id { get; }

        string Name { get; }

        string Description { get; }

        string ImageUrl { get; }

        IEnumerable<IStage> Stages { get; }

        uint NumberOfStages { get; }

        ResourceToken PrimaryResource { get; }
    }
}
