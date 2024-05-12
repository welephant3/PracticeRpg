using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected ControlManager controller;

    protected virtual void Awake()
    { 
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<ControlManager>();
    }        
}