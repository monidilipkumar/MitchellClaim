using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MitchellClaimConsole
{
    [XmlRoot(Namespace = "http://www.mitchell.com/examples/claim", ElementName = "MitchellClaims", DataType = "string", IsNullable = true)]
   public class MitchellClaims
    {
        [XmlElement("MitchellClaim")]
        public List<MitchellClaim> MitchellClaim = new List<MitchellClaim>(); 
    }

    public class MitchellClaim
    {
        [XmlElement("ClaimNumber")]
        public string ClaimNumber { get; set; }
        [XmlElement("ClaimantFirstName")]
        public string ClaimantFirstName { get; set; }
        [XmlElement("ClaimantLastName")]
        public string ClaimantLastName { get; set; }
        [XmlElement("Status")]
        public string Status { get; set; }
        [XmlElement("LossDate")]
        public string LossDate { get; set; }
        [XmlElement("LossInfo")]
        public LossInfo LossInfo = new LossInfo();
        [XmlElement("AssignedAdjusterID")]
        public string AssignedAdjusterID { get; set; }
        [XmlElement("Vehicles")]
        public Vehicles Vehicles = new Vehicles();
    }

   public class LossInfo
   {
       [XmlElement("CauseOfLoss")]
       public string CauseOfLoss { get; set; }
       [XmlElement("ReportedDate")]
       public string ReportedDate { get; set; }
       [XmlElement("LossDescription")]
       public string LossDescription { get; set; }
   }

   public class Vehicles
   {
       [XmlElement("VehicleDetails")]
       public VehicleDetails VehicleDetails = new VehicleDetails();
   }

    public class VehicleDetails
    {
        [XmlElement("Vin")]
        public string Vin { get; set; }
        [XmlElement("ModelYear")]
        public string ModelYear { get; set; }
        [XmlElement("MakeDescription")]
        public string MakeDescription { get; set; }
        [XmlElement("ModelDescription")]
        public string ModelDescription { get; set; }
        [XmlElement("EngineDescription")]
        public string EngineDescription { get; set; }
        [XmlElement("ExteriorColor")]
        public string ExteriorColor { get; set; }
        [XmlElement("LicPlate")]
        public string LicPlate { get; set; }
        [XmlElement("LicPlateState")]
        public string LicPlateState { get; set; }
        [XmlElement("LicPlateExpDate")]
        public string LicPlateExpDate { get; set; }
        [XmlElement("DamageDescription")]
        public string DamageDescription { get; set; }
        [XmlElement("Mileage")]
        public string Mileage { get; set; }
    }
}
