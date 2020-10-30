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
    /// Creating CSV Adapter Factory class.
    /// </summary>
    public class CSVAdapterFactory
    {
        // Load different csv file according to different countries.
        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndianCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusAnalyserException("No Such Country found", CensusAnalyserException.Exception.NO_SUCH_COUNTRY);
            }

        }
    }
}