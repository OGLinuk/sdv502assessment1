using System;
using FastwayCourier;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDV502FastwayCourierTests {

    // Zone Destinations

    [TestClass]
    public class SelectingAZoneDestination_Should {

        // Pink Zone

        [TestMethod]
        public void ReturnPinkZone_WhenPictonIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Picton");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenBlenheimIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Blenheim");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenRenwickIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Renwick");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenAtawhaiIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Atawhai");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenNelsonIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Nelson");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenMaitaiIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Maitai");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenHopeIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Hope");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenBrightwaterIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Brightwater");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenWakefieldIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Wakefield");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenMapuaIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Mapua");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        [TestMethod]
        public void ReturnPinkZone_WhenMotuekaIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string pinkZoneDestination = fastwayCourier.GetDestinationZone("Motueka");

            // Assert
            Assert.AreEqual("Pink", pinkZoneDestination);
        }

        // Blue Zone

        [TestMethod]
        public void ReturnBlueZone_WhenSeddonIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string blueZoneDestination = fastwayCourier.GetDestinationZone("Seddon");

            // Assert
            Assert.AreEqual("Blue", blueZoneDestination);
        }

        [TestMethod]
        public void ReturnBlueZone_WhenWardIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string blueZoneDestination = fastwayCourier.GetDestinationZone("Ward");

            // Assert
            Assert.AreEqual("Blue", blueZoneDestination);
        }

        [TestMethod]
        public void ReturnBlueZone_WhenWaihopaiValleyIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string blueZoneDestination = fastwayCourier.GetDestinationZone("Waihopai Valley");

            // Assert
            Assert.AreEqual("Blue", blueZoneDestination);
        }

        [TestMethod]
        public void ReturnBlueZone_WhenRiwakaIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string blueZoneDestination = fastwayCourier.GetDestinationZone("Riwaka");

            // Assert
            Assert.AreEqual("Blue", blueZoneDestination);
        }

        [TestMethod]
        public void ReturnBlueZone_WhenTakakaIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string blueZoneDestination = fastwayCourier.GetDestinationZone("Takaka");

            // Assert
            Assert.AreEqual("Blue", blueZoneDestination);
        }

        // Lime Zone

        [TestMethod]
        public void ReturnLimeZone_WhenNelsonLakesNationalParksIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string limeZoneDestination = fastwayCourier.GetDestinationZone("NelsonLakesNationalParks");

            // Assert
            Assert.AreEqual("Lime", limeZoneDestination);
        }

        [TestMethod]
        public void ReturnLimeZone_WhenMurchisonIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string limeZoneDestination = fastwayCourier.GetDestinationZone("Murchison");

            // Assert
            Assert.AreEqual("Lime", limeZoneDestination);
        }

        // Orange Zone

        [TestMethod]
        public void ReturnOrangeZone_WhenKaikouraIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string orangeZoneDestination = fastwayCourier.GetDestinationZone("Kaikoura");

            // Assert
            Assert.AreEqual("Orange", orangeZoneDestination);
        }

        [TestMethod]
        public void ReturnOrangeZone_WhenHanmerSpringsIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string orangeZoneDestination = fastwayCourier.GetDestinationZone("Hanmer Springs");

            // Assert
            Assert.AreEqual("Orange", orangeZoneDestination);
        }

        [TestMethod]
        public void ReturnOrangeZone_WhenReeftonIsSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string orangeZoneDestination = fastwayCourier.GetDestinationZone("Reefton");

            // Assert
            Assert.AreEqual("Orange", orangeZoneDestination);
        }

        // Non-Zone

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ThrowException_WhenNonZoneDestinationSelected() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            string nonZoneDestination = fastwayCourier.GetDestinationZone("Winterfell");

            // Assert
            string[] zones = { "Pink", "Blue", "Lime", "Orange" };
            foreach (var zone in zones) {
                Assert.AreEqual(zone, nonZoneDestination);
            }
        }
    }

    // Pink Zone Quote

    [TestClass]
    public class CalculatingAPinkZoneQuote_Should {

        [TestMethod]
        public void Return_4_15_WhenParcelPropertiesWithinLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int rngLegalWeight = new Random().Next(1, 25);
            decimal parcelPrice = 4.15m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Nelson");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(rngLegalWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMinimumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMinWeight = 0.0m;
            decimal parcelPrice = 4.15m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Nelson");
            ParcelQuoteResult parcelMinQuote = fastwayCourier.CalculateQuote(nonLegalMinWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelMinQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMaximumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxWeight = 25.7m;
            decimal parcelPrice = 4.15m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Nelson");
            ParcelQuoteResult parcelMaxQuote = fastwayCourier.CalculateQuote(nonLegalMaxWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelMaxQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMinimumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMinVolume = 0.000m;
            decimal legalMinVolume = 0.001m;

            // Assert
            Assert.AreEqual(legalMinVolume, nonLegalMinVolume);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMaximumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxVolume = 0.126m;
            decimal legalMaxVolume = 0.125m;

            // Assert 
            Assert.AreEqual(legalMaxVolume, nonLegalMaxVolume);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelLabelCountIsOutsideMinimumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int nonLegalMinLabelCount = 0;
            int legalMinLabelCount = 1;

            // Assert
            Assert.AreEqual(legalMinLabelCount, nonLegalMinLabelCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelLabelCountIsOutsideMaximumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int nonLegalMaxLabelCount = 2;
            int legalMaxLabelCount = 1;

            // Assert
            Assert.AreEqual(legalMaxLabelCount, nonLegalMaxLabelCount);
        }
    }

    // Blue Zone Quote

    [TestClass]
    public class CalculatingABlueZoneQuote_Should {

        [TestMethod]
        public void Return_6_95_WhenParcelPropertiesWithinLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int rngLegalWeight = new Random().Next(1, 25);
            decimal parcelPrice = 6.95m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Riwaka");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(rngLegalWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMinimumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMinWeight = 0.0m;
            decimal parcelPrice = 4.15m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Riwaka");
            ParcelQuoteResult parcelMinQuote = fastwayCourier.CalculateQuote(nonLegalMinWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelMinQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMaximumLegalBoundaires() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxWeight = 28.9m;
            decimal parcelPrice = 4.15m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Riwaka");
            ParcelQuoteResult parcelMinQuote = fastwayCourier.CalculateQuote(nonLegalMaxWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelMinQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMinimumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMinVolume = 0.000m;
            decimal legalMinVolume = 0.001m;

            // Assert
            Assert.AreEqual(legalMinVolume, nonLegalMinVolume);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMaximumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxVolume = 0.129m;
            decimal legalMaxVolume = 0.125m;

            // Assert 
            Assert.AreEqual(legalMaxVolume, nonLegalMaxVolume);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelLabelCountIsOutsideMinimumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int nonLegalMinLabelCount = 0;
            int legalMinLabelCount = 1;

            // Assert
            Assert.AreEqual(legalMinLabelCount, nonLegalMinLabelCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelLabelCountIsOutsideMaximumLegalBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int nonLegalMaxLabelCount = 5;
            int legalMaxLabelCount = 1;

            // Assert
            Assert.AreEqual(legalMaxLabelCount, nonLegalMaxLabelCount);
        }
    }

    // Lime Zone Quote

    [TestClass]
    public class CalculatingALimeZoneQuote_Should {

        [TestMethod]
        public void Return_8_70_WhenParcelPropertiesWithinLegalLowerBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int rngLegalLowerBoundWeight = new Random().Next(1, 15);
            decimal parcelPrice = 8.70m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Murchison");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(rngLegalLowerBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        public void Return_OneTicket_WhenParcelPropertiesWithinLegalUpperBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int rngLegalUpperBoundWeight = new Random().Next(16, 25);
            byte legalExcessTicket = 1;
            string zoneDestination = fastwayCourier.GetDestinationZone("Murchison");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(rngLegalUpperBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(legalExcessTicket, parcelQuote.ExcessTickets);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMinimumLegalLowerBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMinLowerBoundWeight = 0.0m;
            decimal parcelPrice = 8.70m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Murchison");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(nonLegalMinLowerBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMaximumLegalLowerBoundairesWithNoExcessLabel() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxLowerBoundWeight = 15.7m;
            decimal parcelPrice = 14.90m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Murchison");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(nonLegalMaxLowerBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMaximumLegalUpperBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxUpperBoundWeight = 27.3m;
            decimal parcelPrice = 14.90m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Murchison");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(nonLegalMaxUpperBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMinimumLegalLowerBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMinLowerBoundVolume = 0.000m;
            decimal legalMinLowerBoundVolume = 0.001m;

            // Assert 
            Assert.AreEqual(legalMinLowerBoundVolume, nonLegalMinLowerBoundVolume);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMaximumLegalLowerBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxLowerBoundVolume = 0.079m;
            decimal legalMaxLowerBoundVolume = 0.075m;

            // Assert
            Assert.AreEqual(legalMaxLowerBoundVolume, nonLegalMaxLowerBoundVolume);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMaximumLegalUpperBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxUpperBoundVolume = 0.126m;
            decimal legalMaxUpperBoundVolume = 0.125m;

            // Assert
            Assert.AreEqual(legalMaxUpperBoundVolume, nonLegalMaxUpperBoundVolume);
        }
    }

    // Orange Zone Quote

    [TestClass]
    public class CalculatingAOrangeZoneQuote_Should {

        [TestMethod]
        public void Return_12_95_WhenParcelPropertiesWithinLegalLowerBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int rngLegalLowerBoundWeight = new Random().Next(1, 15);
            decimal parcelPrice = 12.95m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Reefton");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(rngLegalLowerBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        public void Return_OneTicket_WhenParcelPropertiesWithinLegalUpperBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int rngLegalUpperBoundWeight = new Random().Next(16, 20);
            byte legalExcessTicket = 1;
            string zoneDestination = fastwayCourier.GetDestinationZone("Reefton");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(rngLegalUpperBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(legalExcessTicket, parcelQuote.ExcessTickets);
        }

        [TestMethod]
        public void Return_TwoTickets_WhenParcelPropertiesWithinLegalUpperBoundariesAndExceedsOneTicketWeightBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            int rngLegalUpperBoundWeight = new Random().Next(21, 25);
            byte legalExcessTicket = 2;
            string zoneDestination = fastwayCourier.GetDestinationZone("Reefton");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(rngLegalUpperBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(legalExcessTicket, parcelQuote.ExcessTickets);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMinimumLegalLowerBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMinLowerBoundWeight = 0.0m;
            decimal parcelPrice = 12.95m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Reefton");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(nonLegalMinLowerBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMaximumLegalLowerBoundairesWithNoExcessLabel() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxLowerBoundWeight = 15.4m;
            decimal parcelPrice = 12.95m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Reefton");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(nonLegalMaxLowerBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelWeightIsOutsideMaximumLegalUpperBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxUpperBoundWeight = 26.1m;
            decimal parcelPrice = 19.15m;
            string zoneDestination = fastwayCourier.GetDestinationZone("Reefton");
            ParcelQuoteResult parcelQuote = fastwayCourier.CalculateQuote(nonLegalMaxUpperBoundWeight, zoneDestination);

            // Assert
            Assert.AreEqual(parcelPrice, parcelQuote.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMinimumLegalLowerBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMinLowerBoundVolume = 0.000m;
            decimal legalMinLowerBoundVolume = 0.001m;

            // Assert 
            Assert.AreEqual(legalMinLowerBoundVolume, nonLegalMinLowerBoundVolume);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMaximumLegalLowerBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxLowerBoundVolume = 0.077m;
            decimal legalMaxLowerBoundVolume = 0.075m;

            // Assert
            Assert.AreEqual(legalMaxLowerBoundVolume, nonLegalMaxLowerBoundVolume);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Fail_WhenParcelVolumeIsOutsideMaximumLegalUpperBoundaries() {
            // Arrange
            ParcelQuoteFromNelson fastwayCourier = new ParcelQuoteFromNelson();

            // Act
            decimal nonLegalMaxLowerBoundVolume = 0.129m;
            decimal legalMaxLowerBoundVolume = 0.125m;

            // Assert
            Assert.AreEqual(legalMaxLowerBoundVolume, nonLegalMaxLowerBoundVolume);
        }
    }
}
