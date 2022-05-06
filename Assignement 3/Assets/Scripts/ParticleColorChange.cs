using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ParticleColorChange : MonoBehaviour
{
    public InputActionReference colorRefernece = null;
    private ParticleSystem ps;

    private void Awake() {
        ps = GetComponent<ParticleSystem>();
        colorRefernece.action.started += UpdateValue; 
    }



    private void UpdateValue(InputAction.CallbackContext context){
        var main = ps.main;

        if(main.startColor.color == Color.white){
            main.startColor = Color.green;
        }else{
             main.startColor = Color.white;

        }


        
    }
}
