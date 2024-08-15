using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 'T' will be the singleton class
public class BaseSingleton<T> where T : class, new()
{
    private static T instance;

    public void Init()
    {
        instance = this as T;
    }

    public static T GetInstance()
    {
        if (instance == null)
        {
            instance = new T();
        }
        return instance;
    }
}
