using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Islander.Player
{
    public enum InfoType
    {
        String,
        Int,
        Float
    }

    public abstract class InfoAttribute
    {
        public InfoType infoType;
    }

    public class InfoAttribute<T> : InfoAttribute
    {
        public T data;
    }

    public class StringInfoAttribute : InfoAttribute<string>
    {
        public bool Empty
        {
            get
            {
                return string.IsNullOrEmpty(data);
            }
        }
    }

    public class IntInfoAttribute : InfoAttribute<int>
    {
    }

    public class FloatInfoAttribute : InfoAttribute<float>
    {
    }
}