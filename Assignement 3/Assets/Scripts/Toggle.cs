using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Toggle : MonoBehaviour
{
    public InputActionReference toggleReference = null;

    private void Awake() {
        toggleReference.action.started += Toggle2;
    }

    private void OnDestroy() {
        toggleReference.action.started -= Toggle2;
    }

    private void Toggle2(InputAction.CallbackContext context){
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }
}
