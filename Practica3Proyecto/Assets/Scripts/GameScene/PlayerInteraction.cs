using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float InteractionDistance;
    public LayerMask InteractionMask;
    public Camera PlayerCam;

    //private void Start()
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        CheckForInteraction();
    //    }
    //}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckForInteraction();
        }
    }

    public void CheckForInteraction()
    {
        RaycastHit hit; //cambio de ray a hit
        if (Physics.Raycast(PlayerCam.transform.position, PlayerCam.transform.forward, out hit, InteractionDistance, InteractionMask)) //rigth for forward
        {
            InteractableObject interactableObject = hit.collider.gameObject.GetComponent<InteractableObject>();
            if (interactableObject != null)
            {
                interactableObject.Interact();
            }
        }
    }
}