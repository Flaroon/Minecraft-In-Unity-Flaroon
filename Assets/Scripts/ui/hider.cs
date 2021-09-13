using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hider : MonoBehaviour
{
    public GameObject g;
    public void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            g.SetActive(!g.activeInHierarchy);
        }
    }
}
