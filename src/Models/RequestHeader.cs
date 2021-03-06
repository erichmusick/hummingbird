﻿using System.Xml.Serialization;

namespace Hummingbird.Models
{
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class RequestHeader
    {
        [XmlElementAttribute(Namespace = "http://schemas.microsoft.com/exchange/services/2006/types",ElementName = "RequestServerVersion")]
        public RequestServerVersion Version { get; set; }
    }
}
