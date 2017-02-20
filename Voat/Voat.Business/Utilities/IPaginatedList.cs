﻿namespace Voat.Utilities
{
    public interface IPaginatedList
    {
        bool HasNextPage { get; }
        bool HasPreviousPage { get; }
        int PageIndex { get; }
        int PageSize { get; }
        int TotalCount { get; }
        int TotalPages { get; }
        string RouteName { get; }
        System.Web.Routing.RouteValueDictionary RouteData { get; set; }
    }
}