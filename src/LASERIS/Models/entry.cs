using System;
namespace LASERIS.Models 
{
    public class Entry
    {
       public int id { get; set; }
        public string name { get; set; }
        public string? manufacturerName { get; set; }
        public string? productDescription { get; set; }
        public string? physicalDescription { get; set; }
        public string? productLink { get; set; }
        public string? serialNumber { get; set; }
        public string? orderCode { get; set; }
        public string itemType { get; set; }
        public int quantity { get; set; }
        public string? signedOutTo { get; set; }
        public int? signedOutToId { get; set; }
        public DateTime? signedOutDate { get; set; }

    }
}