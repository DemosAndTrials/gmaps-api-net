﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WinStoreApp.Map
{
    internal static class ConvertUtil
    {
        public static bool TryCast<Tfrom, Tto>(IEnumerable<Tfrom> collection, out IEnumerable<Tto> convertedCollection) where Tto : class
        {
            IEnumerator collectionEnumerator = collection.GetEnumerator();

            List<Tto> target = new List<Tto>(collection.Count());

            while (collectionEnumerator.MoveNext())
            {
                if (collectionEnumerator.Current == null)
                {
                    target.Add(null);
                }
                else
                {
                    Tto convert = collectionEnumerator.Current as Tto;
                    if (convert == null) { convertedCollection = null; return false; }
                    target.Add(convert);
                }
            }

            convertedCollection = target;
            return true;
        }
    }
}
