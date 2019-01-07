using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    /// <summary>
    /// ValueObject which represents salary name (firstname, second name, surnames, ...)
    /// </summary>
    public class Name : ValueObject<Name>
    {
        #region properties
        public int Order { get; private set; }

        public TypeNameEnum Type { get; private set; }

        public string Value { get; private set; }
        #endregion

        #region constructor
        /// <summary>
        /// Constructor of the Name class
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="type">The type of name</param>
        /// <param name="order">The order priority</param>
        public Name(string name, TypeNameEnum type, int order)
        {
            Value = name;
            Type = type;
            Order = order;
        }
        #endregion

        #region methods
        protected override bool EqualsCore(Name other)
        {
            return this.Value == other.Value && this.Type == other.Type;
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
