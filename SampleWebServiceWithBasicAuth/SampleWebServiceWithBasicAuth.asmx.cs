using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SampleWebServiceWithBasicAuth
{
    /// <summary>
    /// Summary description for SampleWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SampleWebServiceWithBasicAuth : System.Web.Services.WebService
    {

        /// <summary>
        /// Date variable plus five days
        /// </summary>
        /// <param name="inputDateTime"> Date variable</param>
        /// <returns> Returns date variable plus five days</returns>
        [WebMethod]
        public DateTime ReturnFiveDaysLater(DateTime inputDateTime)
        {
            return inputDateTime.AddDays(5);
        }


        /// <summary>
        /// The numeric variables are added and the result is returned as a numeric value.
        /// </summary>
        /// <param name="firstParameter"> A numeric variable without decimal places</param>
        /// <param name="secondParameter">A numeric variable without decimal places</param>
        /// <returns>Return sum of two numbers</returns>
        [WebMethod]
        public int ReturnN0(int firstParameter, int secondParameter)
        {
            return firstParameter + secondParameter;
        }

        /// <summary>
        ///  The numeric variables are added and the result is returned as a numeric value with decimal places.
        /// </summary>
        /// <param name="firstDecimal">A numeric variable with decimal places</param>
        /// <param name="secondDecimal">A numeric variable with decimal places</param>
        /// <returns>Return sum of two numbers</returns>
        [WebMethod]
        public decimal ReturnN2(decimal firstDecimal, decimal secondDecimal)
        {
            return firstDecimal + secondDecimal;
        }


        /// <summary>
        /// Revert a string
        /// </summary>
        /// <param name="stringParameter">A string variable</param>
        /// <returns>Reversed character string</returns>
        [WebMethod]
        public string ReverseString(string stringParameter)
        {
            char[] arr = stringParameter.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// These methods can be used to simulate an error in the Web Service.
        /// </summary>
        /// <param name="inputParameter">A string variable</param>
        [WebMethod]
        public void TimeoutString(string inputParameter)
        {
        }

        /// <summary>
        ///  Returns an object
        /// </summary>
        /// <returns>Return an object, which properties can be used as values</returns>
        [WebMethod]
        public DocuWareVersion CurrentDocuWareVersion()
        {
            return new DocuWareVersion()
            {
                AdditionalInformation = "This is sample web service",
                Name = "Gecko",
                Version = 6.9
            };
        }

        /// <summary>
        /// This method illustrates passing parameters by reference and getting multiple resuls
        /// </summary>
        /// <param name="stringParameter">A literal.</param>
        /// <param name="intPatameter">Integer value.</param>
        /// <returns>This method return 3 results. The first result is the value of "stringParameter" value plus "TEST" text.
        /// The second result is the value of "intPatameter" plus 1. The third parameter is reversed "stringParameter"</returns>
        [WebMethod]
        public string MultipleRefParameters(ref string stringParameter, ref int intPatameter)
        {
            string result = ReverseString(stringParameter);
            stringParameter += " TEST";
            intPatameter += 1;
            return result;
        }
    }

    public class DocuWareVersion
    {
        public double Version { get; set; }
        public string Name { get; set; }

        public string AdditionalInformation { get; set; }

    }
}
