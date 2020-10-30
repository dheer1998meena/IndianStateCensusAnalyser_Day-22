// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using NUnit.Framework;
using IndianStatesCensusAnalyser_Day_22;
using System.Collections.Generic;
using IndianStatesCensusAnalyser_Day_22.DTO;

namespace NUnitTestProject1
{
    public class Tests
    {
        /// <summary>
        /// Declaring paths for all the csv files
        /// </summary>
        public static string indianCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        public static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        public static string indianStateCensusFilePath = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles\IndiaStateCensusData.csv";
        public static string indianStateCodeFilePath = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles\IndiaStateCode.csv";
        public static string wrongHeaderIndianStateCensusFilePath = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles\WrongIndiaStateCensusData.csv";
        public static string wrongHeaderIndianStateCodeFilePath = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles\WrongIndiaStateCode.csv";
        public static string wrongIndianStateCensusFilePath = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles1\WrongIndiaStateCensusData.csv";
        public static string wrongIndianStateCodeFilePath = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles1\WrongIndiaStateCode.csv";
        public static string wrongIndianStateCensusFileType = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles\IndiaStateCensusData.txt";
        public static string wrongIndianStateCodeFileType = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles\IndiaStateCode.txt";
        public static string delimeterIndianStateCensusFilePath = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles\DelimiterIndiaStateCensusData.csv";
        public static string delimeterIndianStateCodeFilePath = @"C:\Users\dheer1998meena\source\repos\IndianStatesCensusAnalyser_Day-22\IndianStatesCensusAnalyser_Day-22\CSVFiles\DelimiterIndiaStateCode.csv";

        ///instantiating an object for census analyser and dictionaries.
        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }
        /// <summary>
        /// UC1.1 Given Indian State Census File Should Return Indian State Census Count.
        /// </summary>
        [Test]
        public void GivenIndianStateCensusFile_ShouldReturnIndianStateCensusCount()
        {
            ///Act
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, indianCensusHeaders);
            ///Assert
            Assert.AreEqual(29, totalRecord.Count);
        }
        /// <summary>
        ///UC1.2 Given Wrong Indian State Census File Should Thrown Census Analyser Exception
        /// </summary>
        [Test]
        public void GivenWrongIndianStateCensusFile_ShouldThrownCensusAnalyserException()
        {
            ///Act
            var indianStateCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFilePath, indianCensusHeaders));
            ///Assert
            Assert.AreEqual(CensusAnalyserException.Exception.FILE_NOT_FOUND, indianStateCensusResult.exception);
        }
        /// <summary>
        ///UC1.3 Given Worng Indian State Census FileType Should Thrown Census Analyser Exception
        /// </summary>
        [Test]
        public void GivenWrongIndianStateCensusFileType_ShouldThrownCensusAnalyserException()
        {
            ///Act
            var indianStateCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFileType, indianCensusHeaders));
            ///Assert
            Assert.AreEqual(CensusAnalyserException.Exception.INVALID_FILE_TYPE, indianStateCensusResult.exception);
        }
        /// <summary>
        ///UC1.4 Given Incorrect Indian State Census Delimeter file type Should Thrown Census Analyser Exception
        /// </summary>
        [Test]
        public void GivenIncorrectIndianStateCensusDelimeterFileType_ShouldThrownCensusAnalyserException()
        {
            //Act
            var indianStateCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, delimeterIndianStateCensusFilePath, indianCensusHeaders));
            //Assert
            Assert.AreEqual(CensusAnalyserException.Exception.INCOREECT_DELIMITER, indianStateCensusResult.exception);
        }
        /// <summary>
        ///UC1.5 Given Incorrect Indian State Census file Header type Should Thrown Census Analyser Exception
        /// </summary>
        [Test]
        public void GivenIncorrectIndianStateCensusFileHeaderType_ShouldThrownCensusAnalyserException()
        {
            //Act
            var indianStateCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, wrongHeaderIndianStateCensusFilePath));
            //Assert
            Assert.AreEqual(CensusAnalyserException.Exception.INCORRECT_HEADER, indianStateCensusResult.exception);
        }

    }
}