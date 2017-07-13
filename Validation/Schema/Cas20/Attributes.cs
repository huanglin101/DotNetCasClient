#pragma warning disable 1591
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace DotNetCasClient.Validation.Schema.Cas20
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://www.yale.edu/tp/cas")]
    public class Attributes
    {
        internal Attributes() { }

        [XmlElement("name")]
        public string name
        {
            get;
            set;
        }


        [XmlElement("userId")]
        public string userId { get; set; }

        [XmlElement("userSex")]
        public string userSex { get; set; }

        [XmlElement("userEmail")]
        public string userEmail { get; set; }

        [XmlElement("userIdCode")]
        public string userIdCode { get; set; }

        [XmlElement("userLoginName")]
        public string userLoginName { get; set; }
    }
}
