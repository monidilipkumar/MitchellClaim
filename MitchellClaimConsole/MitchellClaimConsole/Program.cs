using MitchellClaimConsole.MitchellClaimService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MitchellClaimConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string backStoreXMLPath = @"C:\Users\Manasa\Desktop\Backstore.xml";
            bool cont = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Note: Default BackStore path --> " + backStoreXMLPath);
                Console.WriteLine();
                Console.WriteLine("Please choose any of the options provided below to proceed");
                Console.WriteLine();
                Console.WriteLine("1. Create Claim  2. List all Claims  3. Find Claim   4. Update Claim   5. Delete Claim   6. Find Vehicle");
                Console.WriteLine();
                //Perform the task based on the option selected by the user
                string option = Console.ReadLine();
                switch (option)
                {
                        //Create new Claim
                    case "1":
                        {
                            Console.WriteLine("Please enter the path of the xml file to create Claims");
                            //Read xml file path from user - contains new record to be created
                            string createXMLPath = Console.ReadLine();
                            using (var client = new Service1Client())
                            {
                                //createXMLPath - path of xml file contains new record to be created. backStoreXMLPath - path of backstore xml file
                                client.CreateMitchellClaims(createXMLPath, backStoreXMLPath);
                            }
                            break;
                        }
                        //List all the existing Claims
                    case "2":
                        {
                            using (var client = new Service1Client())
                            {
                                //Read all the list of existing Claims. backStoreXMLPath - path of backstore xml file
                                var mitchellClaims = client.ReadMitchellClaims(backStoreXMLPath);
                                int count = 0;
                                //Print all the list of Claims
                                foreach (MitchellClaimConsole.MitchellClaimService.MitchellClaim claims in mitchellClaims.MitchellClaim)
                                {
                                    //count - to show how many Claims are created
                                    count = count + 1;
                                    Console.WriteLine("------------- Claim" + count + "--------------");
                                    PrintClaimDetails(claims);
                                    Console.WriteLine("------------- End of Claim" + count + "--------------");
                                }
                            }
                            break;
                        }
                        //Finding a Claim
                    case "3":
                        {
                            Console.WriteLine("Enter the Claim Numer");
                            //Read the Claim number entered by the user. To query it and find the Claim details.
                            string claimNumber = Console.ReadLine();
                            using (var client = new Service1Client())
                            {
                                //Read all the list of existing Claims. backStoreXMLPath - path of backstore xml file
                                var mitchellClaims = client.ReadMitchellClaims(backStoreXMLPath);
                                //Query and find the Claim details using the input Claim Number
                                MitchellClaimConsole.MitchellClaimService.MitchellClaim mitchellClaim = mitchellClaims.MitchellClaim.Where(x => x.ClaimNumber == claimNumber).FirstOrDefault();

                                if (mitchellClaim != null)
                                {
                                    //Print Claim details
                                    PrintClaimDetails(mitchellClaim);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter correct Claim Number");
                                }
                            }
                            break;
                        }
                        //Updating a Claim
                    case "4":
                        {
                            Console.WriteLine("Please enter the path of the xml file to update Claims.");
                            //Read the update xml file path - Contains the updated data against a Claim number(which is unique)
                            string updateXMLPath = Console.ReadLine();
                            bool updated = false;
                            using (var client = new Service1Client())
                            {
                                //Update backstore with the new data. updateXMLPath - xml file path which contains updated data, backStoreXMLPath - path of backstore xml file
                                updated = client.UpdateXMLStore(updateXMLPath, backStoreXMLPath);
                            }

                            if (!updated)
                                Console.WriteLine("Claim Number could not be found.");
                            break;
                        }
                        //Deleting a Claim
                    case "5":
                        {
                            Console.WriteLine("Enter the Claim Number for the Claim to be deleted.");
                            //Read the Claim number entered by the user. To query and delete the record.
                            string claimNumber = Console.ReadLine();
                            bool updated = false;
                            using (var client = new Service1Client())
                            {
                                //To delete the record. claimNumber - string entered by the user, backStoreXMLPath - path of backstore xml file
                                updated = client.DeleteMitchellClaim(claimNumber, backStoreXMLPath);
                            }

                            if (!updated)
                                Console.WriteLine("Claim Number could not be found.");
                            break;
                        }
                        //Find Vehicle details
                    case "6":
                        {
                            Console.WriteLine("Enter the Claim Numer");
                            //Read the Claim number entered by the user
                            string claimNumber = Console.ReadLine();
                            Console.WriteLine("Enter the VIN of the Vehicle");
                            //Read the VIN entered by the user
                            string vin = Console.ReadLine();

                            using (var client = new Service1Client())
                            {
                                //Read all the list of existing Claims. backStoreXMLPath - path of backstore xml file
                                var mitchellClaims = client.ReadMitchellClaims(backStoreXMLPath);
                                //Query and find the Claim details using the input Claim Number & VIN
                                MitchellClaimConsole.MitchellClaimService.MitchellClaim mitchellClaim = mitchellClaims.MitchellClaim.Where(x => x.ClaimNumber == claimNumber && x.Vehicles.VehicleDetails.Vin == vin).FirstOrDefault();

                                if (mitchellClaim != null)
                                {
                                    //Print the Claim details
                                    PrintClaimDetails(mitchellClaim);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter correct Claim Number & VIN");
                                }


                            }
                            break;
                        }
                }
               
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Your operation is done.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Do you want to try again? Press 'Y' or 'N'");
                Console.WriteLine();

                string opt = Console.ReadLine();
                if (opt.ToLower() == "y")   cont = true;
                else cont = false;

            } while (cont);

            Console.WriteLine("Thank you!! Press any key to exit.");
            Console.ReadLine();

        }

        /// <summary>
        /// Method to print claim details
        /// </summary>
        /// <param name="mitchellClaim">Claim Details</param>
        private static void PrintClaimDetails(MitchellClaimConsole.MitchellClaimService.MitchellClaim mitchellClaim)
        {
            Console.WriteLine("---------------------- Claim Details -----------------------");
            Console.WriteLine();
            Console.WriteLine("Claim Number: " + mitchellClaim.ClaimNumber);
            Console.WriteLine("Claim Last Name: " + mitchellClaim.ClaimantLastName);
            Console.WriteLine("Claim First Name: " + mitchellClaim.ClaimantFirstName);
            Console.WriteLine("Assigned Adjuster ID: " + mitchellClaim.AssignedAdjusterID);
            Console.WriteLine("Loss Date: " + mitchellClaim.LossDate);
            Console.WriteLine("Status: " + mitchellClaim.Status);
            Console.WriteLine();

            Console.WriteLine("---------------------- Loss Info ---------------------------");
            Console.WriteLine("Cause of Loss: " + mitchellClaim.LossInfo.CauseOfLoss);
            Console.WriteLine("Reported Date: " + mitchellClaim.LossInfo.ReportedDate);
            Console.WriteLine("Loss Description: " + mitchellClaim.LossInfo.LossDescription);
            Console.WriteLine();

            Console.WriteLine("---------------------- Vehicle Details ---------------------");
            Console.WriteLine("VIN:" + mitchellClaim.Vehicles.VehicleDetails.Vin);
            Console.WriteLine("Model Year:" + mitchellClaim.Vehicles.VehicleDetails.ModelYear);
            Console.WriteLine("License Plate:" + mitchellClaim.Vehicles.VehicleDetails.LicPlate);
            Console.WriteLine("License Plate State:" + mitchellClaim.Vehicles.VehicleDetails.LicPlateState);
            Console.WriteLine("License Plate Expiry Date:" + mitchellClaim.Vehicles.VehicleDetails.LicPlateExpDate);
            Console.WriteLine("Damage Description:" + mitchellClaim.Vehicles.VehicleDetails.DamageDescription);
            Console.WriteLine("Mileage:" + mitchellClaim.Vehicles.VehicleDetails.Mileage);
        }
 
    }
}
