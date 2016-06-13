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

                    return new List<IRawMaterialCard>
                        {
                            // 3+ Players

                            // [Guid("DF5D7F5E-84E2-472E-81E5-F756834B5509")]
                            new RawMaterialCard(new Guid("DF5D7F5E-84E2-472E-81E5-F756834B5509"),
                                                Age.Two,
                                                "Brickyard",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] {
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay) },
                                                1
                                                ),

                            // [Guid("1951DC1D-38B9-41E2-AFC7-87EEDB47DF67")]
                            new RawMaterialCard(new Guid("1951DC1D-38B9-41E2-AFC7-87EEDB47DF67"),
                                                Age.Two,
                                                "Foundry",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] {
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore) },
                                                1
                                                ),

                            // [Guid("75E1136B-8C00-4E19-8336-1FABB812928B")]
                            new RawMaterialCard(new Guid("75E1136B-8C00-4E19-8336-1FABB812928B"),
                                                Age.Two,
                                                "Quarry",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] {
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone) },
                                                1
                                                ),

                            // [Guid("E97A76FE-F10B-4999-A2CE-85CDAD6B8080")]
                            new RawMaterialCard(new Guid("E97A76FE-F10B-4999-A2CE-85CDAD6B8080"),
                                                Age.Two,
                                                "Sawmill",
                                                string.Empty,
                                                3,
                                                new RawMaterialResourceToken[] {
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood),  
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood) },
                                                1
                                                ),

                            // 4+ Players

                            // [Guid("17B8E3BD-22F3-46D2-90D0-7F3543C35260")]
                            new RawMaterialCard(new Guid("17B8E3BD-22F3-46D2-90D0-7F3543C35260"),
                                                Age.Two,
                                                "Brickyard",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] {
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay) },
                                                1
                                                ),

                            // [Guid("FCF68028-FF22-48FD-B062-0DE01E028D54")]
                            new RawMaterialCard(new Guid("FCF68028-FF22-48FD-B062-0DE01E028D54"),
                                                Age.Two,
                                                "Foundry",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] {
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore) },
                                                1
                                                ),

                            // [Guid("54748C79-33FF-4A78-9667-1B86BD7E7B12")]
                            new RawMaterialCard(new Guid("54748C79-33FF-4A78-9667-1B86BD7E7B12"),
                                                Age.Two,
                                                "Quarry",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] {
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone) },
                                                1
                                                ),

                            // [Guid("C462B76D-A1EC-4507-B412-BF60347F39B1")]
                            new RawMaterialCard(new Guid("C462B76D-A1EC-4507-B412-BF60347F39B1"),
                                                Age.Two,
                                                "Sawmill",
                                                string.Empty,
                                                4,
                                                new RawMaterialResourceToken[] {
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood),
                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood) },
                                                1
                                                )

                            // 5+ Players

                            // 6+ Players

                            // 7+ Players

                        };

                        

                case Age.Three:

                    return new List<IRawMaterialCard>
                    {
                        // 3+ Players

                        // 4+ Players

                        // 5+ Players

                        // 6+ Players

                        // 7+ Players
                    };
                        
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
                                                     "Glassworks",
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
                                                     "Glassworks",
                                                     string.Empty,
                                                     6,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass) },
                                                     0
                                                     ),

                            // 7+ Players
                        };

                case Age.Two:
                    return new List<IManufacturedMaterialCard>
                        {
                            // 3+ Players

                            // [Guid("AFD1B3CF-5921-4D69-969E-ED2EC4C16AA4")]
                            new ManufacturedGoodCard(new Guid("AFD1B3CF-5921-4D69-969E-ED2EC4C16AA4"),
                                                     Age.Two,
                                                     "Loom",
                                                     string.Empty,
                                                     3,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom) },
                                                     0
                                                     ),

                            // [Guid("B13346D8-D762-4B7F-AEA3-3A0E57448FA5")]
                            new ManufacturedGoodCard(new Guid("B13346D8-D762-4B7F-AEA3-3A0E57448FA5"),
                                                     Age.Two,
                                                     "Glassworks",
                                                     string.Empty,
                                                     3,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass) },
                                                     0
                                                     ),

                            // [Guid("76CFAC99-D7B6-4293-AFA0-FA93D1391B77")]
                            new ManufacturedGoodCard(new Guid("76CFAC99-D7B6-4293-AFA0-FA93D1391B77"),
                                                     Age.Two,
                                                     "Press",
                                                     string.Empty,
                                                     3,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus) },
                                                     0
                                                     ),

                            // 4+ Players

                            // 5+ Players

                            // [Guid("2CC2E7E9-0300-4A02-9C17-0FBBF77EFD4C")]
                            new ManufacturedGoodCard(new Guid("2CC2E7E9-0300-4A02-9C17-0FBBF77EFD4C"),
                                                     Age.Two,
                                                     "Loom",
                                                     string.Empty,
                                                     5,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom) },
                                                     0
                                                     ),

                            // [Guid("AB82D078-CB56-43A2-801B-F1C386431517")]
                            new ManufacturedGoodCard(new Guid("AB82D078-CB56-43A2-801B-F1C386431517"),
                                                     Age.Two,
                                                     "Glassworks",
                                                     string.Empty,
                                                     5,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass) },
                                                     0
                                                     ),

                            // [Guid("396AE8C5-1DFC-44B9-8E65-17081CC3F2BA")]
                            new ManufacturedGoodCard(new Guid("396AE8C5-1DFC-44B9-8E65-17081CC3F2BA"),
                                                     Age.Two,
                                                     "Press",
                                                     string.Empty,
                                                     5,
                                                     new ManufactoredMaterialResourceToken[] { ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus) },
                                                     0
                                                     ),

                            // 6+ Players

                            // 7+ Players
                        };

                case Age.Three:

                    return new List<IManufacturedMaterialCard>
                    {
                        // 3+ Players

                        // 4+ Players

                        // 5+ Players

                        // 6+ Players

                        // 7+ Players
                    };

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
                                            new Guid[] {
                                                new Guid("90F497BA-6801-4699-BCAB-7141DA3CD96E"),
                                                new Guid("9DF416F1-ACF3-471E-BEA3-BC0996A57300") }
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
                                            new Guid[] {
                                                new Guid("CB97CA9A-63A4-4D1C-90E1-D2FB22FA7AB1"),
                                                new Guid("CC884286-D176-4138-B30C-B25D5D032AF8") }
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
                                            new Guid[] {
                                                new Guid("08086CDA-BDE4-4C26-9393-B6ED2D6EF6FE"),
                                                new Guid("2152CB67-F432-4E7E-B4A8-A4B6DEFCF9D9") }
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
                                            new Guid[] {
                                                new Guid("CB97CA9A-63A4-4D1C-90E1-D2FB22FA7AB1"),
                                                new Guid("CC884286-D176-4138-B30C-B25D5D032AF8") }
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
                                            new Guid[] {
                                                new Guid("08086CDA-BDE4-4C26-9393-B6ED2D6EF6FE"),
                                                new Guid("2152CB67-F432-4E7E-B4A8-A4B6DEFCF9D9") }
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
                                            new Guid[] {
                                                new Guid("90F497BA-6801-4699-BCAB-7141DA3CD96E"),
                                                new Guid("9DF416F1-ACF3-471E-BEA3-BC0996A57300") }
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

                    return new List<ICultureCard>
                        {
                            // 3+ Players

                            // [Guid("90F497BA-6801-4699-BCAB-7141DA3CD96E")]
                            new CultureCard(new Guid("90F497BA-6801-4699-BCAB-7141DA3CD96E"),
                                            Age.Two,
                                            "Aqueduct",
                                            string.Empty,
                                            3,
                                            5,
                                            new RawMaterialResourceCost(0,0,3,0),
                                            ManufacturedMaterialResourceCost.Free,
                                            new Guid[] {
                                                new Guid("1343C1C1-A58F-4E18-B1ED-E607253E8B53"),
                                                new Guid("F17E03AE-7EE6-4074-801E-EBEE4EFCA2EB") },
                                            null
                                            ),

                            // [Guid("08086CDA-BDE4-4C26-9393-B6ED2D6EF6FE")]
                            new CultureCard(new Guid("08086CDA-BDE4-4C26-9393-B6ED2D6EF6FE"),
                                            Age.Two,
                                            "Statue",
                                            string.Empty,
                                            3,
                                            4,
                                            new RawMaterialResourceCost(0,2,0,1),
                                            ManufacturedMaterialResourceCost.Free,
                                            new Guid[] {
                                                new Guid("F0563D95-587C-4418-AF6F-16AC646BBFB1"),
                                                new Guid("2158F63E-B3B9-4A09-BEF9-7D5198B5C72A") },
                                            new Guid[] {
                                                new Guid()
                                            }
                                            ),

                            // [Guid("3D1932E6-3A00-4EB4-A2E9-6476891AC4BE")]
                            new CultureCard(new Guid("3D1932E6-3A00-4EB4-A2E9-6476891AC4BE"),
                                            Age.Two,
                                            "Courthouse",
                                            string.Empty,
                                            3,
                                            4,
                                            new RawMaterialResourceCost(2,0,0,0),
                                            new ManufacturedMaterialResourceCost(0,1,0),
                                            new Guid[] {
                                                new Guid("14888B0E-4461-44C5-BE68-537B92009254"),
                                                new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564") },
                                            null
                                            ),

                            // [Guid("CB97CA9A-63A4-4D1C-90E1-D2FB22FA7AB1")]
                            new CultureCard(new Guid("CB97CA9A-63A4-4D1C-90E1-D2FB22FA7AB1"),
                                            Age.Two,
                                            "Temple",
                                            string.Empty,
                                            3,
                                            3,
                                            new RawMaterialResourceCost(1,0,0,1),
                                            new ManufacturedMaterialResourceCost(1,0,0),
                                            new Guid[] {
                                                new Guid("5DBC3B9A-DAD1-42AF-87D7-FFA7543E28FF"),
                                                new Guid("72584E71-E892-470E-BBCC-004EFC1775EB") },
                                            new Guid[] {
                                                new Guid()
                                            }
                                            ),

                            // 4+ Players

                            // 5+ Players

                            // [Guid("268573A7-894B-4EB7-AAEC-707CC92AF9FD")]
                            new CultureCard(new Guid("268573A7-894B-4EB7-AAEC-707CC92AF9FD"),
                                            Age.Two,
                                            "Courthouse",
                                            string.Empty,
                                            5,
                                            4,
                                            new RawMaterialResourceCost(2,0,0,0),
                                            new ManufacturedMaterialResourceCost(0,1,0),
                                            new Guid[] {
                                                new Guid("14888B0E-4461-44C5-BE68-537B92009254"),
                                                new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564") },
                                            null
                                            ),

                            // 6+ Players

                            // [Guid("CC884286-D176-4138-B30C-B25D5D032AF8")]
                            new CultureCard(new Guid("CC884286-D176-4138-B30C-B25D5D032AF8"),
                                            Age.Two,
                                            "Temple",
                                            string.Empty,
                                            6,
                                            3,
                                            new RawMaterialResourceCost(1,0,0,1),
                                            new ManufacturedMaterialResourceCost(1,0,0),
                                            new Guid[] {
                                                new Guid("5DBC3B9A-DAD1-42AF-87D7-FFA7543E28FF"),
                                                new Guid("72584E71-E892-470E-BBCC-004EFC1775EB") },
                                            new Guid[] {
                                                new Guid()
                                            }
                                            ),

                            // 7+ Players

                            // [Guid("9DF416F1-ACF3-471E-BEA3-BC0996A57300")]
                            new CultureCard(new Guid("9DF416F1-ACF3-471E-BEA3-BC0996A57300"),
                                            Age.Two,
                                            "Aqueduct",
                                            string.Empty,
                                            7,
                                            5,
                                            new RawMaterialResourceCost(0,0,3,0),
                                            ManufacturedMaterialResourceCost.Free,
                                            new Guid[] {
                                                new Guid("1343C1C1-A58F-4E18-B1ED-E607253E8B53"),
                                                new Guid("F17E03AE-7EE6-4074-801E-EBEE4EFCA2EB") },
                                            null
                                            ),

                            // [Guid("2152CB67-F432-4E7E-B4A8-A4B6DEFCF9D9")]
                            new CultureCard(new Guid("2152CB67-F432-4E7E-B4A8-A4B6DEFCF9D9"),
                                            Age.Two,
                                            "Statue",
                                            string.Empty,
                                            7,
                                            4,
                                            new RawMaterialResourceCost(0,2,0,1),
                                            ManufacturedMaterialResourceCost.Free,
                                            new Guid[] {
                                                new Guid("F0563D95-587C-4418-AF6F-16AC646BBFB1"),
                                                new Guid("2158F63E-B3B9-4A09-BEF9-7D5198B5C72A") },
                                            new Guid[] {
                                                new Guid()
                                            }
                                            )
                        };

                    throw new NotImplementedException();

                case Age.Three:

                    return new List<ICultureCard>
                    {
                        // 3+ Players

                        // [Guid("523860CB-BBC3-4CFB-8BC8-6B2713C9CEC0")]
                        new CultureCard(new Guid("523860CB-BBC3-4CFB-8BC8-6B2713C9CEC0"),
                                        Age.Three,
                                        "Gardens",
                                        string.Empty,
                                        3,
                                        5,
                                        new RawMaterialResourceCost(2,0,0,1),
                                        ManufacturedMaterialResourceCost.Free,
                                        new Guid[] {
                                            new Guid("08086CDA-BDE4-4C26-9393-B6ED2D6EF6FE"),
                                            new Guid("2152CB67-F432-4E7E-B4A8-A4B6DEFCF9D9")
                                        },
                                        null
                                        ),

                        // [Guid("D957FFC8-6F27-4B65-BBCA-18C54117A4E8")]
                        new CultureCard(new Guid("D957FFC8-6F27-4B65-BBCA-18C54117A4E8"),
                                        Age.Three,
                                        "Senate",
                                        string.Empty,
                                        3,
                                        6,
                                        new RawMaterialResourceCost(0,1,1,2),
                                        ManufacturedMaterialResourceCost.Free,
                                        new Guid[] {
                                            new Guid("F998C675-70FF-43AD-A628-B25200CA354D"),
                                            new Guid("F6363E52-C30A-4CE5-AD9D-5CD8962109B9")
                                        },
                                        null
                                        ),

                        // [Guid("B2FFF9DE-473A-4875-8AF9-C7066C860270")]
                        new CultureCard(new Guid("B2FFF9DE-473A-4875-8AF9-C7066C860270"),
                                        Age.Three,
                                        "Pantheon",
                                        string.Empty,
                                        3,
                                        7,
                                        new RawMaterialResourceCost(2,1,0,0),
                                        new ManufacturedMaterialResourceCost(1,1,1),
                                        new Guid[] {
                                            new Guid("CB97CA9A-63A4-4D1C-90E1-D2FB22FA7AB1"),
                                            new Guid("CC884286-D176-4138-B30C-B25D5D032AF8")
                                        },
                                        null
                                        ),

                        // [Guid("563CB18F-84BD-475E-9842-9C6E3AF407B3")]
                        new CultureCard(new Guid("563CB18F-84BD-475E-9842-9C6E3AF407B3"),
                                        Age.Three,
                                        "Palace",
                                        string.Empty,
                                        3,
                                        8,
                                        new RawMaterialResourceCost(1,1,1,1),
                                        new ManufacturedMaterialResourceCost(1,1,1),
                                        null,
                                        null
                                        ),

                        // [Guid("50D34F86-0F32-42EE-A6C5-1E979B8A7504")]
                        new CultureCard(new Guid("50D34F86-0F32-42EE-A6C5-1E979B8A7504"),
                                        Age.Three,
                                        "Town Hall",
                                        string.Empty,
                                        3,
                                        6,
                                        new RawMaterialResourceCost(0,1,2,0),
                                        new ManufacturedMaterialResourceCost(1,0,0),
                                        null,
                                        null
                                        ),

                        // 4+ Players

                        // [Guid("8BB9F9FD-1589-4D22-BA2B-12CAAE019518")]
                        new CultureCard(new Guid("8BB9F9FD-1589-4D22-BA2B-12CAAE019518"),
                                        Age.Three,
                                        "Gardens",
                                        string.Empty,
                                        4,
                                        5,
                                        new RawMaterialResourceCost(2,0,0,1),
                                        ManufacturedMaterialResourceCost.Free,
                                        new Guid[] {
                                            new Guid("08086CDA-BDE4-4C26-9393-B6ED2D6EF6FE"),
                                            new Guid("2152CB67-F432-4E7E-B4A8-A4B6DEFCF9D9")
                                        },
                                        null
                                        ),

                        // 5+ Players

                        // [Guid("F967D945-6B77-4B15-9606-3E501F029F38")]
                        new CultureCard(new Guid("F967D945-6B77-4B15-9606-3E501F029F38"),
                                        Age.Three,
                                        "Senate",
                                        string.Empty,
                                        5,
                                        6,
                                        new RawMaterialResourceCost(0,1,1,2),
                                        ManufacturedMaterialResourceCost.Free,
                                        new Guid[] {
                                            new Guid("F998C675-70FF-43AD-A628-B25200CA354D"),
                                            new Guid("F6363E52-C30A-4CE5-AD9D-5CD8962109B9")
                                        },
                                        null
                                        ),

                        // [Guid("51FE3DC6-3346-4F38-8AF0-9E7F2DF5B815")]
                        new CultureCard(new Guid("51FE3DC6-3346-4F38-8AF0-9E7F2DF5B815"),
                                        Age.Three,
                                        "Town Hall",
                                        string.Empty,
                                        5,
                                        6,
                                        new RawMaterialResourceCost(0,1,2,0),
                                        new ManufacturedMaterialResourceCost(1,0,0),
                                        null,
                                        null
                                        ),

                        // 6+ Players

                        // [Guid("4E785622-D81C-45BC-98AF-CD2E152E05FC")]
                        new CultureCard(new Guid("4E785622-D81C-45BC-98AF-CD2E152E05FC"),
                                        Age.Three,
                                        "Pantheon",
                                        string.Empty,
                                        6,
                                        7,
                                        new RawMaterialResourceCost(2,1,0,0),
                                        new ManufacturedMaterialResourceCost(1,1,1),
                                        new Guid[] {
                                            new Guid("CB97CA9A-63A4-4D1C-90E1-D2FB22FA7AB1"),
                                            new Guid("CC884286-D176-4138-B30C-B25D5D032AF8")
                                        },
                                        null
                                        ),

                        // [Guid("91DE2986-CD85-4BD1-B287-EA8D43AA508E")]
                        new CultureCard(new Guid("91DE2986-CD85-4BD1-B287-EA8D43AA508E"),
                                        Age.Three,
                                        "Town Hall",
                                        string.Empty,
                                        6,
                                        6,
                                        new RawMaterialResourceCost(0,1,2,0),
                                        new ManufacturedMaterialResourceCost(1,0,0),
                                        null,
                                        null
                                        ),

                        // 7+ Players

                        // [Guid("2999639F-F22C-4F79-B6C5-E160821E6B4E")]
                        new CultureCard(new Guid("2999639F-F22C-4F79-B6C5-E160821E6B4E"),
                                        Age.Three,
                                        "Palace",
                                        string.Empty,
                                        7,
                                        8,
                                        new RawMaterialResourceCost(1,1,1,1),
                                        new ManufacturedMaterialResourceCost(1,1,1),
                                        null,
                                        null
                                        ),
                    };

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

                    return new List<IMilitaryCard>
                        {
                            // 3+ Players

                            // [Guid("29476E9F-6C5D-4F79-86A3-80A7E83D76BA")]
                            new MilitaryCard(new Guid("29476E9F-6C5D-4F79-86A3-80A7E83D76BA"),
                                             Age.Two,
                                             "Stables",
                                             string.Empty,
                                             3,
                                             2,
                                             new RawMaterialResourceCost(1,1,0,1),
                                             ManufacturedMaterialResourceCost.Free,
                                             new Guid[] {
                                                 new Guid("68233C71-B70A-49F7-BE5B-071AF5A1107F"),
                                                 new Guid("6E64447E-98E5-44F6-A021-6939566AAB42")
                                                 },
                                             null
                                             ),

                            // [Guid("03BE5384-FB1D-47F1-A235-E62BED13C697")]
                            new MilitaryCard(new Guid("03BE5384-FB1D-47F1-A235-E62BED13C697"),
                                             Age.Two,
                                             "Archery Range",
                                             string.Empty,
                                             3,
                                             2,
                                             new RawMaterialResourceCost(0,1,0,2),
                                             ManufacturedMaterialResourceCost.Free,
                                             new Guid[] {
                                                 new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"),
                                                 new Guid("75F57C08-6490-4171-A281-7ACC82A4296C")
                                                 },
                                             null
                                             ),

                            // [Guid("CCE6E9DC-1687-4BE7-8939-461DD96440AF")]
                            new MilitaryCard(new Guid("CCE6E9DC-1687-4BE7-8939-461DD96440AF"),
                                             Age.Two,
                                             "Walls",
                                             string.Empty,
                                             3,
                                             2,
                                             new RawMaterialResourceCost(0,0,3,0),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             new Guid[] {
                                                 new Guid() }
                                             ),

                            // 4+ Players

                            // [Guid("51FCDE3C-119E-4A16-82A0-BD8D617A6D49")]
                            new MilitaryCard(new Guid("51FCDE3C-119E-4A16-82A0-BD8D617A6D49"),
                                             Age.Two,
                                             "Training Ground",
                                             string.Empty,
                                             4,
                                             2,
                                             new RawMaterialResourceCost(0,2,0,1),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             new Guid[] {
                                                 new Guid() }
                                             ),

                            // 5+ Players

                            // [Guid("C99158E5-A008-43D7-8660-AD532A803CCF")]
                            new MilitaryCard(new Guid("C99158E5-A008-43D7-8660-AD532A803CCF"),
                                             Age.Two,
                                             "Stables",
                                             string.Empty,
                                             5,
                                             2,
                                             new RawMaterialResourceCost(1,1,0,1),
                                             ManufacturedMaterialResourceCost.Free,
                                             new Guid[] {
                                                 new Guid("68233C71-B70A-49F7-BE5B-071AF5A1107F"),
                                                 new Guid("6E64447E-98E5-44F6-A021-6939566AAB42")
                                                 },
                                             null
                                             ),

                            // 6+ Players

                            // [Guid("3FAFF4F3-806F-49DC-8AA5-13814745ABC2")]
                            new MilitaryCard(new Guid("3FAFF4F3-806F-49DC-8AA5-13814745ABC2"),
                                             Age.Two,
                                             "Training Ground",
                                             string.Empty,
                                             6,
                                             2,
                                             new RawMaterialResourceCost(0,2,0,1),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             new Guid[] {
                                                 new Guid() }
                                             ),

                            // [Guid("DABA8686-0BA4-4EDE-9297-F385F64BF9A5")]
                            new MilitaryCard(new Guid("DABA8686-0BA4-4EDE-9297-F385F64BF9A5"),
                                             Age.Two,
                                             "Archery Range",
                                             string.Empty,
                                             6,
                                             2,
                                             new RawMaterialResourceCost(0,1,0,2),
                                             ManufacturedMaterialResourceCost.Free,
                                             new Guid[] {
                                                 new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"),
                                                 new Guid("75F57C08-6490-4171-A281-7ACC82A4296C")
                                                 },
                                             null
                                             ),

                            // 7+ Players

                            // [Guid("533A08A0-B6AF-4468-9773-79161BEDFD7B")]
                            new MilitaryCard(new Guid("533A08A0-B6AF-4468-9773-79161BEDFD7B"),
                                             Age.Two,
                                             "Training Ground",
                                             string.Empty,
                                             7,
                                             2,
                                             new RawMaterialResourceCost(0,2,0,1),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             new Guid[] {
                                                 new Guid() }
                                             ),

                            // [Guid("450AEC85-B216-4026-B759-46013E608983")]
                            new MilitaryCard(new Guid("450AEC85-B216-4026-B759-46013E608983"),
                                             Age.Two,
                                             "Walls",
                                             string.Empty,
                                             7,
                                             2,
                                             new RawMaterialResourceCost(0,0,3,0),
                                             ManufacturedMaterialResourceCost.Free,
                                             null,
                                             new Guid[] {
                                                 new Guid() }
                                             )
                        };

                case Age.Three:

                    return new List<IMilitaryCard>
                    {
                        // 3+ Players

                        // [Guid("DE1BF028-B8B9-4950-B090-1D0A3480A622")]
                        new MilitaryCard(new Guid("DE1BF028-B8B9-4950-B090-1D0A3480A622"),
                                         Age.Three,
                                         "Arsenal",
                                         string.Empty,
                                         3,
                                         3,
                                         new RawMaterialResourceCost(0,1,0,2),
                                         new ManufacturedMaterialResourceCost(0,1,0),
                                         null,
                                         null
                                         ),

                        // [Guid("931A9B62-8727-4555-AE59-382503FE49EC")]
                        new MilitaryCard(new Guid("931A9B62-8727-4555-AE59-382503FE49EC"),
                                         Age.Three,
                                         "Fortification",
                                         string.Empty,
                                         3,
                                         3,
                                         new RawMaterialResourceCost(0,3,1,0),
                                         ManufacturedMaterialResourceCost.Free,
                                         new Guid[] {
                                             new Guid("CCE6E9DC-1687-4BE7-8939-461DD96440AF"),
                                             new Guid("450AEC85-B216-4026-B759-46013E608983")
                                         },
                                         null
                                         ),

                        // [Guid("3B8D431A-3940-43FF-B1DE-048A4DF41E77")]
                        new MilitaryCard(new Guid("3B8D431A-3940-43FF-B1DE-048A4DF41E77"),
                                         Age.Three,
                                         "Siege Workshop",
                                         string.Empty,
                                         3,
                                         3,
                                         new RawMaterialResourceCost(3,0,0,1),
                                         ManufacturedMaterialResourceCost.Free,
                                         new Guid[] {
                                             new Guid("7323344C-BE83-4EE4-BB33-B7ADD7288A8D"),
                                             new Guid("BA118433-A993-4C1D-B31D-FA9D97167442")
                                         },
                                         null
                                         ),

                        // 4+ Players

                        // [Guid("3F781A87-14E9-431A-A6E3-A5316D1E3FC6")]
                        new MilitaryCard(new Guid("3F781A87-14E9-431A-A6E3-A5316D1E3FC6"),
                                         Age.Three,
                                         "Arsenal",
                                         string.Empty,
                                         4,
                                         3,
                                         new RawMaterialResourceCost(0,1,0,2),
                                         new ManufacturedMaterialResourceCost(0,1,0),
                                         null,
                                         null
                                         ),

                        // [Guid("332FC3A7-06E1-463A-8C58-D0DBE839AA72")]
                        new MilitaryCard(new Guid("332FC3A7-06E1-463A-8C58-D0DBE839AA72"),
                                         Age.Three,
                                         "Circus",
                                         string.Empty,
                                         4,
                                         3,
                                         new RawMaterialResourceCost(0,1,3,0),
                                         ManufacturedMaterialResourceCost.Free,
                                         new Guid[] {
                                             new Guid("51FCDE3C-119E-4A16-82A0-BD8D617A6D49"),
                                             new Guid("533A08A0-B6AF-4468-9773-79161BEDFD7B"),
                                             new Guid("3FAFF4F3-806F-49DC-8AA5-13814745ABC2")
                                         },
                                         null
                                         ),

                        // 5+ Players

                        // [Guid("5A34E91D-4AE1-4DBE-972C-5D29F4F4B653")]
                        new MilitaryCard(new Guid("5A34E91D-4AE1-4DBE-972C-5D29F4F4B653"),
                                         Age.Three,
                                         "Circus",
                                         string.Empty,
                                         5,
                                         3,
                                         new RawMaterialResourceCost(0,1,3,0),
                                         ManufacturedMaterialResourceCost.Free,
                                         new Guid[] {
                                             new Guid("51FCDE3C-119E-4A16-82A0-BD8D617A6D49"),
                                             new Guid("533A08A0-B6AF-4468-9773-79161BEDFD7B"),
                                             new Guid("3FAFF4F3-806F-49DC-8AA5-13814745ABC2")
                                         },
                                         null
                                         ),

                        // [Guid("DF62BC9C-9668-4841-B492-D996A26A8847")]
                        new MilitaryCard(new Guid("DF62BC9C-9668-4841-B492-D996A26A8847"),
                                         Age.Three,
                                         "Siege Workshop",
                                         string.Empty,
                                         5,
                                         3,
                                         new RawMaterialResourceCost(3,0,0,1),
                                         ManufacturedMaterialResourceCost.Free,
                                         new Guid[] {
                                             new Guid("7323344C-BE83-4EE4-BB33-B7ADD7288A8D"),
                                             new Guid("BA118433-A993-4C1D-B31D-FA9D97167442")
                                         },
                                         null
                                         ),

                        // 6+ Players

                        // [Guid("350438EF-6EDE-49A2-AC22-0DEE476171DF")]
                        new MilitaryCard(new Guid("350438EF-6EDE-49A2-AC22-0DEE476171DF"),
                                         Age.Three,
                                         "Circus",
                                         string.Empty,
                                         6,
                                         3,
                                         new RawMaterialResourceCost(0,1,3,0),
                                         ManufacturedMaterialResourceCost.Free,
                                         new Guid[] {
                                             new Guid("51FCDE3C-119E-4A16-82A0-BD8D617A6D49"),
                                             new Guid("533A08A0-B6AF-4468-9773-79161BEDFD7B"),
                                             new Guid("3FAFF4F3-806F-49DC-8AA5-13814745ABC2")
                                         },
                                         null
                                         ),

                        // 7+ Players

                        // [Guid("50FCB861-0888-41D9-9DDD-2CF71DB403F3")]
                        new MilitaryCard(new Guid("50FCB861-0888-41D9-9DDD-2CF71DB403F3"),
                                         Age.Three,
                                         "Arsenal",
                                         string.Empty,
                                         7,
                                         3,
                                         new RawMaterialResourceCost(0,1,0,2),
                                         new ManufacturedMaterialResourceCost(0,1,0),
                                         null,
                                         null
                                         ),

                        // [Guid("44054D3B-60A2-4CA3-B2B8-2CB88B86E2AC")]
                        new MilitaryCard(new Guid("44054D3B-60A2-4CA3-B2B8-2CB88B86E2AC"),
                                         Age.Three,
                                         "Fortification",
                                         string.Empty,
                                         7,
                                         3,
                                         new RawMaterialResourceCost(0,3,1,0),
                                         ManufacturedMaterialResourceCost.Free,
                                         new Guid[] {
                                             new Guid("CCE6E9DC-1687-4BE7-8939-461DD96440AF"),
                                             new Guid("450AEC85-B216-4026-B759-46013E608983")
                                         },
                                         null
                                         ),
                    };

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
                                            RawMaterialResourceCost.Free,
                                            new ManufacturedMaterialResourceCost(0,1,0),
                                            null,
                                            new Guid[] {
                                                new Guid("29476E9F-6C5D-4F79-86A3-80A7E83D76BA"),
                                                new Guid("C99158E5-A008-43D7-8660-AD532A803CCF"),
                                                new Guid("CDE83578-2ADB-4318-A94D-07EF0218C342"),
                                                new Guid("752A27A2-1857-40B8-803C-DCE3481367BB"),
                                                }
                                            ),

                            // [Guid("14888B0E-4461-44C5-BE68-537B92009254")]
                            new ScienceCard(new Guid("14888B0E-4461-44C5-BE68-537B92009254"),
                                            Age.One,
                                            "Scriptorium",
                                            string.Empty,
                                            3,
                                            ScienceType.Glyph,
                                            RawMaterialResourceCost.Free,
                                            new ManufacturedMaterialResourceCost(0,0,1),
                                            null,
                                            new Guid[] {
                                                new Guid("3D1932E6-3A00-4EB4-A2E9-6476891AC4BE"),
                                                new Guid("268573A7-894B-4EB7-AAEC-707CC92AF9FD"),
                                                new Guid("F998C675-70FF-43AD-A628-B25200CA354D"),
                                                new Guid("F6363E52-C30A-4CE5-AD9D-5CD8962109B9"),
                                                }
                                            ),

                            // [Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564")]
                            new ScienceCard(new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"),
                                            Age.One,
                                            "Workshop",
                                            string.Empty,
                                            3,
                                            ScienceType.Gear,
                                            RawMaterialResourceCost.Free,
                                            new ManufacturedMaterialResourceCost(1,0,0),
                                            null,
                                            new Guid[] {
                                                new Guid("7323344C-BE83-4EE4-BB33-B7ADD7288A8D"),
                                                new Guid("BA118433-A993-4C1D-B31D-FA9D97167442"),
                                                new Guid("03BE5384-FB1D-47F1-A235-E62BED13C697"),
                                                new Guid("DABA8686-0BA4-4EDE-9297-F385F64BF9A5"),
                                                }
                                            ),

                            // 4+ Players

                            // [Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564")]
                            new ScienceCard(new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"),
                                            Age.One,
                                            "Scriptorium",
                                            string.Empty,
                                            4,
                                            ScienceType.Glyph,
                                            RawMaterialResourceCost.Free,
                                            new ManufacturedMaterialResourceCost(0,0,1),
                                            null,
                                            new Guid[] {
                                                new Guid("3D1932E6-3A00-4EB4-A2E9-6476891AC4BE"),
                                                new Guid("268573A7-894B-4EB7-AAEC-707CC92AF9FD"),
                                                new Guid("F998C675-70FF-43AD-A628-B25200CA354D"),
                                                new Guid("F6363E52-C30A-4CE5-AD9D-5CD8962109B9"),
                                                }
                                            ),

                            // 5+ Players

                            // [Guid("6E64447E-98E5-44F6-A021-6939566AAB42")]
                            new ScienceCard(new Guid("6E64447E-98E5-44F6-A021-6939566AAB42"),
                                            Age.One,
                                            "Apothecary",
                                            string.Empty,
                                            5,
                                            ScienceType.Tools,
                                            RawMaterialResourceCost.Free,
                                            new ManufacturedMaterialResourceCost(0,1,0),
                                            null,
                                            new Guid[] {
                                                new Guid("29476E9F-6C5D-4F79-86A3-80A7E83D76BA"),
                                                new Guid("C99158E5-A008-43D7-8660-AD532A803CCF"),
                                                new Guid("CDE83578-2ADB-4318-A94D-07EF0218C342"),
                                                new Guid("752A27A2-1857-40B8-803C-DCE3481367BB"),
                                                }
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
                                            RawMaterialResourceCost.Free,
                                            new ManufacturedMaterialResourceCost(1,0,0),
                                            null,
                                            new Guid[] {
                                                new Guid("7323344C-BE83-4EE4-BB33-B7ADD7288A8D"),
                                                new Guid("BA118433-A993-4C1D-B31D-FA9D97167442"),
                                                new Guid("03BE5384-FB1D-47F1-A235-E62BED13C697"),
                                                new Guid("DABA8686-0BA4-4EDE-9297-F385F64BF9A5"),
                                                }
                                            )
                        };

                case Age.Two:

                    return new List<IScienceCard>
                        {
                            // 3+ Players

                            // [Guid("CDE83578-2ADB-4318-A94D-07EF0218C342")]
                            new ScienceCard(new Guid("CDE83578-2ADB-4318-A94D-07EF0218C342"),
                                            Age.Two,
                                            "Dispensary",
                                            string.Empty,
                                            3,
                                            ScienceType.Tools,
                                            new RawMaterialResourceCost(0,2,0,0),
                                            new ManufacturedMaterialResourceCost(1,0,0),
                                            new Guid[] {
                                                new Guid("68233C71-B70A-49F7-BE5B-071AF5A1107F"),
                                                new Guid("6E64447E-98E5-44F6-A021-6939566AAB42")
                                                },
                                            new Guid[] { new Guid(), new Guid() }
                                            ), 

                            // [Guid("7323344C-BE83-4EE4-BB33-B7ADD7288A8D")]
                            new ScienceCard(new Guid("7323344C-BE83-4EE4-BB33-B7ADD7288A8D"),
                                            Age.Two,
                                            "Laboratory",
                                            string.Empty,
                                            3,
                                            ScienceType.Tools,
                                            new RawMaterialResourceCost(2,0,0,0),
                                            new ManufacturedMaterialResourceCost(0,0,1),
                                            new Guid[] {
                                                new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"),
                                                new Guid("75F57C08-6490-4171-A281-7ACC82A4296C")
                                                },
                                            new Guid[] { new Guid(), new Guid() }
                                            ), 

                            // [Guid("F998C675-70FF-43AD-A628-B25200CA354D")]
                            new ScienceCard(new Guid("F998C675-70FF-43AD-A628-B25200CA354D"),
                                            Age.Two,
                                            "Library",
                                            string.Empty,
                                            3,
                                            ScienceType.Tools,
                                            new RawMaterialResourceCost(0,0,2,0),
                                            new ManufacturedMaterialResourceCost(0,1,0),
                                            new Guid[] {
                                                new Guid("14888B0E-4461-44C5-BE68-537B92009254"),
                                                new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564")
                                                },
                                            new Guid[] { new Guid(), new Guid() }
                                            ), 

                            // [Guid("288BB8E5-CA12-40B2-9D2D-9C314EB64C3F")]
                            new ScienceCard(new Guid("288BB8E5-CA12-40B2-9D2D-9C314EB64C3F"),
                                            Age.Two,
                                            "School",
                                            string.Empty,
                                            3,
                                            ScienceType.Tools,
                                            new RawMaterialResourceCost(0,0,0,1),
                                            new ManufacturedMaterialResourceCost(0,0,1),
                                            null,
                                            new Guid[] { new Guid(), new Guid() }
                                            ), 

                            // 4+ Players

                            // [Guid("752A27A2-1857-40B8-803C-DCE3481367BB")]
                            new ScienceCard(new Guid("752A27A2-1857-40B8-803C-DCE3481367BB"),
                                            Age.Two,
                                            "Dispensary",
                                            string.Empty,
                                            4,
                                            ScienceType.Tools,
                                            new RawMaterialResourceCost(0,2,0,0),
                                            new ManufacturedMaterialResourceCost(1,0,0),
                                            new Guid[] {
                                                new Guid("68233C71-B70A-49F7-BE5B-071AF5A1107F"),
                                                new Guid("6E64447E-98E5-44F6-A021-6939566AAB42")
                                                },
                                            new Guid[] { new Guid(), new Guid() }
                                            ), 

                            // 5+ Players

                            // [Guid("BA118433-A993-4C1D-B31D-FA9D97167442")]
                            new ScienceCard(new Guid("BA118433-A993-4C1D-B31D-FA9D97167442"),
                                            Age.Two,
                                            "Laboratory",
                                            string.Empty,
                                            5,
                                            ScienceType.Tools,
                                            new RawMaterialResourceCost(2,0,0,0),
                                            new ManufacturedMaterialResourceCost(0,0,1),
                                            new Guid[] {
                                                new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"),
                                                new Guid("75F57C08-6490-4171-A281-7ACC82A4296C")
                                                },
                                            new Guid[] { new Guid(), new Guid() }
                                            ), 

                            // 6+ Players

                            // [Guid("F6363E52-C30A-4CE5-AD9D-5CD8962109B9")]
                            new ScienceCard(new Guid("F6363E52-C30A-4CE5-AD9D-5CD8962109B9"),
                                            Age.Two,
                                            "Library",
                                            string.Empty,
                                            8,
                                            ScienceType.Tools,
                                            new RawMaterialResourceCost(0,0,2,0),
                                            new ManufacturedMaterialResourceCost(0,1,0),
                                            new Guid[] {
                                                new Guid("14888B0E-4461-44C5-BE68-537B92009254"),
                                                new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564")
                                                },
                                            new Guid[] { new Guid(), new Guid() }
                                            ), 

                            // 7+ Players

                            // [Guid("211BF055-C108-4CA1-BB24-CECB7CE51D7A")]
                            new ScienceCard(new Guid("211BF055-C108-4CA1-BB24-CECB7CE51D7A"),
                                            Age.Two,
                                            "School",
                                            string.Empty,
                                            7,
                                            ScienceType.Tools,
                                            new RawMaterialResourceCost(0,0,0,1),
                                            new ManufacturedMaterialResourceCost(0,0,1),
                                            null,
                                            new Guid[] { new Guid(), new Guid() }
                                            ), 

                        };

                case Age.Three:

                    // 3+ Players

                    // 4+ Players

                    // 5+ Players

                    // 6+ Players

                    // 7+ Players

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
                                                                RawMaterialResourceCost.Free,
                                                                ManufacturedMaterialResourceCost.Free,
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
                                                                         RawMaterialResourceCost.Free,
                                                                         ManufacturedMaterialResourceCost.Free,
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
                                                                RawMaterialResourceCost.Free,
                                                                ManufacturedMaterialResourceCost.Free,
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
                                                 RawMaterialResourceCost.Free,
                                                 ManufacturedMaterialResourceCost.Free,
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
                                                 RawMaterialResourceCost.Free,
                                                 ManufacturedMaterialResourceCost.Free,
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
                                                                         RawMaterialResourceCost.Free,
                                                                         ManufacturedMaterialResourceCost.Free,
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
                                                                RawMaterialResourceCost.Free,
                                                                ManufacturedMaterialResourceCost.Free,
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
                                                 RawMaterialResourceCost.Free,
                                                 ManufacturedMaterialResourceCost.Free,
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
                                                                RawMaterialResourceCost.Free,
                                                                ManufacturedMaterialResourceCost.Free,
                                                                null,
                                                                new Guid[] { new Guid() }
                                                                ),
             
                        };

                case Age.Two:

                    return new List<ICommerceCard>
                        {
                            // 3+ Players

                            // [Guid("32A9E6DF-DD0D-4276-9B8C-B621CFC0E150")]
                            new CommerceManufactoredMaterialDiscountCard(new Guid("32A9E6DF-DD0D-4276-9B8C-B621CFC0E150"),
                                                                Age.Two,
                                                                "Forum",
                                                                string.Empty,
                                                                3,
                                                                0,
                                                                new ManufactoredMaterialResourceToken[]
                                                                {
                                                                    ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass),
                                                                    ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom),
                                                                    ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus)
                                                                },
                                                                ApplicableDirection.Self,
                                                                new RawMaterialResourceCost(2,0,0,0),
                                                                ManufacturedMaterialResourceCost.Free,
                                                                new Guid[] {
                                                                    new Guid("5AB7812B-AEBE-441D-AFD1-A8C980CD7C30"),
                                                                    new Guid("5C42BD03-B380-4BC2-A8C5-11AC6D4DF827"),
                                                                    new Guid("77CF63AC-9459-4A81-842F-4FF75BC2EC00"),
                                                                    new Guid("D336A613-7752-4666-B09B-A11D189E8FEC"),
                                                                    },
                                                                new Guid[] { new Guid() }
                                                                ),

                            // [Guid("803EE0A5-5B8F-4458-B10A-9CC0CEBC4A21")]
                            new CommerceRawMaterialDiscountCard(new Guid("803EE0A5-5B8F-4458-B10A-9CC0CEBC4A21"),
                                                                Age.Two,
                                                                "Caravansery",
                                                                string.Empty,
                                                                3,
                                                                0,
                                                                new RawMaterialResourceToken[]
                                                                {
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood)
                                                                },
                                                                ApplicableDirection.Self,
                                                                new RawMaterialResourceCost(0,0,0,2),
                                                                ManufacturedMaterialResourceCost.Free,
                                                                new Guid[] {
                                                                    new Guid("2AA1C698-1E66-4EB2-86A7-D9182CBB68EA"),
                                                                    new Guid("927D93A5-02D3-48B5-B77C-55077A4BB8BD"),
                                                                    },
                                                                new Guid[] { new Guid() }
                                                                ),

                            // [Guid("4F33E2AB-50E5-4AB6-A879-FF2346092488")]
                            new CommerceRewardPerSymbolCard(new Guid("4F33E2AB-50E5-4AB6-A879-FF2346092488"),
                                                            Age.Two,
                                                            "Vineyard",
                                                            string.Empty,
                                                            3,
                                                            SymbolType.RawResource,
                                                            0,
                                                            1,
                                                            ApplicableDirection.All,
                                                            RawMaterialResourceCost.Free,
                                                            ManufacturedMaterialResourceCost.Free,
                                                            null,
                                                            null
                                                            ),

                            // 4+ Players

                            // [Guid("2317846F-452F-415A-92CD-30E8E049B6CA")]
                            new CommerceRewardPerSymbolCard(new Guid("2317846F-452F-415A-92CD-30E8E049B6CA"),
                                                            Age.Two,
                                                            "Bazar",
                                                            string.Empty,
                                                            4,
                                                            SymbolType.ManufactoredResource,
                                                            0,
                                                            2,
                                                            ApplicableDirection.All,
                                                            RawMaterialResourceCost.Free,
                                                            ManufacturedMaterialResourceCost.Free,
                                                            null,
                                                            null
                                                            ),

                            // 5+ Players

                            // [Guid("F5B51DBB-C276-4168-89D8-2C7E7EDC67C1")]
                            new CommerceRawMaterialDiscountCard(new Guid("F5B51DBB-C276-4168-89D8-2C7E7EDC67C1"),
                                                                Age.Two,
                                                                "Caravansery",
                                                                string.Empty,
                                                                5,
                                                                0,
                                                                new RawMaterialResourceToken[]
                                                                {
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood)
                                                                },
                                                                ApplicableDirection.Self,
                                                                new RawMaterialResourceCost(0,0,0,2),
                                                                ManufacturedMaterialResourceCost.Free,
                                                                new Guid[] {
                                                                    new Guid("2AA1C698-1E66-4EB2-86A7-D9182CBB68EA"),
                                                                    new Guid("927D93A5-02D3-48B5-B77C-55077A4BB8BD"),
                                                                    },
                                                                new Guid[] { new Guid() }
                                                                ),

                            // 6+ Players

                            // [Guid("BE956900-C1E2-437A-9F89-DFC1A80098BC")]
                            new CommerceRawMaterialDiscountCard(new Guid("BE956900-C1E2-437A-9F89-DFC1A80098BC"),
                                                                Age.Two,
                                                                "Caravansery",
                                                                string.Empty,
                                                                6,
                                                                0,
                                                                new RawMaterialResourceToken[]
                                                                {
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Clay),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Ore),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Stone),
                                                                    RawMaterialResourceToken.GetUnitToken(RawMaterialType.Wood)
                                                                },
                                                                ApplicableDirection.Self,
                                                                new RawMaterialResourceCost(0,0,0,2),
                                                                ManufacturedMaterialResourceCost.Free,
                                                                new Guid[] {
                                                                    new Guid("2AA1C698-1E66-4EB2-86A7-D9182CBB68EA"),
                                                                    new Guid("927D93A5-02D3-48B5-B77C-55077A4BB8BD"),
                                                                    },
                                                                new Guid[] { new Guid() }
                                                                ),

                            // [Guid("21C3FC1E-674B-491C-A3F4-1BF8DFE11916")]
                            new CommerceManufactoredMaterialDiscountCard(new Guid("21C3FC1E-674B-491C-A3F4-1BF8DFE11916"),
                                                                Age.Two,
                                                                "Forum",
                                                                string.Empty,
                                                                6,
                                                                0,
                                                                new ManufactoredMaterialResourceToken[]
                                                                {
                                                                    ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass),
                                                                    ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom),
                                                                    ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus)
                                                                },
                                                                ApplicableDirection.Self,
                                                                new RawMaterialResourceCost(2,0,0,0),
                                                                ManufacturedMaterialResourceCost.Free,
                                                                new Guid[] {
                                                                    new Guid("5AB7812B-AEBE-441D-AFD1-A8C980CD7C30"),
                                                                    new Guid("5C42BD03-B380-4BC2-A8C5-11AC6D4DF827"),
                                                                    new Guid("77CF63AC-9459-4A81-842F-4FF75BC2EC00"),
                                                                    new Guid("D336A613-7752-4666-B09B-A11D189E8FEC"),
                                                                    },
                                                                new Guid[] { new Guid() }
                                                                ),

                            // [Guid("0C1739B9-25B6-4162-B5D9-6B195D1FBBF0")]
                            new CommerceRewardPerSymbolCard(new Guid("0C1739B9-25B6-4162-B5D9-6B195D1FBBF0"),
                                                            Age.Two,
                                                            "Vineyard",
                                                            string.Empty,
                                                            6,
                                                            SymbolType.RawResource,
                                                            0,
                                                            1,
                                                            ApplicableDirection.All,
                                                            RawMaterialResourceCost.Free,
                                                            ManufacturedMaterialResourceCost.Free,
                                                            null,
                                                            null
                                                            ),

                            // 7+ Players

                            // [Guid("DB754303-8F02-49A5-9BAE-0CCEA8B1C64D")]
                            new CommerceRewardPerSymbolCard(new Guid("DB754303-8F02-49A5-9BAE-0CCEA8B1C64D"),
                                                            Age.Two,
                                                            "Bazar",
                                                            string.Empty,
                                                            7,
                                                            SymbolType.ManufactoredResource,
                                                            0,
                                                            2,
                                                            ApplicableDirection.All,
                                                            RawMaterialResourceCost.Free,
                                                            ManufacturedMaterialResourceCost.Free,
                                                            null,
                                                            null
                                                            ),

                            // [Guid("9498113D-1CFE-4EEC-BBDB-0F2497E72C02")]
                            new CommerceManufactoredMaterialDiscountCard(new Guid("9498113D-1CFE-4EEC-BBDB-0F2497E72C02"),
                                                                Age.Two,
                                                                "Forum",
                                                                string.Empty,
                                                                7,
                                                                0,
                                                                new ManufactoredMaterialResourceToken[]
                                                                {
                                                                    ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Glass),
                                                                    ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Loom),
                                                                    ManufactoredMaterialResourceToken.GetUnitToken(ManufactoredMaterialType.Papyrus)
                                                                },
                                                                ApplicableDirection.Self,
                                                                new RawMaterialResourceCost(2,0,0,0),
                                                                ManufacturedMaterialResourceCost.Free,
                                                                new Guid[] {
                                                                    new Guid("5AB7812B-AEBE-441D-AFD1-A8C980CD7C30"),
                                                                    new Guid("5C42BD03-B380-4BC2-A8C5-11AC6D4DF827"),
                                                                    new Guid("77CF63AC-9459-4A81-842F-4FF75BC2EC00"),
                                                                    new Guid("D336A613-7752-4666-B09B-A11D189E8FEC"),
                                                                    },
                                                                new Guid[] { new Guid() }
                                                                ),

                        };

                    throw new NotImplementedException();

                case Age.Three:

                    // 3+ Players

                    // 4+ Players

                    // 5+ Players

                    // 6+ Players

                    // 7+ Players

                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
