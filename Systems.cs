using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace firelyFhirSDK
{
    class Systems
    {
        public string age_system = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/person-age";
        public string age_unit = "http://unitsofmeasure.org";
        public string nation_system = "urn:iso:std:iso:3166";
        public string moi = "http://www.moi.gov.tw/";
        public string mr_system = "https://www.tph.mohw.gov.tw/";
        public string marital = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus";


        public string category_system = "http://hl7.org/fhir/observation-category";
        public string loinc = "http://loinc.org";
        public string unit_system = "http://unitsofmeasure.org";
        public string body_system = "https://hapi.fhir.tw/fhir/CodeSystem/VT.BodySite";

        public string id_type_system = "http://terminology.hl7.org/CodeSystem/v2-0203";
        public string role_system = "http://terminology.hl7.org/CodeSystem/v3-RoleCode";

        public string twSection = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-section";
        public string twNumber = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-number";
        public string twVillage = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-village";
        public string twNeighborhood = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-neighborhood";
        public string twLane = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-lane";
        public string twAlley = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-alley";
        public string twFloor = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-floor";
        public string twRoom = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-room";

        public string postal_code = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-postal-code";
        public string postal_system = "https://twcore.mohw.gov.tw/ig/twcore/CodeSystem/postal-code3-tw";



    }

}

