// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System.IO;

namespace IndianStatesCensusAnalyser_Day_22
{
    /// <summary>
    /// Creating Census Adapter class as a base class.
    /// </summary>
    public class CensusAdapter
    {
        public string[] GetCensusData(string csvFilePath, string dataHeaders)
        {
            // gives data in array form. 
            string[] censusData;
            //checking if file exists otherwise exception is thrown 
            if (!File.Exists(csvFilePath))
                throw new CensusAnalyserException("File Not Found", CensusAnalyserException.Exception.FILE_NOT_FOUND);
            //checking if has correct file path  otherwise exception is thrown 
            if (Path.GetExtension(csvFilePath) != ".csv")
                throw new CensusAnalyserException("Invalid file type", CensusAnalyserException.Exception.INVALID_FILE_TYPE);
            //Reading all line and storing in censuData Array.
            censusData = File.ReadAllLines(csvFilePath);
            //checking if headers are correct otherwise exception is thrown 
            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException("Incorrect header", CensusAnalyserException.Exception.INCORRECT_HEADER);
            }
            return censusData;
        }
    }
}