﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Slot.Helper
{
    class GetLicenseNumber
    {
        public static string GetLicenseNumberByUrl(string urlImage, WebClient client)
        {
            string url = "http://127.0.0.1:5000/get_license_number?url_image=" + Uri.EscapeDataString(urlImage);
            try
            {
                // Deserialize the JSON response into a dynamic object
                dynamic responseObj = JsonConvert.DeserializeObject(client.DownloadString(url));

                // Access the LicenseNumber field
                string licenseNumber = responseObj.LicenseNumber;

                return licenseNumber;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
                
            }
        }
    }
}
