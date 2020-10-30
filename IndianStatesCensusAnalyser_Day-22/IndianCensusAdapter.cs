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
        private object coloumn;

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
                string[] coloumn = data.Split(",");
                ///checking if it is indian state code or indian census data by csv extension
                if (csvFilePath.Contains("IndiaStateCensusData.csv"))
                    dataMap.Add(coloumn[1], new CensusDTO(new IndianStateCensusDAO(coloumn[0], coloumn[1], coloumn[2], coloumn[3])));
            }
            return dataMap.ToDictionary(record => record.Key, record => record.Value);
        }

    }
}