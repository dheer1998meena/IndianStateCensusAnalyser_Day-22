
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------using IndianStatesCensusAnalyser_Day_22.DAO;
using IndianStatesCensusAnalyser_Day_22.DAO;
using IndianStatesCensusAnalyser_Day_22.DTO;
using System.Collections.Generic;
using System.Linq;

namespace IndianStatesCensusAnalyser_Day_22
{
    /// <summary>
    /// Creating Indian Census Adapter class.
    /// </summary>
    class IndianCensusAdapter : CensusAdapter
    {
        //adding data into the datMap with name as the key of the dictionary.
        string[] censusData;
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            // census data will have data stored in array form used function get census data to extract data.
            dataMap = new Dictionary<string, CensusDTO>();
            censusData = GetCensusData(csvFilePath, dataHeaders);
            //iterating foreach loop and skip the header from loop.
            foreach (string data in censusData.Skip(1))
            {
                if (!data.Contains(","))
                {
                    throw new CensusAnalyserException("File Contains Wrong Delimiter", CensusAnalyserException.Exception.INCOREECT_DELIMITER);
                }
                ///spliting data which is splitted by commma.
                string[] column = data.Split(",");
                if (csvFilePath.Contains("IndiaStateCensusData.csv"))
                    dataMap.Add(column[1], new CensusDTO(new IndianStateCensusDAO(column[0], column[1], column[2], column[3])));
            }
            return dataMap.ToDictionary(record => record.Key, record => record.Value);
        }

    }
}