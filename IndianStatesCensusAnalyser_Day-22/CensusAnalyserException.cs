// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyser_Day_22
{
    /// <summary>
    /// Creating a CensusAnalyserException class.
    /// </summary>
    public class CensusAnalyserException : Exception
    {
        public Exception exception;
        // enum class for different exceptions.
        public enum Exception
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_HEADER,
            NO_SUCH_COUNTRY,
            INCOREECT_DELIMITER
        }
        public CensusAnalyserException(string message, Exception exception) : base(message)//base message is passed to overide the message 
        {
            this.exception = exception;
        }
    }
}
