using Hl7.Fhir.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace firelyFhirSDK
{
    class Functions
    {
        static Systems sys = new Systems();

        internal Extension createExtension(string url, string value)
        {
            var extension = new Extension();
            extension.Url = url;
            extension.Value = new FhirString(value);

            return extension;
        }

        internal Identifier createIdentifier(string type_code, string system, string value)
        {
            var iden = new Identifier();
            var type = new CodeableConcept(sys.id_type_system, type_code);
            iden.Type = type;
            iden.Use = Identifier.IdentifierUse.Official;
            iden.System = system;
            iden.Value = value;

            return iden;
        }

        internal Identifier createID(string type_code, string system, string value)
        {

            var iden = new Identifier();
            var type = new CodeableConcept();
            var coding = new Coding();

            coding.System = sys.id_type_system;
            coding.Code = type_code;
            type.Coding.Add(coding);

            iden.Type = type;
            iden.Use = Identifier.IdentifierUse.Official;
            iden.System = system;
            iden.Value = value;

            return iden;
        }

        internal HumanName createName(string given, string family, string text)
        {
            var name = new HumanName();
            name.Use = HumanName.NameUse.Official;
            name.WithGiven(given).AndFamily(family);
            name.Text = text; 

            return name;
        }
        //internal Period createPeriod(string start, string end)
        //{
        //    var period = new Period();
        //    period.Start = start;
        //    period.End = end;

        //    return period;
        //}

        internal Patient.ContactComponent createContact(string given, string family, string text, AdministrativeGender gender, string relation, string cell)
        {
            var contact = new Patient.ContactComponent();
            contact.Name = createName(given, family, text);
            contact.Gender = gender;
            contact.Relationship.Add(new CodeableConcept(sys.role_system, relation));
            contact.Telecom.Add(new ContactPoint(ContactPoint.ContactPointSystem.Phone, ContactPoint.ContactPointUse.Mobile, cell));

            return contact;
        }

        internal Address createAddress(string text, string[] line, string city,  string district, string country,
                               string section, string number, string village,
                               string neighborhood, string lane, string alley,
                               string floor, string room, string postalcode)
        {
            var address = new Address()
            {
                Text = text,
                Line = line,
                City = city,
                District = district,
                Country = country
            };

            if (section != null )
            {
                address.AddExtension(sys.twSection, new FhirString(section));
            }
            if (number != null)
            {
                address.AddExtension(sys.twNumber, new FhirString(number));
            }
            if( village != null )
            {
                address.AddExtension(sys.twVillage, new FhirString(village));
            }
            if (neighborhood != null ) {
                address.AddExtension(sys.twNeighborhood, new FhirString(neighborhood));
            }
            if(lane != null )
            {
                address.AddExtension(sys.twLane, new FhirString(lane));
            }
            if(alley != null )
            {
                address.AddExtension(sys.twAlley, new FhirString(alley));
            }
            if(floor != null )
            {
                address.AddExtension(sys.twFloor, new FhirString(floor));
            }
            if(room != null )
            {
                address.AddExtension(sys.twRoom, new FhirString(room));
            }

            return address;
        }

        internal Meta createMetaProfile(string profile)
        {
            var meta = new Meta();
            meta.Profile = new string[] { profile };

            return meta;
        }



    }
}

