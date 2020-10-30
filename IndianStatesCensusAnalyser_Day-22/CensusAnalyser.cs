// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using IndianStatesCensusAnalyser_Day_22.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyser_Day_22
{
    /// <summary>
    /// Creating Census Analyser class to  helps to load csv data 
    /// </summary>
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US
        }
        // creating a datamap to store data from csv file in the form of a dictionary 
        public Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            /// creating a direct instance of class and calling function loadcsvdata 
            ///loadcsv calls function based on different countries .
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
