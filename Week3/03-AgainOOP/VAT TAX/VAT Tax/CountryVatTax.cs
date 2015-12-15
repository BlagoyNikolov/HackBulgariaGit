using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Tax {
    public class CountryVATTAX {
        private readonly string countryId;
        private readonly double VATTax;
        private readonly bool IsDefault;

        public CountryVATTAX(string countryId, double VATTax, bool IsDefault) {
            this.countryId = countryId;
            this.VATTax = VATTax;
            this.IsDefault = IsDefault;
        }

        public string CountryId {
            get {
                return countryId;
            }
        }

        public double VATTAX {
            get {
                return VATTax;
            }
        }

        public bool ISDefault {
            get {
                return IsDefault;
            }
        }
    }
}
