using System;
using System.Collections.Generic;

namespace DatasetLookupWebService.Classes
{
    public class Item
    {
        public string Band { get; set; }
        public string Name { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int SortOrder { get; set; }
    }

    public class Dataset
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public List<Item> Items { get; set; }
        public Dataset()
        {
            Items = new List<Item>();
        }
    }

    public class Datasets : List<Dataset> { }

    public class GetLookupDataResponse
    {
        public Datasets Datasets { get; set; }
        public GetLookupDataResponse()
        {
            Datasets = new Datasets();
        }
    }
}
