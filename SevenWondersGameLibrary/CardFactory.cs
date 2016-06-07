using SevenWondersGameLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary
{
    public static class CardFactory
    {
        public static Dictionary<Type, IEnumerable<object>> PopulateAgeICards()
        {
            Dictionary<Type, IEnumerable<object>> masterDictionary = new Dictionary<Type, IEnumerable<object>>();

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

            // Commerce cards
            var commerceCards = new List<ICommerceCard>();
            commerceCards.AddRange(GetCommerceCards(Age.One));
            commerceCards.AddRange(GetCommerceCards(Age.Two));
            commerceCards.AddRange(GetCommerceCards(Age.Three));
            masterDictionary.Add(typeof(ICommerceCard), commerceCards);

            return masterDictionary;
        }

        public static Dictionary<Type, IEnumerable<object>> PopulateAgeIICards()
        {
            throw new NotImplementedException();
        }

        public static Dictionary<Type, IEnumerable<object>> PopulateAgeIIICards()
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

                            // [Guid("B641FEE1-09B1-4F96-9263-77F02207EAC0")]
                            new RawMaterialCard(new Guid("B641FEE1-09B1-4F96-9263-77F02207EAC0"),
                                                Age.One,
                                                "Clay Pool",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay) },
                                                0
                                                ),

                            // [Guid("34C1474A-4E2C-419D-AD78-FE03E503C55F")]
                            new RawMaterialCard(new Guid("34C1474A-4E2C-419D-AD78-FE03E503C55F"),
                                                Age.One,
                                                "Ore Vein",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore) },
                                                0
                                                ),

                            // [Guid("29B8C759-2EF0-46B7-8E96-AAB9F370713D")]
                            new RawMaterialCard(new Guid("29B8C759-2EF0-46B7-8E96-AAB9F370713D"),
                                                Age.One,
                                                "Stone Pit",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone) },
                                                0
                                                ),

                            // [Guid("7F8C64D4-248D-46DC-8844-30F92C4D149C")]
                            new RawMaterialCard(new Guid("7F8C64D4-248D-46DC-8844-30F92C4D149C"),
                                                Age.One,
                                                "Lumber Yard",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood) },
                                                0
                                                ),

                            // [Guid("9B63055B-FD4E-4DB5-8E04-FFF449B91A18")]
                            new RawMaterialCard(new Guid("9B63055B-FD4E-4DB5-8E04-FFF449B91A18"),
                                                Age.One,
                                                "Timber Yard",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood | RawMaterialType.Stone) },
                                                1
                                                ),

                            // [Guid("11AC4FF0-AFD2-4C0A-AAC9-2D4662E0A9FF")]
                            new RawMaterialCard(new Guid("11AC4FF0-AFD2-4C0A-AAC9-2D4662E0A9FF"),
                                                Age.One,
                                                "Clay Pit",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay | RawMaterialType.Ore) },
                                                1
                                                ),

                            // 4+ Players

                            // [Guid("599CA9E0-7B29-458A-96BE-C6DC555D69DC")]
                            new RawMaterialCard(new Guid("599CA9E0-7B29-458A-96BE-C6DC555D69DC"),
                                                Age.One,
                                                "Ore Vein",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore) },
                                                0
                                                ),

                            // [Guid("11A77ADE-7BBB-41F9-AA12-D8B3F9785AE4")]
                            new RawMaterialCard(new Guid("11A77ADE-7BBB-41F9-AA12-D8B3F9785AE4"),
                                                Age.One,
                                                "Lumber Yard",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood) },
                                                0
                                                ),

                            // [Guid("F4A33E8B-CE82-4CBA-BC82-15D65110CD74")]
                            new RawMaterialCard(new Guid("F4A33E8B-CE82-4CBA-BC82-15D65110CD74"),
                                                Age.One,
                                                "Excavation",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone | RawMaterialType.Clay) },
                                                1
                                                ),

                            // 5+ Players

                            // [Guid("D108F412-C1C1-4C49-A1AA-3990DB08C4A9")]
                            new RawMaterialCard(new Guid("D108F412-C1C1-4C49-A1AA-3990DB08C4A9"),
                                                Age.One,
                                                "Clay Pool",
                                                string.Empty,
                                                5,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay) },
                                                0
                                                ),

                            // [Guid("77A22B31-647C-4912-8719-FAE0AE430D64")]
                            new RawMaterialCard(new Guid("77A22B31-647C-4912-8719-FAE0AE430D64"),
                                                Age.One,
                                                "Stone Pit",
                                                string.Empty,
                                                5,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone) },
                                                0
                                                ),

                            // [Guid("7202550E-97DF-4351-AF51-10D40201527F")]
                            new RawMaterialCard(new Guid("7202550E-97DF-4351-AF51-10D40201527F"),
                                                Age.One,
                                                "Forest Cave",
                                                string.Empty,
                                                5,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood | RawMaterialType.Ore) },
                                                1
                                                ),

                            // 6+ Players

                            // [Guid("B5CD9B61-097E-4663-9C31-EAF1745980B0")]
                            new RawMaterialCard(new Guid("B5CD9B61-097E-4663-9C31-EAF1745980B0"),
                                                Age.One,
                                                "Mine",
                                                string.Empty,
                                                6,
                                                new RawMaterialResourceToken[] { RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone | RawMaterialType.Ore) },
                                                1
                                                ),

                            // [Guid("358008D1-97DA-4417-A99A-EDDE314F292C")]
                            new RawMaterialCard(new Guid("358008D1-97DA-4417-A99A-EDDE314F292C"),
                                                Age.One,
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

                            // [Guid("E610E2E7-F30A-4FDB-8DAB-00E0D8C6A6D6")]
                            new ManufacturedGoodCard(new Guid("E610E2E7-F30A-4FDB-8DAB-00E0D8C6A6D6"),
                                                     Age.One,
                                                     "Loom",
                                                     string.Empty,
                                                     3,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom) },
                                                     0
                                                     ),

                            // [Guid("61A08FF8-C905-4259-83CD-A0E4D66AE12B")]
                            new ManufacturedGoodCard(new Guid("61A08FF8-C905-4259-83CD-A0E4D66AE12B"),
                                                     Age.One,
                                                     "Press",
                                                     string.Empty,
                                                     3,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus) },
                                                     0
                                                     ),

                            // [Guid("54F7A0D8-A5FC-45F4-9E88-E885E44CCBC1")]
                            new ManufacturedGoodCard(new Guid("54F7A0D8-A5FC-45F4-9E88-E885E44CCBC1"),
                                                     Age.One,
                                                     "Classworks",
                                                     string.Empty,
                                                     3,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass) },
                                                     0
                                                     ),

                            // 4+ Players

                            // 5+ Players

                            // 6+ Players

                            // [Guid("05D7304F-80DA-48C7-90F4-2E00475CA4F8")]
                            new ManufacturedGoodCard(new Guid("05D7304F-80DA-48C7-90F4-2E00475CA4F8"),
                                                     Age.One,
                                                     "Loom",
                                                     string.Empty,
                                                     6,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom) },
                                                     0
                                                     ),

                            // [Guid("1B529178-81CD-4FC8-B6CE-86DE5C625521")]
                            new ManufacturedGoodCard(new Guid("1B529178-81CD-4FC8-B6CE-86DE5C625521"),
                                                     Age.One,
                                                     "Press",
                                                     string.Empty,
                                                     6,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus) },
                                                     0
                                                     ),

                            // [Guid("C2EDCFA8-3892-4488-922C-DD1F5AF55432")]
                            new ManufacturedGoodCard(new Guid("C2EDCFA8-3892-4488-922C-DD1F5AF55432"),
                                                     Age.One,
                                                     "Classworks",
                                                     string.Empty,
                                                     6,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass) },
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

                            // [Guid("1343C1C1-A58F-4E18-B1ED-E607253E8B53")]
                            new CultureCard(new Guid("1343C1C1-A58F-4E18-B1ED-E607253E8B53"),
                                            Age.One,
                                            "Baths",
                                            string.Empty,
                                            3,
                                            3,
                                            new RawMaterialResourceCost(0,0,1,0),
                                            ManufacturedMaterialResourceCost.Free,
                                            null,
                                            new Guid[] { new Guid() }
                                            ),

                            // [Guid("5DBC3B9A-DAD1-42AF-87D7-FFA7543E28FF")]
                            new CultureCard(new Guid("5DBC3B9A-DAD1-42AF-87D7-FFA7543E28FF"),
                                            Age.One,
                                            "Altar",
                                            string.Empty,
                                            3,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free,
                                            null,
                                            new Guid[] { new Guid() }
                                            ),

                            // [Guid("F0563D95-587C-4418-AF6F-16AC646BBFB1")]
                            new CultureCard(new Guid("F0563D95-587C-4418-AF6F-16AC646BBFB1"),
                                            Age.One,
                                            "Theater",
                                            string.Empty,
                                            3,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free,
                                            null,
                                            new Guid[] { new Guid() }
                                            ),

                            // [Guid("D4B99FFD-010D-4F7D-8DD5-30552D67B1F9")]
                            new CultureCard(new Guid("D4B99FFD-010D-4F7D-8DD5-30552D67B1F9"),
                                            Age.One,
                                            "Pawnshop",
                                            string.Empty,
                                            4,
                                            3,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free,
                                            null,
                                            null
                                            ),

                            // 4+ Players

                            // [Guid("72584E71-E892-470E-BBCC-004EFC1775EB")]
                            new CultureCard(new Guid("72584E71-E892-470E-BBCC-004EFC1775EB"),
                                            Age.One,
                                            "Altar",
                                            string.Empty,
                                            4,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free,
                                            null,
                                            new Guid[] { new Guid() }
                                            ),

                            // 5+ Players

                            // 6+ Players

                            // [Guid("2158F63E-B3B9-4A09-BEF9-7D5198B5C72A")]
                            new CultureCard(new Guid("2158F63E-B3B9-4A09-BEF9-7D5198B5C72A"),
                                            Age.One,
                                            "Theater",
                                            string.Empty,
                                            6,
                                            2,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free,
                                            null,
                                            new Guid[] { new Guid() }
                                            ),

                            // 7+ Players

                            // [Guid("F17E03AE-7EE6-4074-801E-EBEE4EFCA2EB")]
                            new CultureCard(new Guid("F17E03AE-7EE6-4074-801E-EBEE4EFCA2EB"),
                                            Age.One,
                                            "Baths",
                                            string.Empty,
                                            7,
                                            3,
                                            new RawMaterialResourceCost(0,0,1,0),
                                            ManufacturedMaterialResourceCost.Free,
                                            null,
                                            new Guid[] { new Guid() }
                                            ),

                            // [Guid("6F748053-0777-4A9C-A84A-6192F0ADAD2A")]
                            new CultureCard(new Guid("6F748053-0777-4A9C-A84A-6192F0ADAD2A"),
                                            Age.One,
                                            "Pawnshop",
                                            string.Empty,
                                            7,
                                            3,
                                            RawMaterialResourceCost.Free,
                                            ManufacturedMaterialResourceCost.Free,
                                            null,
                                            null
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

        private static IEnumerable<IMilitaryCard> GetMilitaryCards(Age age)
        {
            switch (age)
            {
                case Age.One:
                    return new List<IMilitaryCard>
                        {
                            // 3+ Players

                            // [Guid("1CF9F9AA-78EC-4460-8705-FF5333214F2D")]
                            new MilitaryCard(new Guid("1CF9F9AA-78EC-4460-8705-FF5333214F2D"),
                                             Age.One,
                                             "Guard Tower",
                                             string.Empty,
                                             3,
                                             1,
                                             new RawMaterialResourceCost(1,0,0,0),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             null
                                             ),

                            // [Guid("EBFCDF1D-6A68-410F-A460-D9DC992CD39E")]
                            new MilitaryCard(new Guid("EBFCDF1D-6A68-410F-A460-D9DC992CD39E"),
                                             Age.One,
                                             "Stockade",
                                             string.Empty,
                                             3,
                                             1,
                                             new RawMaterialResourceCost(0,0,0,1),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             null
                                             ),

                            // [Guid("88B14BFD-13A6-4349-8CDC-0A609E64CF84")]
                            new MilitaryCard(new Guid("88B14BFD-13A6-4349-8CDC-0A609E64CF84"),
                                             Age.One,
                                             "Barracks",
                                             string.Empty,
                                             3,
                                             1,
                                             new RawMaterialResourceCost(0,1,0,0),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             null
                                             ),

                            // 4+ Players

                            // [Guid("0F72ABFD-0AC8-48F0-A74F-D83BBC704155")]
                            new MilitaryCard(new Guid("0F72ABFD-0AC8-48F0-A74F-D83BBC704155"),
                                             Age.One,
                                             "Guard Tower",
                                             string.Empty,
                                             4,
                                             1,
                                             new RawMaterialResourceCost(1,0,0,0),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             null
                                             ),

                            // 5+ Players

                            // [Guid("C3BB1D7E-B862-44FD-8743-9ACD5B37EC71")]
                            new MilitaryCard(new Guid("C3BB1D7E-B862-44FD-8743-9ACD5B37EC71"),
                                             Age.One,
                                             "Barracks",
                                             string.Empty,
                                             5,
                                             1,
                                             new RawMaterialResourceCost(0,1,0,0),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             null
                                             ),

                            // 6+ Players

                            // 7+ Players

                            // [Guid("92BECA99-515A-4A1F-AF3C-003399915561")]
                            new MilitaryCard(new Guid("92BECA99-515A-4A1F-AF3C-003399915561"),
                                             Age.One,
                                             "Stockade",
                                             string.Empty,
                                             7,
                                             1,
                                             new RawMaterialResourceCost(0,0,0,1),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             null
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

                            // [Guid("68233C71-B70A-49F7-BE5B-071AF5A1107F")]
                            new ScienceCard(new Guid("68233C71-B70A-49F7-BE5B-071AF5A1107F"),
                                            Age.One,
                                            "Apothecary",
                                            string.Empty,
                                            3,
                                            ScienceType.Tools,
                                            new ManufacturedMaterialResourceCost(0,1,0),
                                            null,
                                            new Guid[] { new Guid(), new Guid() }
                                            ),

                            // [Guid("14888B0E-4461-44C5-BE68-537B92009254")]
                            new ScienceCard(new Guid("14888B0E-4461-44C5-BE68-537B92009254"),
                                            Age.One,
                                            "Scriptorium",
                                            string.Empty,
                                            3,
                                            ScienceType.Glyph,
                                            new ManufacturedMaterialResourceCost(0,0,1),
                                            null,
                                            new Guid[] { new Guid(), new Guid() }
                                            ),

                            // [Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564")]
                            new ScienceCard(new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"),
                                            Age.One,
                                            "Workshop",
                                            string.Empty,
                                            3,
                                            ScienceType.Gear,
                                            new ManufacturedMaterialResourceCost(1,0,0),
                                            null,
                                            new Guid[] { new Guid(), new Guid() }
                                            ),

                            // 4+ Players

                            // [Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564")]
                            new ScienceCard(new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"),
                                            Age.One,
                                            "Scriptorium",
                                            string.Empty,
                                            4,
                                            ScienceType.Glyph,
                                            new ManufacturedMaterialResourceCost(0,0,1),
                                            null,
                                            new Guid[] { new Guid(), new Guid() }
                                            ),

                            // 5+ Players

                            // [Guid("6E64447E-98E5-44F6-A021-6939566AAB42")]
                            new ScienceCard(new Guid("6E64447E-98E5-44F6-A021-6939566AAB42"),
                                            Age.One,
                                            "Apothecary",
                                            string.Empty,
                                            5,
                                            ScienceType.Tools,
                                            new ManufacturedMaterialResourceCost(0,1,0),
                                            null,
                                            new Guid[] { new Guid(), new Guid() }
                                            ),

                            // 6+ Players

                            // 7+ Players

                            // [Guid("75F57C08-6490-4171-A281-7ACC82A4296C")]
                            new ScienceCard(new Guid("75F57C08-6490-4171-A281-7ACC82A4296C"),
                                            Age.One,
                                            "Workshop",
                                            string.Empty,
                                            7,
                                            ScienceType.Gear,
                                            new ManufacturedMaterialResourceCost(1,0,0),
                                            null,
                                            new Guid[] { new Guid(), new Guid() }
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

        private static IEnumerable<ICommerceCard> GetCommerceCards(Age age)
        {
            switch (age)
            {
                case Age.One:
                    return new List<ICommerceCard>
                        {
                            // 3+ Players

                            // [Guid("5AB7812B-AEBE-441D-AFD1-A8C980CD7C30")]
                            new CommerceRawMaterialDiscountCard(new Guid("5AB7812B-AEBE-441D-AFD1-A8C980CD7C30"),
                                                                Age.One,
                                                                "East Trading Post",
                                                                string.Empty,
                                                                3,
                                                                1,
                                                                new RawMaterialResourceToken[]
                                                                {
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood)
                                                                },
                                                                ApplicableDirection.Right,
                                                                null,
                                                                new Guid[] { new Guid() }
                                                                ),

                            // [Guid("2AA1C698-1E66-4EB2-86A7-D9182CBB68EA")]
                            new CommerceManufactoredMaterialDiscountCard(new Guid("2AA1C698-1E66-4EB2-86A7-D9182CBB68EA"),
                                                                         Age.One,
                                                                         "Marketplace",
                                                                         string.Empty,
                                                                         3,
                                                                         1,
                                                                         new ManufactoredMaterialResourceToken[]
                                                                         {
                                                                             ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass),
                                                                             ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom),
                                                                             ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus)
                                                                         },
                                                                         ApplicableDirection.LeftAndRight,
                                                                         null,
                                                                         new Guid[] { new Guid() }
                                                                         ),

                            // [Guid("77CF63AC-9459-4A81-842F-4FF75BC2EC00")]
                            new CommerceRawMaterialDiscountCard(new Guid("77CF63AC-9459-4A81-842F-4FF75BC2EC00"),
                                                                Age.One,
                                                                "West Trading Post",
                                                                string.Empty,
                                                                3,
                                                                1,
                                                                new RawMaterialResourceToken[]
                                                                {
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood)
                                                                },
                                                                ApplicableDirection.Left,
                                                                null,
                                                                new Guid[] { new Guid() }
                                                                ),

                            // 4+ Players

                            // [Guid("64F1F39D-215F-4626-AB45-CD375F423966")]
                            new CommerceGoldCard(new Guid("64F1F39D-215F-4626-AB45-CD375F423966"),
                                                 Age.One,
                                                 "Tavern",
                                                 string.Empty,
                                                 4,
                                                 5,
                                                 ApplicableDirection.None,
                                                 null,
                                                 null
                                                 ),

                            // 5+ Players

                            // [Guid("26A7245F-2017-482E-9DC1-43E68D046EDF")]
                            new CommerceGoldCard(new Guid("26A7245F-2017-482E-9DC1-43E68D046EDF"),
                                                 Age.One,
                                                 "Tavern",
                                                 string.Empty,
                                                 5,
                                                 5,
                                                 ApplicableDirection.None,
                                                 null,
                                                 null
                                                 ),

                            // 6+ Players

                            // [Guid("927D93A5-02D3-48B5-B77C-55077A4BB8BD")]
                            new CommerceManufactoredMaterialDiscountCard(new Guid("927D93A5-02D3-48B5-B77C-55077A4BB8BD"),
                                                                         Age.One,
                                                                         "Marketplace",
                                                                         string.Empty,
                                                                         6,
                                                                         1,
                                                                         new ManufactoredMaterialResourceToken[]
                                                                         {
                                                                             ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass),
                                                                             ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom),
                                                                             ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus)
                                                                         },
                                                                         ApplicableDirection.LeftAndRight,
                                                                         null,
                                                                         new Guid[] { new Guid() }
                                                                         ),

                            // 7+ Players

                            // [Guid("5C42BD03-B380-4BC2-A8C5-11AC6D4DF827")]
                            new CommerceRawMaterialDiscountCard(new Guid("5C42BD03-B380-4BC2-A8C5-11AC6D4DF827"),
                                                                Age.One,
                                                                "East Trading Post",
                                                                string.Empty,
                                                                7,
                                                                1,
                                                                new RawMaterialResourceToken[]
                                                                {
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood)
                                                                },
                                                                ApplicableDirection.Right,
                                                                null,
                                                                new Guid[] { new Guid() }
                                                                ),

                            // [Guid("2B4EDF1F-27DB-4B66-8CE1-5699E1DB1CA5")]
                            new CommerceGoldCard(new Guid("2B4EDF1F-27DB-4B66-8CE1-5699E1DB1CA5"),
                                                 Age.One,
                                                 "Tavern",
                                                 string.Empty,
                                                 7,
                                                 5,
                                                 ApplicableDirection.None,
                                                 null,
                                                 null
                                                 ),

                            // [Guid("D336A613-7752-4666-B09B-A11D189E8FEC")] 
                            new CommerceRawMaterialDiscountCard(new Guid("D336A613-7752-4666-B09B-A11D189E8FEC"),
                                                                Age.One,
                                                                "West Trading Post",
                                                                string.Empty,
                                                                7,
                                                                1,
                                                                new RawMaterialResourceToken[]
                                                                {
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood)
                                                                },
                                                                ApplicableDirection.Left,
                                                                null,
                                                                new Guid[] { new Guid() }
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
