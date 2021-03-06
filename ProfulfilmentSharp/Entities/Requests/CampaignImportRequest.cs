﻿using System.Xml.Serialization;

namespace ProfulfilmentSharp.Entities.Requests
{
    [XmlRoot(ElementName = "imports")]
    public class CampaignImportRequest
    {
        [XmlElement(ElementName = "import")]
        public CampaignImport Import { get; set; }
    }
}