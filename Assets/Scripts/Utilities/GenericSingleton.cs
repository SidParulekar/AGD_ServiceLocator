using ServiceLocator.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T:GenericSingleton<T>
{
    public static T Instance { get { return instance; } }

    private static T instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = (T)this;
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
}
