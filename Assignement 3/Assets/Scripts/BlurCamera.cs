using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.InputSystem;

public class BlurCamera : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    public  GameObject blur;


    private void Awake() {
        toggleReference.action.started += Toggle2;
    }

    private void OnDestroy() {
        toggleReference.action.started -= Toggle2;
    }

    private void Toggle2(InputAction.CallbackContext context){
        bool isActive = !blur.GetComponent<Volume>().isActiveAndEnabled;
        blur.GetComponent<Volume>().enabled = isActive;
    
    }
}
