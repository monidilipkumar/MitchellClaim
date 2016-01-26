using MitchellClaimConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MitchellClaimService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// Default Method
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        string GetData(int value);

        /// <summary>
        /// Default Method
        /// </summary>
        /// <param name="composite"></param>
        /// <returns></returns>
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        /// <summary>
        /// Method to create a new claim
        /// </summary>
        /// <param name="createXMLPath">create claim xml file path</param>
        /// <param name="BackStoreXMLPath">back store xml file path</param>
        [OperationContract]
        void CreateMitchellClaims(string createXMLPath, string BackStoreXMLPath);

        /// <summary>
        /// Method to retrieve all the claim details
        /// </summary>
        /// <param name="backStoreXMLPath">back store xml file path</param>
        /// <returns>List of all claims</returns>
        [OperationContract]
        MitchellClaims ReadMitchellClaims(string backStoreXMLPath);

        /// <summary>
        /// Method to update a Claim
        /// </summary>
        /// <param name="updateXMLPath">update claim xml file path</param>
        /// <param name="backStoreXMLPath">back store xml file path</param>
        /// <returns>update success or fail</returns>
        [OperationContract]
        bool UpdateXMLStore(string updateXMLPath, string backStoreXMLPath);

        /// <summary>
        /// Method to delete a claim
        /// </summary>
        /// <param name="claimNumber">Claim number</param>
        /// <param name="backStoreXMLPath">back store xml file path</param>
        /// <returns>delete success or fail</returns>
        [OperationContract]
        bool DeleteMitchellClaim(string claimNumber, string backStoreXMLPath);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
