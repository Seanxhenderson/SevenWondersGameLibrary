﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary
{
    public static class CardLookupLibrary
    {
        private static Dictionary<Guid, string> masterDictionary = null;

        static CardLookupLibrary()
        {
            masterDictionary = new Dictionary<Guid, string>()
            {
                #region RawMaterials

                { new Guid("B641FEE1-09B1-4F96-9263-77F02207EAC0"), "[1/2][1] Clay Pool" },
                { new Guid("D108F412-C1C1-4C49-A1AA-3990DB08C4A9"), "[2/2][1] Clay Pool" },

                { new Guid("34C1474A-4E2C-419D-AD78-FE03E503C55F"), "[1/2][1] Ore Vein" },
                { new Guid("599CA9E0-7B29-458A-96BE-C6DC555D69DC"), "[2/2][1] Ore Vein" },

                { new Guid("29B8C759-2EF0-46B7-8E96-AAB9F370713D"), "[1/2][1] Stone Pit" },
                { new Guid("77A22B31-647C-4912-8719-FAE0AE430D64"), "[2/2][1] Stone Pit" },

                { new Guid("7F8C64D4-248D-46DC-8844-30F92C4D149C"), "[1/2][1] Lumber Yard" },
                { new Guid("11A77ADE-7BBB-41F9-AA12-D8B3F9785AE4"), "[2/2][1] Lumber Yard" },

                { new Guid("9B63055B-FD4E-4DB5-8E04-FFF449B91A18"), "[1/1][1] Timber Yard" },

                { new Guid("11AC4FF0-AFD2-4C0A-AAC9-2D4662E0A9FF"), "[1/1][1] Clay Pit" },

                { new Guid("F4A33E8B-CE82-4CBA-BC82-15D65110CD74"), "[1/1][1] Excavation" },

                { new Guid("7202550E-97DF-4351-AF51-10D40201527F"), "[1/1][1] Forest Cave" },

                { new Guid("B5CD9B61-097E-4663-9C31-EAF1745980B0"), "[1/1][1] Mine" },

                { new Guid("358008D1-97DA-4417-A99A-EDDE314F292C"), "[1/1][1] Tree Farm" },

                { new Guid("DF5D7F5E-84E2-472E-81E5-F756834B5509"), "[1/2][1] Brickyard" },
                { new Guid("17B8E3BD-22F3-46D2-90D0-7F3543C35260"), "[2/2][1] Brickyard" },

                { new Guid("1951DC1D-38B9-41E2-AFC7-87EEDB47DF67"), "[1/2][1] Foundry" },
                { new Guid("FCF68028-FF22-48FD-B062-0DE01E028D54"), "[2/2][1] Foundry" },

                { new Guid("75E1136B-8C00-4E19-8336-1FABB812928B"), "[1/2][1] Quarry" },
                { new Guid("54748C79-33FF-4A78-9667-1B86BD7E7B12"), "[2/2][1] Quarry" },

                { new Guid("E97A76FE-F10B-4999-A2CE-85CDAD6B8080"), "[1/2][1] Sawmill" },
                { new Guid("C462B76D-A1EC-4507-B412-BF60347F39B1"), "[2/2][1] Sawmill" },

                #endregion //RawMaterials

                #region ManufactoredMaterials

                { new Guid("E610E2E7-F30A-4FDB-8DAB-00E0D8C6A6D6"), "[1/4][1] Loom" },
                { new Guid("05D7304F-80DA-48C7-90F4-2E00475CA4F8"), "[2/4][1] Loom" },
                { new Guid("AFD1B3CF-5921-4D69-969E-ED2EC4C16AA4"), "[3/4][1] Loom" },
                { new Guid("2CC2E7E9-0300-4A02-9C17-0FBBF77EFD4C"), "[4/4][1] Loom" },

                { new Guid("61A08FF8-C905-4259-83CD-A0E4D66AE12B"), "[1/4][1] Press" },
                { new Guid("1B529178-81CD-4FC8-B6CE-86DE5C625521"), "[2/4][1] Press" },
                { new Guid("76CFAC99-D7B6-4293-AFA0-FA93D1391B77"), "[3/4][1] Press" },
                { new Guid("396AE8C5-1DFC-44B9-8E65-17081CC3F2BA"), "[4/4][1] Press" },

                { new Guid("54F7A0D8-A5FC-45F4-9E88-E885E44CCBC1"), "[1/4][1] Glassworks" },
                { new Guid("C2EDCFA8-3892-4488-922C-DD1F5AF55432"), "[2/4][1] Glassworks" },
                { new Guid("B13346D8-D762-4B7F-AEA3-3A0E57448FA5"), "[3/4][1] Glassworks" },
                { new Guid("AB82D078-CB56-43A2-801B-F1C386431517"), "[4/4][1] Glassworks" },

                #endregion //ManufactoredMaterials

                #region Culture

                { new Guid("1343C1C1-A58F-4E18-B1ED-E607253E8B53"), "[1/2][1] Baths" },
                { new Guid("F17E03AE-7EE6-4074-801E-EBEE4EFCA2EB"), "[2/2][1] Baths" },

                { new Guid("5DBC3B9A-DAD1-42AF-87D7-FFA7543E28FF"), "[1/2][1] Altar" },
                { new Guid("72584E71-E892-470E-BBCC-004EFC1775EB"), "[2/2][1] Altar" },

                { new Guid("F0563D95-587C-4418-AF6F-16AC646BBFB1"), "[1/2][1] Theater" },
                { new Guid("2158F63E-B3B9-4A09-BEF9-7D5198B5C72A"), "[2/2][1] Theater" },

                { new Guid("D4B99FFD-010D-4F7D-8DD5-30552D67B1F9"), "[1/2][1] Pawnshop" },
                { new Guid("6F748053-0777-4A9C-A84A-6192F0ADAD2A"), "[2/2][1] Pawnshop" },

                { new Guid("90F497BA-6801-4699-BCAB-7141DA3CD96E"), "[1/2][1] Aqueduct" },
                { new Guid("9DF416F1-ACF3-471E-BEA3-BC0996A57300"), "[2/2][1] Aqueduct" },

                { new Guid("08086CDA-BDE4-4C26-9393-B6ED2D6EF6FE"), "[1/2][1] Statue" },
                { new Guid("2152CB67-F432-4E7E-B4A8-A4B6DEFCF9D9"), "[2/2][1] Statue" },

                { new Guid("3D1932E6-3A00-4EB4-A2E9-6476891AC4BE"), "[1/2][1] Courthouse" },
                { new Guid("268573A7-894B-4EB7-AAEC-707CC92AF9FD"), "[2/2][1] Courthouse" },

                { new Guid("CB97CA9A-63A4-4D1C-90E1-D2FB22FA7AB1"), "[1/2][1] Temple" },
                { new Guid("CC884286-D176-4138-B30C-B25D5D032AF8"), "[2/2][1] Temple" },

                #endregion //Culture

                #region Military

                { new Guid("1CF9F9AA-78EC-4460-8705-FF5333214F2D"), "[1/2][1] Guard Tower" },
                { new Guid("0F72ABFD-0AC8-48F0-A74F-D83BBC704155"), "[2/2][1] Guard Tower" },

                { new Guid("EBFCDF1D-6A68-410F-A460-D9DC992CD39E"), "[1/2][1] Stockade" },
                { new Guid("92BECA99-515A-4A1F-AF3C-003399915561"), "[2/2][1] Stockade" },

                { new Guid("88B14BFD-13A6-4349-8CDC-0A609E64CF84"), "[1/2][1] Barracks" },
                { new Guid("C3BB1D7E-B862-44FD-8743-9ACD5B37EC71"), "[2/2][1] Barracks" },

                { new Guid("29476E9F-6C5D-4F79-86A3-80A7E83D76BA"), "[1/2][1] Stables" },
                { new Guid("C99158E5-A008-43D7-8660-AD532A803CCF"), "[2/2][1] Stables" },

                { new Guid("03BE5384-FB1D-47F1-A235-E62BED13C697"), "[1/2][1] Archery Range" },
                { new Guid("DABA8686-0BA4-4EDE-9297-F385F64BF9A5"), "[2/2][1] Archery Range" },

                { new Guid("CCE6E9DC-1687-4BE7-8939-461DD96440AF"), "[1/2][1] Walls" },
                { new Guid("450AEC85-B216-4026-B759-46013E608983"), "[2/2][1] Walls" },

                { new Guid("51FCDE3C-119E-4A16-82A0-BD8D617A6D49"), "[1/3][1] Training Ground" },
                { new Guid("533A08A0-B6AF-4468-9773-79161BEDFD7B"), "[2/3][1] Training Ground" },
                { new Guid("3FAFF4F3-806F-49DC-8AA5-13814745ABC2"), "[3/3][1] Training Ground" },
                
                #endregion //Military

                #region Science

                { new Guid("68233C71-B70A-49F7-BE5B-071AF5A1107F"), "[1/2][1] Apothecary" },
                { new Guid("6E64447E-98E5-44F6-A021-6939566AAB42"), "[2/2][1] Apothecary" },

                { new Guid("14888B0E-4461-44C5-BE68-537B92009254"), "[1/2][1] Scriptorium" },
                { new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"), "[2/2][1] Scriptorium" },

                { new Guid("75DAB02F-21B7-4C16-8EB3-760F2224E564"), "[1/2][1] Workshop" },
                { new Guid("75F57C08-6490-4171-A281-7ACC82A4296C"), "[2/2][1] Workshop" },

                #endregion //Science

                #region Commerce

                { new Guid("5AB7812B-AEBE-441D-AFD1-A8C980CD7C30"), "[1/2][1] East Trading Post" },
                { new Guid("5C42BD03-B380-4BC2-A8C5-11AC6D4DF827"), "[2/2][1] East Trading Post" },

                { new Guid("2AA1C698-1E66-4EB2-86A7-D9182CBB68EA"), "[1/2][1] Marketplace" },
                { new Guid("927D93A5-02D3-48B5-B77C-55077A4BB8BD"), "[2/2][1] Marketplace" },

                { new Guid("77CF63AC-9459-4A81-842F-4FF75BC2EC00"), "[1/2][1] West Trading Post" },
                { new Guid("D336A613-7752-4666-B09B-A11D189E8FEC"), "[2/2][1] West Trading Post" },

                { new Guid("64F1F39D-215F-4626-AB45-CD375F423966"), "[1/3][1] Tavern" },
                { new Guid("26A7245F-2017-482E-9DC1-43E68D046EDF"), "[2/3][1] Tavern" },
                { new Guid("2B4EDF1F-27DB-4B66-8CE1-5699E1DB1CA5"), "[3/3][1] Tavern" },

                #endregion //Commerce

                #region Guild

                #endregion //Guild
            };
        }

        public static string GetCard(Guid id)
        {
            return masterDictionary[id];
        }
    }
}
