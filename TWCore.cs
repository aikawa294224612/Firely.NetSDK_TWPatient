using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using System;
using System.IO;

namespace firelyFhirSDK
{
    class TWCore
    {
        private static string endpoint = "http://server.fire.ly";
        static Systems sys = new Systems();

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            TWCore core = new TWCore();
            var client = new FhirClient(endpoint);

            var result = await core.createPatientAsync(client);
            await core.createHeightAsync(client, result.Id.ToString());
        }

        public async Task<Patient?> createPatientAsync(FhirClient client) // value hardcode
        {
            string patient_profile = "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/Patient-twcore";

            var pat = new Patient();
            var func = new Functions();

            pat.Meta = func.createMetaProfile(patient_profile);  
            pat.Identifier.Add(func.createID("NNxxx", sys.moi, "A123456789"));

            pat.Identifier.Add(func.createIdentifier("MR", sys.mr_system, "8862168"));
            pat.Name.Add(func.createName("Chia Lin", "Chen", "陳加玲"));

            pat.Telecom.Add(new ContactPoint(ContactPoint.ContactPointSystem.Phone, ContactPoint.ContactPointUse.Mobile, "0911327999"));

            pat.Gender = AdministrativeGender.Female;
            pat.BirthDate = "1983-04-23";

            pat.Address.Add(func.createAddress("臺北市大同區大有里19鄰承德路三段52巷6弄210號2樓B室",new string[] { "承德路" },null ,"大同區","TW",
                    "三段","210號", "大有里","19鄰","52巷","6弄","2樓","B室", "103"));

            pat.MaritalStatus = new CodeableConcept(sys.marital, "U");
            pat.Contact.Add(func.createContact("Susan", "Parks", "Hello!", AdministrativeGender.Male, "FTH", "0917159753"));
            pat.Deceased = new FhirBoolean(false);

            return await client.CreateAsync<Patient>(pat);
        }

        public async System.Threading.Tasks.Task createHeightAsync(FhirClient client, string patient_id) // value hardcode
        {
            string height_profile = "https://hapi.fhir.tw/fhir/StructureDefinition/Observation.SC1.BodyHeight";

            var observe = new Observation();
            var func = new Functions();

            observe.Meta = func.createMetaProfile(height_profile);

            observe.Status = ObservationStatus.Final;
            observe.Category.Add(new CodeableConcept(sys.category_system, "vital-signs", "Vital Signs"));
            observe.Code = new CodeableConcept(sys.loinc, "3137-7", "Body height Measured");
            observe.Subject = new ResourceReference
            {
                ReferenceElement = new FhirString("Patient/"+ patient_id)
            };
            observe.Effective = new FhirDateTime("2023-11-10");
            observe.Value = new Quantity()
            {
                Value = 160,
                System = sys.unit_system,
                Code = "cm",
                Unit = "cm"
            };

            var created_height = await client.CreateAsync<Observation>(observe);
            Console.WriteLine("新增身高資料的ID:" + created_height.Id.ToString());

        }


    }

}