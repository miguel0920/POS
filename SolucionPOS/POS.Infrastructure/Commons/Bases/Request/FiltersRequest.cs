﻿namespace POS.Infrastructure.Commons.Bases.Request
{
    public class FiltersRequest : PaginationRequest
    {
        public int? NumFilter { get; set; } = null;
        public string TextFilter { get; set; } = null;
        public int? StateFilter { get; set; } = null;
        public string StartDate { get; set; } = null;
        public string EndDate { get; set; } = null;
        public bool Download { get; set; } = false;
    }
}