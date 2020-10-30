// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyser_Day_22.DAO
{
    /// <summary>
    /// Indian  State Census DAO
    /// </summary>
    public class IndianStateCensusDAO
    {
        public string state;
        public long population;
        public long area;
        public long density;

        /// <summary>
        /// Creating Parameterized constructor for Indian State Census DAO.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="population"></param>
        /// <param name="area"></param>
        /// <param name="density"></param>
        public IndianStateCensusDAO(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = Convert.ToUInt32(population);
            this.area = Convert.ToUInt32(area);
            this.density = Convert.ToUInt32(density);
        }

    }
}
