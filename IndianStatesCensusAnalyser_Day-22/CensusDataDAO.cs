using IndianStatesCensusAnalyser_Day_22.DAO;

namespace IndianStatesCensusAnalyser_Day_22
{
    internal class CensusDataDAO : IndianStateCensusDAO
    {
        public CensusDataDAO(string state, string population, string area, string density) : base(state, population, area, density)
        {
        }
    }
}