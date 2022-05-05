using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;


public class AnimationState : MonoBehaviour
{

    public Animator animator;
    public InputActionReference toggleReference = null;


    void Awake()
    {
        animator = GetComponent<Animator>();
        toggleReference.action.started += Change; 
    }


    void Change(InputAction.CallbackContext context){
        bool active = animator.GetBool("isClicked");

        if(active){
            animator.SetBool("isClicked", false);
        }

        if(!active){
            animator.SetBool("isClicked", true);
        } 
    }
}
