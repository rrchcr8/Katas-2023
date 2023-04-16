namespace PaginationHelper;

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;

public class PagnationHelper<T>
{
    // TODO: Complete this class
    IList<T> CollectionProp;
    int ItemsPerPage;
    /// <summary>
    /// Constructor, takes in a list of items and the number of items that fit within a single page
    /// </summary>
    /// <param name="collection">A list of items</param>
    /// <param name="itemsPerPage">The number of items that fit within a single page</param>
    public PagnationHelper(IList<T> collection, int itemsPerPage)
    {
        CollectionProp = collection;
        ItemsPerPage = itemsPerPage;    
    }

    /// <summary>
    /// The number of items within the collection
    /// </summary>
    public int ItemCount
    {
        get
        {
            return CollectionProp.Count;
        }
    }

    /// <summary>
    /// The number of pages
    /// </summary>
    public int PageCount
    {
        get
        {
            return ItemCount % ItemsPerPage == 0 ? ItemCount / ItemsPerPage : ItemCount / ItemsPerPage + 1;
        }
    }

    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
    {
        if (pageIndex < 0)
        {
            return -1;
        
        }
        else if (pageIndex > PageCount - 1)
        {
            return -1;
        }
        else if (pageIndex < PageCount-1) 
        {
            return ItemsPerPage;
        }
        else 
        {
            return ItemCount % ItemsPerPage == 0 ? ItemsPerPage : ItemCount % ItemsPerPage;
        }
            

    }

    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
        if (itemIndex < 0)
        {
            return -1;
        }
        else if (itemIndex > ItemCount - 1)
        { 
        return -1;
        }
        return itemIndex/ItemsPerPage;
    }
}