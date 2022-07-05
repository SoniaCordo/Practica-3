using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractableObject //cambie aqui
{
    private Animator doorAnimator;
    private bool animatorBoolState = true;

    private void Start()
    {
        doorAnimator = GetComponentInParent<Animator>();
    }

    public override void Interact() //Añadi esto
    {
        UseDoor();
    }

    public void UseDoor()
    {
        doorAnimator.SetBool("Abierta", animatorBoolState); //cambio IsOpen por Abierta
        animatorBoolState = !animatorBoolState;
    }
}