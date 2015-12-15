using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Tax {
    public class VATTAXCalculator {
        List<CountryVATTAX> list;

        public VATTAXCalculator(List<CountryVATTAX> list) {
            this.list = list;
        }

        public double CalculateTax(double price, string countryId) {
            double tax = 0;
            foreach (var item in list) {
                if (item.CountryId == countryId) {
                    tax = price * (1 + item.VATTAX) - price;
                }
            }
            if (tax != 0) {
                return tax;
            }
            else {
                throw new NotSupportedCountryException("NotSupportedCountryException");
            }
        }

        public double CalculateTax(double price) {
            double tax = 0;
            foreach (var item in list) {
                if (item.ISDefault) {
                    tax = price * (1 + item.VATTAX) - price;
                    break;
                }
            }
            if (tax != 0) {
                return tax;
            }
            else {
                throw new NotSupportedCountryException("NotSupportedCountryException");
            }
        }

        [Serializable]
        private class NotSupportedCountryException : Exception {
            public NotSupportedCountryException() {
            }

            public NotSupportedCountryException(string message) : base(message) {
            }

            public NotSupportedCountryException(string message, Exception innerException) : base(message, innerException) {
            }

            protected NotSupportedCountryException(SerializationInfo info, StreamingContext context) : base(info, context) {
            }
        }
    }
}
