using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTarget : DefaultTrackableEventHandler
{
    // reference to player game object
    public CharacterControllerScript player = null;

    protected override void Start()
    {
        base.Start();
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if(player)
            player.SetActive(true);
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        if (player)
            player.SetActive(false);
    }

}