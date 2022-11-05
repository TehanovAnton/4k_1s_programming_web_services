using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solution.Models
{
    [Serializable]
    public class ErrorWL
    {
        public static string UrlPref = "http://localhost:50369/api/errors";
        public static Dictionary<int, string> codesDescription = new Dictionary<int, string>()
        {
            { 1, "Da blyt"},
            { 2, "Tak blyt"},
            { 3, "Ladno blyt"}
        };

        public ErrorWL()
        {

        }

        public ErrorWL(int code)
        {
            ErrorCode = code;
            ErrorDescriptionUrl = $"{UrlPref}/{code}";
        }

        public int ErrorCode
        {
            get; set;
        }

        public string ErrorDescriptionUrl
        {
            get; set;
        }
    }
}