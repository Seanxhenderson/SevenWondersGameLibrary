using SevenWondersGameLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary
{
    public class CardFactory
    {
        private Dictionary<Type, IEnumerable<object>> masterDictionary = new Dictionary<Type, IEnumerable<object>>();

        public void PopulateAgeICards()
        {
            // RawMaterial cards
            var rawMaterialCards = new List<IRawMaterialCard>();
            rawMaterialCards.AddRange(GetRawMaterialCards(Age.One));
            rawMaterialCards.AddRange(GetRawMaterialCards(Age.Two));
            rawMaterialCards.AddRange(GetRawMaterialCards(Age.Three));
            masterDictionary.Add(typeof(IRawMaterialCard), rawMaterialCards);

            // ManufacturedMaterial cards
            var manufacturedMaterialCards = new List<IManufacturedMaterialCard>();
            manufacturedMaterialCards.AddRange(GetManufacturedMaterialCards(Age.One));
            manufacturedMaterialCards.AddRange(GetManufacturedMaterialCards(Age.Two));
            manufacturedMaterialCards.AddRange(GetManufacturedMaterialCards(Age.Three));
            masterDictionary.Add(typeof(IManufacturedMaterialCard), manufacturedMaterialCards);

            // Culture cards
            var cultureCards = new List<ICultureCard>();
            cultureCards.AddRange(GetCultureCards(Age.One));
            cultureCards.AddRange(GetCultureCards(Age.Two));
            cultureCards.AddRange(GetCultureCards(Age.Three));
            masterDictionary.Add(typeof(ICultureCard), cultureCards);

            // Military cards
            var militaryCards = new List<IMilitaryCard>();
            militaryCards.AddRange(GetMilitaryCards(Age.One));
            militaryCards.AddRange(GetMilitaryCards(Age.Two));
            militaryCards.AddRange(GetMilitaryCards(Age.Three));
            masterDictionary.Add(typeof(IMilitaryCard), militaryCards);

            // Science cards
            var scienceCards = new List<IScienceCard>();
            scienceCards.AddRange(GetScienceCards(Age.One));
            scienceCards.AddRange(GetScienceCards(Age.Two));
            scienceCards.AddRange(GetScienceCards(Age.Three));
            masterDictionary.Add(typeof(IScienceCard), scienceCards);
        }

        public IEnumerable<IAgeCard> PopulateAgeIICards()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IAgeCard> PopulateAgeIIICards()
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<IRawMaterialCard> GetRawMaterialCards(Age age)
        {
            switch (age)
            {
                case Age.One:
                    return new List<IRawMaterialCard>
                        {
                            // 3+ Players

                            new RawMaterialCard(Age.One,
                                                "Clay Pool",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay) },
                                                0
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Ore Vein",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore) },
                                                0
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Stone Pit",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone) },
                                                0
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Lumber Yard",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood) },
                                                0
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Timber Yard",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood | RawMaterialType.Stone) },
                                                1
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Clay Pit",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay | RawMaterialType.Ore) },
                                                1
                                                ),

                            // 4+ Players

                            new RawMaterialCard(Age.One,
                                                "Ore Vein",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore) },
                                                0
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Lumber Yard",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood) },
                                                0
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Excavation",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone | RawMaterialType.Clay) },
                                                1
                                                ),

                            // 5+ Players

                            new RawMaterialCard(Age.One,
                                                "Clay Pool",
                                                string.Empty,
                                                5,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay) },
                                                0
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Stone Pit",
                                                string.Empty,
                                                5,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone) },
                                                0
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Forest Cave",
                                                string.Empty,
                                                5,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood | RawMaterialType.Ore) },
                                                1
                                                ),

                            // 6+ Players

                            new RawMaterialCard(Age.One,
                                                "Mine",
                                                string.Empty,
                                                6,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone | RawMaterialType.Ore) },
                                                1
                                                ),

                            new RawMaterialCard(Age.One,
                                                "Tree Farm",
                                                string.Empty,
                                                6,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood | RawMaterialType.Clay) },
                                                1
                                                ),
                            // 7+ Players
                        };

                case Age.Two:
                    throw new NotImplementedException();

                case Age.Three:
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();
            }
        }

        private static IEnumerable<IManufacturedMaterialCard> GetManufacturedMaterialCards(Age age)
        {
            switch (age)
            {
                case Age.One:
                    return new List<IManufacturedMaterialCard>
                        {
                            // 3+ Players

                            new ManufacturedGoodCard(Age.One,
                                                     "Loom",
                                                     string.Empty,
                                                     3,
                                                     new ManufacturedMaterialResourceToken[] { ManufacturedMaterialResourceToken.GetUnitToken(ManufacturedMaterialType.Loom) },
                                                     0
                                                     ),

                            new ManufacturedGoodCard(Age.One,
                                                     "Press",
                                                     string.Empty,
                                                     3,
                                                     new ManufacturedMaterialResourceToken[] { ManufacturedMaterialResourceToken.GetUnitToken(ManufacturedMaterialType.Papyrus) },
                                                     0
                                                     ),

                            new ManufacturedGoodCard(Age.One,
                                                     "Classworks",
                                                     string.Empty,
                                                     3,
                                                     new ManufacturedMaterialResourceToken[] { ManufacturedMaterialResourceToken.GetUnitToken(ManufacturedMaterialType.Glass) },
                                                     0
                                                     ),

                            // 4+ Players

                            // 5+ Players

                            // 6+ Players

                            new ManufacturedGoodCard(Age.One,
                                                     "Loom",
                                                     string.Empty,
                                                     6,
                                                     new ManufacturedMaterialResourceToken[] { ManufacturedMaterialResourceToken.GetUnitToken(ManufacturedMaterialType.Loom) },
                                                     0
                                                     ),

                            new ManufacturedGoodCard(Age.One,
                                                     "Press",
                                                     string.Empty,
                                                     6,
                                                     new ManufacturedMaterialResourceToken[] { ManufacturedMaterialResourceToken.GetUnitToken(ManufacturedMaterialType.Papyrus) },
                                                     0
                                                     ),

                            new ManufacturedGoodCard(Age.One,
                                                     "Classworks",
                                                     string.Empty,
                                                     6,
                                                     new ManufacturedMaterialResourceToken[] { ManufacturedMaterialResourceToken.GetUnitToken(ManufacturedMaterialType.Glass) },
                                                     0
                                                     ),

                            // 7+ Players
                        };

                case Age.Two:
                    throw new NotImplementedException();

                case Age.Three:
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();
            }
        }

        private static IEnumerable<ICultureCard> GetCultureCards(Age age)
        {
            switch (age)
            {
                case Age.One:
                    return new List<ICultureCard>
                        {
                            // 3+ Players

                            new CultureCard(Age.One,
                                            "Baths",
                                            string.Empty,
                                            3,
                                            3,
                                            new RawMaterialResourceCost(0,0,1,0),
                                            ManufacturedMaterialResourceCost.Free
                                            ),

                            new CultureCard(Age.One,
                                            "Altar",
                                            string.Empty,
                                            3,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free),

                            new CultureCard(Age.One,
                                            "Theater",
                                            string.Empty,
                                            3,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free),

                            new CultureCard(Age.One,
                                            "Pawnshop",
                                            string.Empty,
                                            4,
                                            3,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free),

                            // 4+ Players

                            new CultureCard(Age.One,
                                            "Altar",
                                            string.Empty,
                                            4,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free),

                            // 5+ Players

                            // 6+ Players

                            new CultureCard(Age.One,
                                            "Theater",
                                            string.Empty,
                                            6,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free),

                            // 7+ Players

                            new CultureCard(Age.One,
                                            "Baths",
                                            string.Empty,
                                            7,
                                            3,
                                            new RawMaterialResourceCost(0,0,1,0),
                                            ManufacturedMaterialResourceCost.Free),

                            new CultureCard(Age.One,
                                            "Pawnshop",
                                            string.Empty,
                                            7,
                                            3,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free)
                        };

                case Age.Two:
                    throw new NotImplementedException();

                case Age.Three:
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();
            }
        }

        private static IEnumerable<IMilitaryCard> GetMilitaryCards(Age age)
        {
            switch (age)
            {
                case Age.One:
                    return new List<IMilitaryCard>
                        {
                            // 3+ Players

                            new MilitaryCard(Age.One,
                                            "Guard Tower",
                                            string.Empty,
                                            3,
                                            1,
                                            new RawMaterialResourceCost(1,0,0,0),
                                            ManufacturedMaterialResourceCost.Free
                                            ),

                            new MilitaryCard(Age.One,
                                            "Stockade",
                                            string.Empty,
                                            3,
                                            1,
                                            new RawMaterialResourceCost(0,0,0,1),
                                            ManufacturedMaterialResourceCost.Free
                                            ),

                            new MilitaryCard(Age.One,
                                            "Barracks",
                                            string.Empty,
                                            3,
                                            1,
                                            new RawMaterialResourceCost(0,1,0,0),
                                            ManufacturedMaterialResourceCost.Free
                                            ),

                            // 4+ Players

                            new MilitaryCard(Age.One,
                                            "Guard Tower",
                                            string.Empty,
                                            4,
                                            1,
                                            new RawMaterialResourceCost(1,0,0,0),
                                            ManufacturedMaterialResourceCost.Free
                                            ),

                            // 5+ Players

                            new MilitaryCard(Age.One,
                                            "Barracks",
                                            string.Empty,
                                            5,
                                            1,
                                            new RawMaterialResourceCost(0,1,0,0),
                                            ManufacturedMaterialResourceCost.Free
                                            ),

                            // 6+ Players

                            // 7+ Players

                            new MilitaryCard(Age.One,
                                            "Stockade",
                                            string.Empty,
                                            7,
                                            1,
                                            new RawMaterialResourceCost(0,0,0,1),
                                            ManufacturedMaterialResourceCost.Free
                                            )
                        };

                case Age.Two:
                    throw new NotImplementedException();

                case Age.Three:
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();
            }
        }

        private static IEnumerable<IScienceCard> GetScienceCards(Age age)
        {
            switch (age)
            {
                case Age.One:
                    return new List<IScienceCard>
                        {
                            // 3+ Players

                            new ScienceCard(Age.One,
                                            "Apothecary",
                                            string.Empty,
                                            3,
                                            ScienceType.Tools,
                                            new ManufacturedMaterialResourceCost(0,1,0)
                                            ),

                            new ScienceCard(Age.One,
                                            "Scriptorium",
                                            string.Empty,
                                            3,
                                            ScienceType.Glyph,
                                            new ManufacturedMaterialResourceCost(0,0,1)
                                            ),

                            new ScienceCard(Age.One,
                                            "Workshop",
                                            string.Empty,
                                            3,
                                            ScienceType.Gear,
                                            new ManufacturedMaterialResourceCost(1,0,0)
                                            ),

                            // 4+ Players

                            new ScienceCard(Age.One,
                                            "Scriptorium",
                                            string.Empty,
                                            4,
                                            ScienceType.Glyph,
                                            new ManufacturedMaterialResourceCost(0,0,1)
                                            ),

                            // 5+ Players

                            new ScienceCard(Age.One,
                                            "Apothecary",
                                            string.Empty,
                                            5,
                                            ScienceType.Tools,
                                            new ManufacturedMaterialResourceCost(0,1,0)
                                            ),

                            // 6+ Players

                            // 7+ Players

                            new ScienceCard(Age.One,
                                            "Workshop",
                                            string.Empty,
                                            7,
                                            ScienceType.Gear,
                                            new ManufacturedMaterialResourceCost(1,0,0)
                                            ),
                        };

                case Age.Two:
                    throw new NotImplementedException();

                case Age.Three:
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
