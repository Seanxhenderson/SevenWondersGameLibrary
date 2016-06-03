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
        }

        private static IEnumerable<ICultureCard> GetCultureCards(Age age)
        {
            switch (age)
            {
                case Age.One:
                    return new List<ICultureCard>
                        {
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

                            new CultureCard(Age.One,
                                            "Altar",
                                            string.Empty,
                                            4,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free),

                            new CultureCard(Age.One,
                                            "Theater",
                                            string.Empty,
                                            6,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free),

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

                            new MilitaryCard(Age.One,
                                            "Guard Tower",
                                            string.Empty,
                                            4,
                                            1,
                                            new RawMaterialResourceCost(1,0,0,0),
                                            ManufacturedMaterialResourceCost.Free
                                            ),

                            new MilitaryCard(Age.One,
                                            "Barracks",
                                            string.Empty,
                                            5,
                                            1,
                                            new RawMaterialResourceCost(0,1,0,0),
                                            ManufacturedMaterialResourceCost.Free
                                            ),

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

        public IEnumerable<IAgeCard> PopulateAgeIICards()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IAgeCard> PopulateAgeIIICards()
        {
            throw new NotImplementedException();
        }
    }
}
