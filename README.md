
# Firely.NetSDK_TWPatient
以TW Core IG中所提供之病患範例為例，以Firely .NET SDK實作病患資料新增，並同步新增身高量測數值(配合聯測松Track2規格)

### Patient
產出結果範例: https://server.fire.ly/Patient/e8b18ea8-637e-448a-b2c8-3deb884045a5


    {
        "resourceType": "Patient",
        "meta": {
            "profile": [
                "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/Patient-twcore"
            ],
            "versionId": "e2ed6848-60a3-4660-8067-4c3814f49d44",
            "lastUpdated": "2023-11-10T03:49:52.683+00:00"
        },
        "extension": [
            {
                "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/person-age",
                "valueAge": {
                    "value": 22,
                    "system": "http://unitsofmeasure.org",
                    "code": "a"
                }
            },
            {
                "url": "code",
                "valueCodeableConcept": {
                    "coding": [
                        {
                            "system": "urn:iso:std:iso:3166",
                            "code": "TW"
                        }
                    ]
                }
            }
        ],
        "identifier": [
            {
                "use": "official",
                "type": {
                    "coding": [
                        {
                            "system": "http://terminology.hl7.org/CodeSystem/v2-0203",
                            "code": "NNxxx",
                            "_code": {
                                "extension": [
                                    {
                                        "url": "suffix",
                                        "valueString": "NNxxx"
                                    },
                                    {
                                        "url": "valueSet",
                                        "valueCanonical": "http://hl7.org/fhir/ValueSet/iso3166-1-3"
                                    }
                                ]
                            }
                        }
                    ]
                },
                "system": "http://www.moi.gov.tw/",
                "value": "A123456789"
            },
            {
                "use": "official",
                "type": {
                    "coding": [
                        {
                            "system": "http://terminology.hl7.org/CodeSystem/v2-0203",
                            "code": "MR"
                        }
                    ]
                },
                "system": "https://www.tph.mohw.gov.tw/",
                "value": "8862168"
            }
        ],
        "name": [
            {
                "use": "official",
                "text": "陳加玲",
                "family": "Chen",
                "given": [
                    "Chia Lin"
                ]
            }
        ],
        "telecom": [
            {
                "system": "phone",
                "value": "0911327999",
                "use": "mobile"
            }
        ],
        "gender": "female",
        "birthDate": "1983-04-23",
        "deceasedBoolean": false,
        "address": [
            {
                "extension": [
                    {
                        "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-section",
                        "valueString": "三段"
                    },
                    {
                        "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-number",
                        "valueString": "210號"
                    },
                    {
                        "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-village",
                        "valueString": "大有里"
                    },
                    {
                        "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-neighborhood",
                        "valueString": "19鄰"
                    },
                    {
                        "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-lane",
                        "valueString": "52巷"
                    },
                    {
                        "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-alley",
                        "valueString": "6弄"
                    },
                    {
                        "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-floor",
                        "valueString": "2樓"
                    },
                    {
                        "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-room",
                        "valueString": "B室"
                    }
                ],
                "text": "臺北市大同區大有里19鄰承德路三段52巷6弄210號2樓B室",
                "line": [
                    "承德路"
                ],
                "district": "大同區",
                "_postalCode": {
                    "extension": [
                        {
                            "url": "https://twcore.mohw.gov.tw/ig/twcore/StructureDefinition/tw-postal-code",
                            "valueCodeableConcept": {
                                "coding": [
                                    {
                                        "system": "https://twcore.mohw.gov.tw/ig/twcore/CodeSystem/postal-code3-tw",
                                        "code": "103"
                                    }
                                ]
                            }
                        }
                    ]
                },
                "country": "TW"
            }
        ],
        "maritalStatus": {
            "coding": [
                {
                    "system": "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                    "code": "U"
                }
            ]
        },
        "contact": [
            {
                "relationship": [
                    {
                        "coding": [
                            {
                                "system": "http://terminology.hl7.org/CodeSystem/v3-RoleCode",
                                "code": "FTH"
                            }
                        ]
                    }
                ],
                "name": {
                    "use": "official",
                    "text": "Hello!",
                    "family": "Parks",
                    "given": [
                        "Susan"
                    ]
                },
                "telecom": [
                    {
                        "system": "phone",
                        "value": "0917159753",
                        "use": "mobile"
                    }
                ],
                "gender": "male"
            }
        ],
        "id": "e8b18ea8-637e-448a-b2c8-3deb884045a5"
    }


### Height

產出結果範例: http://server.fire.ly/Observation/4a0891c2-b8a4-4581-9be9-116223504d07

    {
        "resourceType": "Observation",
        "meta": {
            "profile": [
                "https://hapi.fhir.tw/fhir/StructureDefinition/Observation.SC1.BodyHeight"
            ],
            "versionId": "a3969ffd-1889-4150-bcf3-a9ed25255570",
            "lastUpdated": "2023-11-10T08:24:13.976+00:00"
        },
        "status": "final",
        "category": [
            {
                "coding": [
                    {
                        "system": "http://hl7.org/fhir/observation-category",
                        "code": "vital-signs"
                    }
                ],
                "text": "Vital Signs"
            }
        ],
        "code": {
            "coding": [
                {
                    "system": "http://loinc.org",
                    "code": "3137-7"
                }
            ],
            "text": "Body height Measured"
        },
        "subject": {
            "reference": "https://server.fire.ly/Patient/e8b18ea8-637e-448a-b2c8-3deb884045a5"
        },
        "effectiveDateTime": "2023-11-10",
        "valueQuantity": {
            "value": 160,
            "unit": "cm",
            "system": "http://unitsofmeasure.org",
            "code": "cm"
        },
        "id": "4a0891c2-b8a4-4581-9be9-116223504d07"
    }
