using EFaturaTest.EIrsaliye;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace EFaturaTest
{
    public partial class EIrsaliyeGonderim : Form
    {
        public EIrsaliyeGonderim()
        {
            // Formdaki bileşenler
            InitializeComponent();
        }

        private void EFatura_Load(object sender, EventArgs e)
        {

        }

        // Gelen Faturalar
        private void btnGelFatura_Click(object sender, EventArgs e)
        {
          
        } 

        // Fatura Gönder
        private void btnFaturaGonder_Click(object sender, EventArgs e)
        {
            IEIrsaliyeClientInterfaceService _service = new EIrsaliyeClientInterfaceServiceClient();

            ICollection<OutgoingDespatchAdvices> despatches = new List<OutgoingDespatchAdvices>();

            despatches.Add(new OutgoingDespatchAdvices()
            {
                Header = new OutgoingDespatchAdviceHeader()
                {
                    //DespatchAdviceLabels = null,
                    IsUnregisteredCustomer = false,
                    //InvoiceNumber = null,
                    //ExternalDepartmentId = "1",
                    OperationSourceCode = 23,
                    DespatchTypeCode = 1,
                    SenderAlias = "defaultgb",
                    //InvoiceNumber = "INN2019000012154",
                    DespatchAdviceSendType = 1,
                    DespatchAdviceNumberPrefix = "ABT",
                    IsDraft = true,
                    IsOverrideWithRetry = false,
                    ReceiverAlias = "defaultpk",
                    ReceiverIdentityNumber = "4780163831",
                    TrackNumber = Guid.NewGuid().ToString(),
                    
                },

                Body = new DespatchAdviceBody()
                {
                    BuyerCustomerParty = new Party()
                    {
                        Contact = new Contact()
                        {
                            ElectronicMail = "yalkis@innova.com.tr",
                        },
                        PartyIdentifications = new List<PartyIdentification>() { new PartyIdentification() { SchemeID = "VKN", Value = "4780163831" } }.ToArray(),
                        PartyName = "İnnova Bilişim Çözm. A.Ş.Test Kullanıcısı",
                        PartyTax = "Vergi Dairesi",
                        PostalAddress = new Address()
                        {
                            PostalZone = "PostalZone",
                            StreetName = "StreetName",
                            CitySubdivisionName = "Sarıyer",
                            CityName = "İstanbul",
                            Country = new Country()
                            {
                                IdentificationCode = "TR",
                                Name = "Türkiye"
                            }
                        }
                    },

                    DeliveryCustomerParty = new CustomerParty()
                    {
                        Party = new Party()
                        {
                            
                            Contact = new Contact()
                            {
                                ElectronicMail = "yalkis@innova.com.tr",
                                Telefax = "2126663355",
                                Telephone = "2124455699"
                            },
                            PartyIdentifications = new List<PartyIdentification>() { new PartyIdentification() { SchemeID = "VKN", Value = "4780163831" } }.ToArray(),
                            PartyName = "INNOVA",
                            PartyTax = "VERGİ DAİRESİ",
                            WebsiteURI = "www.innova.com.tr",
                            PostalAddress = new Address()
                            {
                                BlockName = "BlockName",
                                BuildingName = "BuildingName",
                                BuildingNumber = "1",
                                StreetName = "StreetName",
                                CitySubdivisionName = "CitySubdivisionName",
                                CityName = "CityName",
                                Country = new Country()
                                {
                                    IdentificationCode = "TR",
                                    Name = "Türkiye"
                                },
                                District = "District",
                                ID = "1",
                                PostBox = "PostBox",
                                PostalZone = "34469"

                            }


                        }
                    },
                    //DİKKAT
                    DespatchSupplierParty = new SupplierParty()
                    {   DespatchContact = new Contact()
                    {
                        Name= "Teslim Eden Adı Soyadı"
                    },
                        Party = new Party()
                        {
                            Contact = new Contact()
                            {
                                ElectronicMail = "yalkis@innova.com.tr",
                                Note = "Note",
                                OtherCommunication = "OtherCommunication",
                                Telefax = "+90 312 4195084",
                                Telephone = "+90 312 4195080"
                            },
                            WebsiteURI = "WebsiteURI",
                            PartyIdentifications = new List<PartyIdentification>()
                                {
                                    new PartyIdentification()
                                    {
                                        SchemeID = "VKN",
                                        Value = "4780163831"
                                    }
                                }.ToArray(),
                            PartyName = "PartyName",
                            PartyTax="PartyTax",
                            PhysicalLocation = new Location()
                            {
                               Address = new Address()
                               {
                                   BuildingNumber = "1",
                                   CityName = "Şehir",
                                   Country = new Country()
                                   {
                                       IdentificationCode = "TR",
                                       Name = "Türkiye"
                                   },
                                   CitySubdivisionName= "CitySubdivisionName",
                                   ID="1",

                               },
                               ID="SA YAZILIM ŞAHİN"
                            
                             },
                            PostalAddress = new Address()
                            {
                                BlockName = "BlockName",
                                BuildingName= "BuildingName",
                                BuildingNumber= "1",
                                District = "District",
                                ID="1",
                                PostBox= "PostBox",
                                PostalZone="11111",
                                StreetName = "StreetName",
                                CitySubdivisionName = "CitySubdivisionName",
                                CityName = "CityName",
                                Country = new Country()
                                {
                                    IdentificationCode = "TR",
                                    Name = "Türkiye"
                                }
                            },
                            
                        }
                       
                    },
                    DocumentCurrencyCode = "TRY",
                    
                    DespatchLine = new List<DespatchLine>()
                        {

                            new DespatchLine()
                            {
                                
                                //OrderLineReferences = new OrderLineReference()
                                //{
                                //    LineID="1",
                                //    UUID=Guid.NewGuid()
                                //},
                                UnitCode = "NIU",
                                DeliveredQuantity = 2,
                                Item = new Item()
                                {   SellersItemIdentification ="HP333",
                                    Name = "HP Laptop",
                                   
                                    //OriginCountry = new OriginCountry()
                                    //{
                                    //    IdentificationCode ="",
                                    //    Name =""
                                    //}
                                    
                                },
                                OutstandingQuantity=1,
                                //Notes


                            },
                        new DespatchLine()
                            {
                                
                                //OrderLineReferences = new OrderLineReference()
                                //{
                                //    LineID="1",
                                //    UUID=Guid.NewGuid()
                                //},
                                UnitCode = "NIU",
                                DeliveredQuantity = 4,
                                Item = new Item()
                                {   SellersItemIdentification ="M185",
                                    Name = "Microsoft Mouse 1850",
                                   
                                    //OriginCountry = new OriginCountry()
                                    //{
                                    //    IdentificationCode ="",
                                    //    Name =""
                                    //}
                                    
                                },
                                OutstandingQuantity=1,
                                //Notes


                            },
                            new DespatchLine()
                            {
                                
                                //OrderLineReferences = new OrderLineReference()
                                //{
                                //    LineID="1",
                                //    UUID=Guid.NewGuid()
                                //},
                                UnitCode = "NIU",
                                DeliveredQuantity = 7,
                                Item = new Item()
                                {   SellersItemIdentification ="LGTCH38",
                                    Name = "Logitech M238 Mouse",
                                   
                                    //OriginCountry = new OriginCountry()
                                    //{
                                    //    IdentificationCode ="",
                                    //    Name =""
                                    //}
                                    
                                },
                                OutstandingQuantity=1,
                                //Notes


                            }
                    }.ToArray(),

                    IssueDateTime = new DateTime(2020,06,28),
               
                    DespatchTypeCode = 1,
                    ProfileID = 1,

                    //ID = "30111",
                    CopyIndicator = false,
                    OrderReference = new List<OrderReference>()
                    {
                       new OrderReference()
                       {
                           ID="SİPARİŞNO1",
                           IssueDate = new DateTime(2020,06,25)
                       }

                    }.ToArray(),
                    OriginatorCustomerParty = new Party()
                    {
                        Contact = new Contact()
                        {
                            ElectronicMail = "yalkis@innova.com.tr",
                            Telefax = "+90 212 5558877",
                            Telephone= "+90 212 6665544",                            
                        },
                        PartyIdentifications = new List<PartyIdentification>() { new PartyIdentification() { SchemeID = "TCKN", Value = "47801638311" } }.ToArray(),
                        PartyName = "İnnova Bilişim Çözümleri A.Ş.",
                        PartyTax = "Sarıyer",
                        Person = new Person()
                        {
                            FamilyName = "FamilyName",
                            FirstName = "FirstName"
                        },
                        PostalAddress = new Address()
                        {
                            CityName= "İstanbul",
                            CitySubdivisionName="Sarıyer",
                            Country = new Country()
                            {
                                IdentificationCode = "TR",
                                Name = "Türkiye"
                            }

                        }
                        
                    },
                    SellerSupplierParty = new Party()
                    {   
                        
                        Contact = new Contact()
                        {
                            ElectronicMail= "yalkis@innova.com.tr",
                            Telefax= "+90 212 5558877",
                            Telephone= "+90 212 6665544"
                        },

                        PartyIdentifications = new List<PartyIdentification>() { new PartyIdentification() { SchemeID = "TCKN", Value = "53486795678" } }.ToArray(),
                        PartyName = "Yasemin",
                        PartyTax= "Vergi Dairesi",
                        Person = new Person()
                        {
                            FamilyName = "FamilyName",
                            FirstName = "FirstName"
                        },
                        PostalAddress = new Address()
                        {
                            CityName = "CityName",
                            CitySubdivisionName = "CitySubdivisionName",
                            Country = new Country()
                            {
                                IdentificationCode = "TR",
                                Name = "Türkiye"
                            },
                            PostalZone = "PostalZone"

                        }

                    },
                    UUID = Guid.NewGuid().ToString(),
                    Shipment = new DespatchShipment()
                    {   
                        GoodsItem = new List<DespatchGoodsItem>()
                        {

                            new DespatchGoodsItem()
                            {
                                ValueAmount = new Amount1()
                                {
                                    CurrencyCode="TRY",
                                    Value=500,
                                }
                            }

                        }.ToArray(),
                        ID = "1",
                        ShipmentStage = new List<ShipmentStage>()
                        {

                            new ShipmentStage()
                            {
                                DriverPerson = new List<Person>()
                                {
                                   new Person()
                                   {
                                       FamilyName="FamilyName",
                                       FirstName="FirstName",
                                       NationalityID="12345678901",
                                       Title="Title"

                                   } 
                                }.ToArray(),
                                ID="1",
                                TransportMeans = new TransportMeans()
                                {
                                    RoadTransport=new RoadTransport()
                                    {
                                        LicensePlateID="Araç Plakası"
                                    }
                                },
                                TransportModeCode="1",

                            }

                        }.ToArray(),
                        TransportHandlingUnit = new  List<DespatchTransportHandlingUnit>()
                        {
                            new DespatchTransportHandlingUnit()
                            {
                                TransportEquipments = new List<TransportEquipment>()
                                {
                                    new TransportEquipment()
                                    {
                                        Description="Dorse Plaka 1",
                                        ID="Dorse Plaka 1",
                                        TransportEquipmentTypeCode="DORSEPLAKA"
                                    } 
                                }.ToArray()
                            }
                        }.ToArray(),

                        
                        Delivery = new DeliveryShipment()
                        {
                            //ActualDeliveryDateTime = DateTime.Now,
                            CarrierParty = new Party()
                            {
                                PartyIdentifications = new List<PartyIdentification>() { new PartyIdentification() { SchemeID = "VKN", Value = "4780163831" } }.ToArray(),
                                PartyName = "4780163831",
                                PostalAddress = new Address()
                                {
                                    //StreetName = "StreetName",
                                    CitySubdivisionName = "CitySubdivisionName",
                                    CityName = "CityName",
                                    Country = new Country()
                                    {
                                        IdentificationCode = "TR",
                                        Name = "TÜRKİYE"
                                    }

                                }


                            },
                            Despatch = new Despatch()
                            {
                                ActualDespatchDateTime = new DateTime(2020, 06, 28),
                                
                            }
                        }
                    }

                }
            }
            );
            

            var request = new SendDespatchAdvicesRequest()
            {
                // Kurum Id'si, kullanıcı adı ve soyadı bilgiler App.config dosyasından çekilmiştir. 
                Header = new RequestHeader()
                {
                    InstitutionId = Convert.ToInt64(ConfigurationManager.AppSettings["InstitutionId"]),
                    Username = ConfigurationManager.AppSettings["Username"],
                    Password = ConfigurationManager.AppSettings["Password"]
                },
                AcceptanceDateTime = new DateTime(2019,08,31),
                DespatchAdvices = despatches.ToArray(),

            };
            //
            string xml = GetXML(despatches.ToArray());

            try
            {
                File.WriteAllText("son.xml", xml);

            }
            catch
            { }

            var response = _service.SendDespatchAdvices(request);
            richTextBox1.Text = "Status\t" + response.Header.Status + "\t"; // status kod

            label1.Text = "Response Code: " + response.Header.ResponseCode; // Gönderilen istekten dönen cevap için Response Code yazdırılır.
            if (response.Header.ResponseCode == "0000")
            {
                // Faturadan bazı bilgileri
                label1.Text += "\n\n"
                + "Fatura No: " + response.Items[0].DespatchAdviceNumber + "\n"
                + "Referans No: " + response.Items[0].ReferenceNumber.ToString() + "\n"
                + "Track No: " + response.Items[0].TrackNumber;

                label1.Text += "\n\n" + "İrsaliye Gönderme işlemi başarılıdır\n" + "Mesaj" + response.Header.Message.ToString()+"\nAçıklama:"+ response.Items[0].ResponseDescription;
                txtNO.Text = response.Items[0].DespatchAdviceNumber;
            }
            else
            {
                label1.Text += "Message\n\n" + response.Header.Message; // işlem başarısız olduğunda dönen mesajı yazdırır.
            }

        }

        private static string GetXML<T>(T obj)
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(T));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            MemoryStream ms = new MemoryStream();
            TextWriter WriteFileStream = new StreamWriter(ms);
            SerializerObj.Serialize(WriteFileStream, obj, ns);
            WriteFileStream.Close();

            return Encoding.UTF8.GetString(ms.ToArray());
        }
        private void btnMukSorgu_Click(object sender, EventArgs e)
        {
            //var request = new CustomerInquiryRequest()
            //{
            //    // Kurum Id'si, kullanıcı adı ve soyadı bilgiler App.config dosyasından çekilmiştir. 
            //    Header = new RequestHeader()
            //    {
            //        InstitutionId = Convert.ToInt64(ConfigurationManager.AppSettings["InstitutionId"]),
            //        Username = ConfigurationManager.AppSettings["Username"],
            //        Password = ConfigurationManager.AppSettings["Password"]
            //    },
            //    IdentityNumbers = new List<string>()
            //    {
            //       "5555550933"
            //    }.ToArray()
            //};

            //var response = _service.CustomerInquiry(request);

            //label1.Text = "Response Code: " + response.Header.ResponseCode;// Gönderilen istekten dönen cevap için Response Code yazdırılır.
            //if (response.Header.ResponseCode == "0000")
            //{
            //    label1.Text += "\n\n"
            //        + "Mükellef: " + response.Customers[0].ReceiverAliasses[0].Name;// Mükellefin adını yazdırır.
            //}
            //else
            //{
            //    label1.Text += "\n\n" + response.Header.Message;// işlem başarısız olduğunda dönen mesajı yazdırır.
            //}
        }

        // Faturayı İptal Et
        private void btnFaturaIptal_Click(object sender, EventArgs e)
        {
           
        }

        // Faturayı İndir
        private void btnFaturaIndir_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEIrsaliyeClientInterfaceService srv = new EIrsaliyeClientInterfaceServiceClient();

            var request = new DownloadDespatchReceiptRequest
            {
                AdviceType = 1,
                ReferenceNumber = 30183,
                TrackNumber = "c3372a95-f902-4373-891c-3d12671e65b3",
                ViewContentType = 4,
                OperationDirectionType = 2,

                Header = new RequestHeader
                {
                    InstitutionId = Convert.ToInt64(ConfigurationManager.AppSettings["InstitutionId"]),
                    Username = ConfigurationManager.AppSettings["Username"],
                    Password = ConfigurationManager.AppSettings["Password"]

                }

            };
            var response = srv.DownloadDespatchReceipt(request);

            if (response.Header.ResponseCode == "0000")
            {
                MessageBox.Show("Fatura indirme işlemi başarılıdır.");


                byte[] sPDFDecoded = Convert.FromBase64String(response.ViewContent);


                File.WriteAllBytes("e_Donusum.pdf", sPDFDecoded);
                Process.Start("e_Donusum.pdf");


            }
            else
            {


                MessageBox.Show(response.Header.Message);
            }
            


            
        }
    }
}
