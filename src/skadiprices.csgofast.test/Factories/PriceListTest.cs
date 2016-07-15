using System.Collections.Generic;
using skadiprices.csgofast.Models.Json;
using Xunit;
using skadiprices.csgofast.Factories;
using System.Linq;

namespace skadiprices.csgofast.test.Factories
{
    public class PriceListTest
    {
        [Fact]
        public void CountItems()
        {
            var csGoFastRoot = CreateExampleResponse();
            Assert.Equal(4, csGoFastRoot.Prices.Count);
        }

        [Fact]
        public void ArcticCamoPrice()
        {
            var csGoFastRoot = CreateExampleResponse();
            var priceList = PriceListFactory.ConvertCsGoFastRootToPriceList(csGoFastRoot);
            var arcticCamo =
                priceList.Items.FirstOrDefault(
                    element => element.MarketHashName == "G3SG1 | Arctic Camo (Field-Tested)");
            Assert.Equal(new decimal(1.1), arcticCamo.Price);
        }

        [Fact]
        public void FalchionKnifePrice()
        {
            var csGoFastRoot = CreateExampleResponse();
            var priceList = PriceListFactory.ConvertCsGoFastRootToPriceList(csGoFastRoot);
            var falchionKnife =
                priceList.Items.FirstOrDefault(
                    element => element.MarketHashName == "? StatTrak� Falchion Knife | Safari Mesh (Battle-Scarred)");
            Assert.Equal(new decimal(60.01), falchionKnife.Price);
        }

        [Fact]
        public void HuntsmanKnifePrice()
        {
            var csGoFastRoot = CreateExampleResponse();
            var priceList = PriceListFactory.ConvertCsGoFastRootToPriceList(csGoFastRoot);
            var huntsmanKnife =
                priceList.Items.FirstOrDefault(
                    element => element.MarketHashName == "? Huntsman Knife | Blue Steel (Minimal Wear)");
            Assert.Equal(new decimal(88.1), huntsmanKnife.Price);
        }

        [Fact]
        public void AwpPrice()
        {
            var csGoFastRoot = CreateExampleResponse();
            var priceList = PriceListFactory.ConvertCsGoFastRootToPriceList(csGoFastRoot);
            var dragonLore =
                priceList.Items.FirstOrDefault(
                    element => element.MarketHashName == "AWP | Dragon Lore (Factory New)");
            Assert.Equal(new decimal(1579.86), dragonLore.Price);
        }

        private static CsGoFastRoot CreateExampleResponse()
        {
            CsGoFastRoot csGoFastRoot = new CsGoFastRoot();
            csGoFastRoot.Bots = new List<string>
            {
                "76561198278382140",
                "76561198279565017",
                "76561198279762506",
                "76561198289357862"
            };

            csGoFastRoot.Prices = new Dictionary<string, decimal>()
            {
                { "G3SG1 | Arctic Camo (Field-Tested)", new decimal(1.1) },
                { "? StatTrak� Falchion Knife | Safari Mesh (Battle-Scarred)", new decimal(60.01) },
                { "? Huntsman Knife | Blue Steel (Minimal Wear)", new decimal(88.1) },
                { "AWP | Dragon Lore (Factory New)", new decimal(1579.86) }
            };
            return csGoFastRoot;
        }
    }
}
