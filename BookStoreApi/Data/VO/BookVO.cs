﻿using System.Text.Json.Serialization;

namespace Solutis.Data.VO
{
    public class BookVO
    {
        public string Isbn { set; get; }
        public string Category { set; get; }
        public decimal Price { set; get; }
        public string Title { set; get; }

        [JsonIgnore]
        public long Id { set; get; }
        public long Amount { set; get; }

    }

}