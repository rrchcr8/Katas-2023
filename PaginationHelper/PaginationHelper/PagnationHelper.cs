namespace PaginationHelper;

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
https://www.codewars.com/kata/515bb423de843ea99400000a/train/csharp
public class PagnationHelper<T>
{
    private IList<T> collection;
    private int pageCount;
    private int itemsPerPage;

    public PagnationHelper(IList<T> collection, int itemsPerPage)
    {
        this.collection = collection;
        pageCount = (collection.Count - 1) / itemsPerPage + 1;
        this.itemsPerPage = itemsPerPage;
    }

    public int ItemCount
    {
        get
        {
            return collection.Count;
        }
    }

    public int PageCount
    {
        get
        {
            return pageCount;
        }
    }

    public int PageItemCount(int pageIndex)
    {
        if (pageIndex < 0 || pageIndex >= pageCount)
        {
            return -1;
        }
        if (pageIndex == pageCount - 1)
        {
            return collection.Count % itemsPerPage;
        }
        return itemsPerPage;
    }

    public int PageIndex(int itemIndex)
    {
        if (itemIndex < 0 || itemIndex >= collection.Count)
        {
            return -1;
        }
        return itemIndex / itemsPerPage;
    }
}