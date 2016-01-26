using MitchellClaimConsole;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Serialization;

namespace MitchellClaimService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /// <summary>
        /// Default Method
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        /// <summary>
        /// Default Method
        /// </summary>
        /// <param name="composite"></param>
        /// <returns></returns>
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        /// <summary>
        /// Method to create a new claim
        /// </summary>
        /// <param name="createXMLPath">create claim xml file path</param>
        /// <param name="BackStoreXMLPath">back store xml file path</param>
        public void CreateMitchellClaims(string createXMLPath, string BackStoreXMLPath)
        {
            CreateMitchellClaim(createXMLPath, BackStoreXMLPath);
        }

        /// <summary>
        /// Method to retrieve all the claim details
        /// </summary>
        /// <param name="backStoreXMLPath">back store xml file path</param>
        /// <returns>List of all claims</returns>
        public MitchellClaims ReadMitchellClaims(string backStoreXMLPath)
        {
            MitchellClaims mitchellClaims = GetMitchellClaimObject(backStoreXMLPath);

            return mitchellClaims;
        }

        /// <summary>
        /// Method to update a Claim
        /// </summary>
        /// <param name="updateXMLPath">update claim xml file path</param>
        /// <param name="backStoreXMLPath">back store xml file path</param>
        /// <returns>update success or fail</returns>
        public bool UpdateXMLStore(string updateXMLPath, string backStoreXMLPath)
        {
            return UpdateMitchellClaim(updateXMLPath, backStoreXMLPath);
        }

        /// <summary>
        /// Method to delete a claim
        /// </summary>
        /// <param name="claimNumber">Claim number</param>
        /// <param name="backStoreXMLPath">back store xml file path</param>
        /// <returns>delete success or fail</returns>
        public bool DeleteMitchellClaim(string claimNumber, string backStoreXMLPath)
        {
            return DeleteMitchellClaims(claimNumber, backStoreXMLPath);
        }

        /// <summary>
        /// Method to update claim
        /// </summary>
        /// <param name="updateXMLPath">update claim xml file path</param>
        /// <param name="backStoreXMLPath">back store xml file path</param>
        /// <returns></returns>
        private static bool UpdateMitchellClaim(string updateXMLPath, string backStoreXMLPath)
        {

            MitchellClaims updateXML = GetMitchellClaimObject(updateXMLPath);

            bool deleted = DeleteMitchellClaims(updateXML.MitchellClaim[0].ClaimNumber, backStoreXMLPath);
            if (deleted)
            {
                CreateMitchellClaim(updateXMLPath, backStoreXMLPath);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method to delete a claim
        /// </summary>
        /// <param name="claimNumber">Claim number</param>
        /// <param name="backStoreXMLPath">back store xml file path</param>
        /// <returns>delete success or fail</returns>
        private static bool DeleteMitchellClaims(string claimNumber, string backStoreXMLPath)
        {
            MitchellClaims backStoreXML = new MitchellClaims();
            if (File.Exists(backStoreXMLPath))
                backStoreXML = GetMitchellClaimObject(backStoreXMLPath);

            MitchellClaim mitchellClaimToBeDeleted = backStoreXML.MitchellClaim.Find(x=>x.ClaimNumber == claimNumber);

            if (mitchellClaimToBeDeleted != null)
            {
                backStoreXML.MitchellClaim.Remove(mitchellClaimToBeDeleted);
                WriteXMLBackStore(backStoreXML, backStoreXMLPath);
                return true;
            }

            return false;

        }

        /// <summary>
        /// Method to create a new claim
        /// </summary>
        /// <param name="createXMLPath">create claim xml file path</param>
        /// <param name="BackStoreXMLPath">back store xml file path</param>
        private static void CreateMitchellClaim(string createXMLPath, string backStoreXMLPath)
        {
            MitchellClaims backStoreXML = new MitchellClaims();
            if(File.Exists(backStoreXMLPath))
                backStoreXML = GetMitchellClaimObject(backStoreXMLPath);

            MitchellClaims createXML = GetMitchellClaimObject(createXMLPath);

            MitchellClaims consolidatedBackStore = ConsolidateBackStore(backStoreXML, createXML);

            WriteXMLBackStore(consolidatedBackStore, backStoreXMLPath);

        }

        /// <summary>
        /// Method to consolidate backstore data and record to be created
        /// </summary>
        /// <param name="backStoreXML">backstore data</param>
        /// <param name="createXML">create data</param>
        /// <returns>Consolidated data</returns>
        private static MitchellClaims ConsolidateBackStore(MitchellClaims backStoreXML, MitchellClaims createXML)
        {
            MitchellClaims mitchellClaims = new MitchellClaims();
            mitchellClaims.MitchellClaim.AddRange(backStoreXML.MitchellClaim);
            mitchellClaims.MitchellClaim.AddRange(createXML.MitchellClaim);
            return mitchellClaims;
        }

        /// <summary>
        /// Method to write xml file
        /// </summary>
        /// <param name="mitchellClaims">mitchellCliams data</param>
        /// <param name="backStorePath">backstore path</param>
        private static void WriteXMLBackStore(MitchellClaims mitchellClaims, string backStorePath)
        {
            string mitchellClaimXML = GETMitchellClaimXML(mitchellClaims);
            if(File.Exists(backStorePath))
                File.Delete(backStorePath);
            File.WriteAllText(backStorePath, mitchellClaimXML);
        }

        /// <summary>
        /// Method to Deserialize data(from xml to model data)
        /// </summary>
        /// <param name="path">xml path</param>
        /// <returns>model data</returns>
        private static MitchellClaims GetMitchellClaimObject(string path)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "MitchellClaims";
            xRoot.Namespace = "http://www.mitchell.com/examples/claim";
            xRoot.IsNullable = true;
            XmlSerializer deserializer = new XmlSerializer(typeof(MitchellClaims), xRoot);
            TextReader textReader = new StreamReader(path);
            MitchellClaims mitchelClaim;
            mitchelClaim = (MitchellClaims)deserializer.Deserialize(textReader);
            textReader.Close();
            return mitchelClaim;
        }

        /// <summary>
        /// Method to Serialize data(from model data to xml)
        /// </summary>
        /// <param name="mitchellClaim">model data</param>
        /// <returns>string contains xml type</returns>
        private static string GETMitchellClaimXML(MitchellClaims mitchellClaim)
        {
            MemoryStream stream = null;
            TextWriter writer = null;
            try
            {
                stream = new MemoryStream(); // read xml in memory
                writer = new StreamWriter(stream, Encoding.Unicode);
                // get serialise object
                XmlSerializer serializer = new XmlSerializer(typeof(MitchellClaims));
                serializer.Serialize(writer, mitchellClaim); // read object
                int count = (int)stream.Length; // saves object in memory stream
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                // copy stream contents in byte array
                stream.Read(arr, 0, count);
                UnicodeEncoding utf = new UnicodeEncoding(); // convert byte array to string
                return utf.GetString(arr).Trim();
            }
            catch
            {
                return string.Empty;
            }
            finally
            {
                if (stream != null) stream.Close();
                if (writer != null) writer.Close();
            }
        }
    }
}
