// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using IndianStatesCensusAnalyser_Day_22.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyser_Day_22.DTO
{

    /// <summary>
    /// Creating CensusDTO
    /// </summary>
    public class CensusDTO
    {
        // All the variables related to all file types
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public double totalArea;
        public double waterArea;
        public double landArea;
        /// <summary>
        /// Creating a parameterized Constructor for Indian State Census DAO.
        /// </summary>
        /// <param name="indianStateCensusDAO"></param>
        public CensusDTO(IndianStateCensusDAO indianStateCensusDAO)
        {
            this.state = indianStateCensusDAO.state;
            this.population = indianStateCensusDAO.population;
            this.area = indianStateCensusDAO.area;
            this.density = indianStateCensusDAO.density;
        }
        /// <summary>
        ///  Creating a parameterized Constructor for Indian State Census DAO.
        /// </summary>
        /// <param name="censusDataDAO"></param>
        public CensusDTO(StateCodeDataDAO stateCodeDataDAO)
        {
            this.serialNumber = stateCodeDataDAO.serialNumber;
            this.stateName = stateCodeDataDAO.stateName;
            this.tin = stateCodeDataDAO.tin;
            this.stateCode = stateCodeDataDAO.stateCode;
        }
    }
}
