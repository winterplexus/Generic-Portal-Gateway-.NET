//
//  ViewAssistant.cs
//
//  Wiregrass Code Technology 2017
//
using System;
using System.Web.Mvc;

namespace PortalGateway.Utility
{
    public static class ViewAssistant
    {
        public static string GetFormStringValue(string name, FormCollection collection)
        {
            if (collection == null || collection.Count <= 0)
            {
                return null;
            }

            var value = collection.Get(name);
            return value ?? string.Empty;
        }

        public static int GetFormIntegerValue(string name, FormCollection collection)
        {
            if (collection == null || collection.Count <= 0)
            {
                return 0;
            }

            int value;
            if (!int.TryParse(collection.Get(name), out value))
            {
                value = 0;
            }
            return value;
        }

        public static DateTime GetFormDateTimeValue(string name, FormCollection collection)
        {
            if (collection == null || collection.Count <= 0)
            {
                return DateTime.MinValue;
            }

            DateTime value;
            if (!DateTime.TryParse(collection.Get(name), out value))
            {
                value = DateTime.MinValue;
            }
            return value;
        }

        public static string GetFormButtonValue(string name, FormCollection collection)
        {
            if (collection == null || collection.Count <= 0)
            {
                return null;
            }

            return collection.Get(name);
        }

        public static bool IsFormButtonSelected(string name, string value, FormCollection collection)
        {
            if (collection == null || collection.Count <= 0)
            {
                return false;
            }

            var button = collection.Get(name);
            return button != null && button.Equals(value);
        }
    }
}