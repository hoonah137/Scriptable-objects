using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LenguageManager : MonoBehaviour
{
    public enum Lenguage
    {
        Ing,
        Esp,
        Cat
    }

    Lenguage _currentLenguage;

    public void SetEng()
    {
        _currentLenguage = Lenguage.Ing;

        Debug.Log("Eng");
    }

    public void SetEsp()
    {
        _currentLenguage = Lenguage.Esp;
        Debug.Log("Esp");

    }

    public void SetCat()
    {
        _currentLenguage = Lenguage.Cat;
        Debug.Log("Cat");

    }
   
}
