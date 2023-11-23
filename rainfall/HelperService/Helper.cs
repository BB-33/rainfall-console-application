﻿using System.ComponentModel;
using CoreService.Models;

namespace HelperService;



public class Helper
{
    public static Dictionary<string, List<V>> SortIntoDictionary<T, V>(List<T> lstT, List<V> lstV)
    where V : IId
    where T : IId
    {
        var dict = new Dictionary<string, List<V>>();
        lstT.ForEach(row =>
        {
            if (!dict.ContainsKey(row.Id))
            {
                dict.Add(row.Id, new List<V>());
            }
        });
        lstV.ForEach(row => dict[row.Id].Add(row));
        return dict;
    }
}