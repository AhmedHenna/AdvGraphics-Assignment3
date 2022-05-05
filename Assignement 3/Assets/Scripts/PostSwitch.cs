using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostSwitch : MonoBehaviour
{
    public GameObject postProcess;
   
    void Update()
    {
        if(Input.GetKey("1")){
            postProcess.SetActive(true);
        }
        if(Input.GetKey("2")){
            postProcess.SetActive(false);
        }
    }
}
