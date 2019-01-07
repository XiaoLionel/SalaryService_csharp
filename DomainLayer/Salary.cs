using System;
using System.Collections.Generic;

namespace DomainLayer
{
    /// <summary>
    ///  Salary classes
    /// </summary>
    public class Salary : IAggregateRoot
    {
        #region properties
        public DateTime BirthDate { get; private set; }

        public DateTime EffectiveDate { get; private set; }

        public List<Name> Firstnames { get; private set; }

        public Guid Id { get; set; }

        public string SalaryCompanyNumber { get; private set; }

        public List<Name> Surnames { get; private set; }

        #endregion

        #region constructor
        /// <summary>
        /// Constructor of the Name class
        /// </summary>
        /// <param name="id">The unique Id</param>
        /// <param name="firstnames">List of firstnames</param>
        /// <param name="surnames">List of surnames</param>
        /// <param name="birthDate">Salary Birth date</param>
        /// <param name="salaryCompanyNumber">Salary serial number in the company</param>
        /// <param name="effectiveDate">Salary Effective date in the company</param>
        public Salary(Guid id, List<Name> firstnames, List<Name> surnames, DateTime birthDate, string salaryCompanyNumber, DateTime effectiveDate)
        {
            Id = id;
            Firstnames = firstnames;
            Surnames = surnames;
            BirthDate = birthDate;
            SalaryCompanyNumber = salaryCompanyNumber;
            EffectiveDate = effectiveDate;
        }
        #endregion

        #region methods
        #endregion
    }
}
