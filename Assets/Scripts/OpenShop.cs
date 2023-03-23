 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    public GameObject Shop;
    public void OpenPanel()
    {
        if (Shop != null)
        {

            Shop.SetActive(true);
            Time.timeScale = 0f;
            Shop = null;
        }
        else
        {
            Shop.SetActive(false);
            Time.timeScale = 1f;

        }
    }
}