﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace ProfulfilmentSharp.Entities.Events
{
    [XmlRoot(ElementName = "purchaseOrder")]
    public class PurchaseOrder
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "externalReference")]
        public string ExternalReference { get; set; }
        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; }
        [XmlAttribute(AttributeName = "supplierPurchaseOrderReference")]
        public string SupplierPurchaseOrderReference { get; set; }
        [XmlAttribute(AttributeName = "manuallyCompleted")]
        public string ManuallyCompleted { get; set; }
        [XmlAttribute(AttributeName = "purchaseOrderDate")]
        public string PurchaseOrderDate { get; set; }
    }

    [XmlRoot(ElementName = "deliveryLine")]
    public class DeliveryLine
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "product")]
        public string Product { get; set; }
        [XmlAttribute(AttributeName = "variation")]
        public string Variation { get; set; }
        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }
        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; }
    }

    [XmlRoot(ElementName = "deliveryLines")]
    public class DeliveryLines
    {
        [XmlElement(ElementName = "deliveryLine")]
        public List<DeliveryLine> DeliveryLine { get; set; }
    }

    [XmlRoot(ElementName = "delivery")]
    public class Delivery
    {
        [XmlElement(ElementName = "purchaseOrder")]
        public PurchaseOrder PurchaseOrder { get; set; }
        [XmlElement(ElementName = "deliveryLines")]
        public DeliveryLines DeliveryLines { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; }
        [XmlAttribute(AttributeName = "site")]
        public string Site { get; set; }
        [XmlAttribute(AttributeName = "organisation")]
        public string Organisation { get; set; }
        [XmlAttribute(AttributeName = "supplierReference")]
        public string SupplierReference { get; set; }
        [XmlAttribute(AttributeName = "supplierDeliveryReference")]
        public string SupplierDeliveryReference { get; set; }
        [XmlAttribute(AttributeName = "deliveryDate")]
        public string DeliveryDate { get; set; }
        [XmlAttribute(AttributeName = "created")]
        public string Created { get; set; }
        [XmlAttribute(AttributeName = "completed")]
        public string Completed { get; set; }
    }

    [XmlRoot(ElementName = "detail")]
    public class DeliveryPushDetails
    {
        [XmlElement(ElementName = "delivery")]
        public Delivery Delivery { get; set; }
    }

    [XmlRoot(ElementName = "event")]
    public class DeliveryPushEvent
    {
        [XmlElement(ElementName = "detail")]
        public DeliveryPushDetails Detail { get; set; }
        [XmlAttribute(AttributeName = "messageId")]
        public string MessageId { get; set; }
        [XmlAttribute(AttributeName = "eventType")]
        public string EventType { get; set; }
        [XmlAttribute(AttributeName = "userName")]
        public string UserName { get; set; }
        [XmlAttribute(AttributeName = "eventTime")]
        public string EventTime { get; set; }
        [XmlAttribute(AttributeName = "entity")]
        public string Entity { get; set; }
    }
}