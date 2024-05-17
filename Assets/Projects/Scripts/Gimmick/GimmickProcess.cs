using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Parameter;

public class GimmickProcess
{
    private PlayerContext playercontext;
    private PlayerData playerData;
    private RaycastHit hitInteract;
    private RaycastHit oldInteract;
    private bool isHit;

    public GimmickProcess(PlayerContext context)
    {
        playerData = context.playerData;
        playercontext = context;

        try
        {
            context.inputActions.Player.OnInteract.started -= OnInteract;
            context.inputActions.Player.OnInteract.canceled -= OnInteract;
        }
        catch { }

        context.inputActions.Player.OnInteract.started += OnInteract;
        context.inputActions.Player.OnInteract.canceled += OnInteract;
    }

    private void OnInteract(InputAction.CallbackContext context)
    {
        isHit = Physics.Raycast(
            playercontext.playerHead.transform.position,
            playercontext.playerHead.transform.forward * playerData.InteractDistance,
            out hitInteract,
            playerData.InteractDistance,
            playerData.InteractLayer);

        //Debug.DrawRay(
        //    playercontext.playerHead.transform.position,
        //    playercontext.playerHead.transform.forward *playerData.InteractDistance,
        //    Color.red,
        //    playerData.InteractDistance);

        if (context.started && isHit)
        {
            oldInteract = hitInteract;
            hitInteract.transform.GetComponent<IGimmick>().StartGimmick();
            return;
        }

        if (context.canceled && oldInteract.transform == hitInteract.transform)
        {
            hitInteract.transform.GetComponent<IGimmick>().CancelGimmick();
        }
        else
        { 
            oldInteract.transform.GetComponent<IGimmick>().StopGimmick();
        }
    }
}
