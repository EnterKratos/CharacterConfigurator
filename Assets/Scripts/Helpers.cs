using System;
using UnityEngine;

namespace CharacterConfigurator
{
    public static class Helpers
    {
        public static string FormatCurrencyValue(double value) => $"£{value}";

        public static int GetIndex(this Transform transform)
        {
            for (var i = 0; i < transform.parent.childCount; i++)
            {
                if (transform.parent.GetChild(i) == transform)
                {
                    return i;
                }
            }

            throw new IndexOutOfRangeException();
        }
    }
}