using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SwitchCamera : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public InputActionReference toggleReference = null;


    void Start()
    {
        toggleReference.action.started += Change; 
    }


    void Change(InputAction.CallbackContext context){
    
        if(cam1.activeInHierarchy){
            cam1.SetActive(false);
            cam2.SetActive(true);
        }else if(cam2.activeInHierarchy){
            cam2.SetActive(false);
            cam1.SetActive(true);
        }
          
    
    }
}
