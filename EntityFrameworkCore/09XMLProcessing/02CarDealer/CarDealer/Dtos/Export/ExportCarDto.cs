﻿namespace CarDealer.Dtos.Import.Export
{
    using System.Xml.Serialization;

    [XmlType("car")]
    public class ExportCarDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("travelled-distance")]
        public long TravelledDistance { get; set; }
    }
}
