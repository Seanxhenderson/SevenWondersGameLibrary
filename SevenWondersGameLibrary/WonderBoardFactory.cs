using SevenWondersGameLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary
{
    public static class WonderBoardFactory
    {
        public static IEnumerable<IWonderBoard> PopulateWonderBoards()
        {
            List<IWonderBoard> wonderBoards = new List<IWonderBoard>()
            {
                // [Guid("D1A467DE-578B-4C5A-A5D6-5DAB120B22FF")]
                new WonderBoard(new Guid("D1A467DE-578B-4C5A-A5D6-5DAB120B22FF"),
                                "Rhodos",
                                "The Colossus of Rhodes",
                                RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                3,
                                new List<Stage>
                                {
                                    new VictoryAwardStage(new Guid("D1A467DE-578B-4C5A-A5D6-5DAB120B22FF"),
                                                          1,
                                                          "",
                                                          3,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,0,0,2)
                                                          ),
                                    new MilitaryAwardStage(new Guid("D1A467DE-578B-4C5A-A5D6-5DAB120B22FF"),
                                                           2,
                                                           "",
                                                           2,
                                                           0,
                                                           ManufacturedMaterialResourceCost.Free,
                                                           new RawMaterialResourceCost(3,0,0,0)
                                                           ),
                                    new VictoryAwardStage(new Guid("D1A467DE-578B-4C5A-A5D6-5DAB120B22FF"),
                                                          3,
                                                          "",
                                                          7,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,4,0,0)
                                                          )
                                }
                                ),

                // [Guid("545B9F1F-50D1-445A-A7F7-66883A9AE9BD")]
                new WonderBoard(new Guid("545B9F1F-50D1-445A-A7F7-66883A9AE9BD"),
                                "Alexandria",
                                "The Lighthouse of Alexandria",
                                ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass),
                                3,
                                new List<Stage>
                                {
                                    new VictoryAwardStage(new Guid("545B9F1F-50D1-445A-A7F7-66883A9AE9BD"),
                                                          1,
                                                          "",
                                                          3,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,0,2,0)
                                                          ),
                                    new RawMaterialAwardStage(new Guid("545B9F1F-50D1-445A-A7F7-66883A9AE9BD"),
                                                              2,
                                                              "",
                                                              1,
                                                              new RawMaterialType[] { RawMaterialType.Clay, RawMaterialType.Ore, RawMaterialType.Stone, RawMaterialType.Wood },
                                                              0,
                                                              ManufacturedMaterialResourceCost.Free,
                                                              new RawMaterialResourceCost(3,0,0,0)
                                                              ),
                                    new VictoryAwardStage(new Guid("545B9F1F-50D1-445A-A7F7-66883A9AE9BD"),
                                                          3,
                                                          "",
                                                          7,
                                                          0,
                                                          new ManufacturedMaterialResourceCost(2,0,0),
                                                          RawMaterialResourceCost.Free
                                                          )
                                }
                                ),

                // [Guid("120086E2-3BA6-455C-8086-B7DB16447817")]
                new WonderBoard(new Guid("120086E2-3BA6-455C-8086-B7DB16447817"),
                                "Ephesus",
                                "The Temple of Artemis in Ephesus",
                                ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus),
                                3,
                                new List<Stage>
                                {
                                    new VictoryAwardStage(new Guid("120086E2-3BA6-455C-8086-B7DB16447817"),
                                                          1,
                                                          "",
                                                          3,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,0,2,0)
                                                          ),
                                    new GoldAwardStage(new Guid("120086E2-3BA6-455C-8086-B7DB16447817"),
                                                       2,
                                                       "",
                                                       9,
                                                       0,
                                                       ManufacturedMaterialResourceCost.Free,
                                                       new RawMaterialResourceCost(0,0,0,2)
                                                       ),
                                    new VictoryAwardStage(new Guid("120086E2-3BA6-455C-8086-B7DB16447817"),
                                                          3,
                                                          "",
                                                          7,
                                                          0,
                                                          new ManufacturedMaterialResourceCost(0,0,2),
                                                          RawMaterialResourceCost.Free
                                                          )
                                }
                                ),

                // [Guid("B3FB9EF7-36A7-47FA-BE22-2B4060E55A73")]
                new WonderBoard(new Guid("B3FB9EF7-36A7-47FA-BE22-2B4060E55A73"),
                                "Babylon",
                                "The Hanging Gardens of Babylon",
                                RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                3,
                                new List<Stage>
                                {
                                    new VictoryAwardStage(new Guid("B3FB9EF7-36A7-47FA-BE22-2B4060E55A73"),
                                                          1,
                                                          "",
                                                          3,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(2,0,0,0)
                                                          ),
                                    new ScienceAwardStage(new Guid("B3FB9EF7-36A7-47FA-BE22-2B4060E55A73"),
                                                          2,
                                                          "",
                                                          1,
                                                          new ScienceType[] { ScienceType.Gear, ScienceType.Glyph, ScienceType.Tools },
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,0,0,3)
                                                          ),
                                    new VictoryAwardStage(new Guid("B3FB9EF7-36A7-47FA-BE22-2B4060E55A73"),
                                                          3,
                                                          "",
                                                          7,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(4,0,0,0)
                                                          )
                                }
                                ),

                // [Guid("6C0865C2-E20D-408C-A732-CAC1E7BE66B2")]
                new WonderBoard(new Guid("6C0865C2-E20D-408C-A732-CAC1E7BE66B2"),
                                "Olympia",
                                "The Statue of Zeus in Olympia",
                                RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood),
                                3,
                                new List<Stage>
                                {
                                    new VictoryAwardStage(new Guid("6C0865C2-E20D-408C-A732-CAC1E7BE66B2"),
                                                          1,
                                                          "",
                                                          3,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,0,0,2)
                                                          ),
                                    new FreeCardAwardStage(new Guid("6C0865C2-E20D-408C-A732-CAC1E7BE66B2"),
                                                           2,
                                                           "",
                                                           new Age[] { Age.One, Age.Two, Age.Three },
                                                           1,
                                                           0,
                                                           ManufacturedMaterialResourceCost.Free,
                                                           new RawMaterialResourceCost(0,0,2,0)
                                                           ),
                                    new VictoryAwardStage(new Guid("6C0865C2-E20D-408C-A732-CAC1E7BE66B2"),
                                                          3,
                                                          "",
                                                          7,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,2,0,0)
                                                          )
                                }
                                ),

                // [Guid("5069F1E5-08D4-484C-8E5E-EF832A3FCE65")]
                new WonderBoard(new Guid("5069F1E5-08D4-484C-8E5E-EF832A3FCE65"),
                                "Halikarnassos",
                                "The Mausoleum of Halicarnassus",
                                ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom),
                                3,
                                new List<Stage>
                                {
                                    new VictoryAwardStage(new Guid("5069F1E5-08D4-484C-8E5E-EF832A3FCE65"),
                                                          1,
                                                          "",
                                                          3,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(2,0,0,0)
                                                          ),
                                    new DiscardedCardAwardStage(new Guid("5069F1E5-08D4-484C-8E5E-EF832A3FCE65"),
                                                                2,
                                                                "",
                                                                1,
                                                                0,
                                                                ManufacturedMaterialResourceCost.Free,
                                                                new RawMaterialResourceCost(0,3,0,0)
                                                                ),
                                    new VictoryAwardStage(new Guid("5069F1E5-08D4-484C-8E5E-EF832A3FCE65"),
                                                          3,
                                                          "",
                                                          7,
                                                          0,
                                                          new ManufacturedMaterialResourceCost(0,2,0),
                                                          RawMaterialResourceCost.Free
                                                          )
                                }
                                ),


                // [Guid("D57DB153-4273-4C87-8B4A-B76190584CDE")]
                new WonderBoard(new Guid("D57DB153-4273-4C87-8B4A-B76190584CDE"),
                                "Gizah",
                                "The Pyramids of Giza",
                                RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                3,
                                new List<Stage>
                                {
                                    new VictoryAwardStage(new Guid("D57DB153-4273-4C87-8B4A-B76190584CDE"),
                                                          1,
                                                          "",
                                                          3,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,0,2,0)
                                                          ),
                                    new VictoryAwardStage(new Guid("D57DB153-4273-4C87-8B4A-B76190584CDE"),
                                                          2,
                                                          "",
                                                          5,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,0,0,3)
                                                          ),
                                    new VictoryAwardStage(new Guid("D57DB153-4273-4C87-8B4A-B76190584CDE"),
                                                          3,
                                                          "",
                                                          7,
                                                          0,
                                                          ManufacturedMaterialResourceCost.Free,
                                                          new RawMaterialResourceCost(0,0,4,0)
                                                          )
                                }
                                )
            };

            return wonderBoards;
        }

    }
}
