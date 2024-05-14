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
    private IGimmick gimmick;
    private RaycastHit hitInteract;
    private RaycastHit oldInteract;
    private bool isHit;
    private bool isInteract;

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
            playercontext.playerHead.transform.forward,
            out hitInteract,
            playerData.InteractDistance,
            playerData.InteractLayer);

        Debug.DrawRay(
            playercontext.playerHead.transform.position,
            playercontext.playerHead.transform.forward,
            Color.red,
            playerData.InteractDistance);

        if (!isHit) { return; }

        if (context.started)
        {
            oldInteract = hitInteract;
        }

        if(oldInteract.transform.gameObject == null)
        {
            return;
        }

        if(context.canceled && oldInteract.transform.gameObject == hitInteract.transform.gameObject)
        {
            Debug.Log("PlayGimmick");
            oldInteract.transform.GetComponent<IGimmick>().PlayGimmick();
        }
    }
}
