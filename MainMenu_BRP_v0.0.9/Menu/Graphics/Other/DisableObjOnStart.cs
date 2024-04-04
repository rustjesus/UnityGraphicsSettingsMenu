using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObjOnStart : MonoBehaviour
{
    public GameObject[] obj;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < obj.Length; i++)
        {
            obj[i].SetActive(false);
        }
    }

 
}
