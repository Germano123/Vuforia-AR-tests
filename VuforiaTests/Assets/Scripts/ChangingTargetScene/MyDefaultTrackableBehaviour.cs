using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDefaultTrackableBehaviour : DefaultTrackableEventHandler
{
    // variable to control the game objects conditions
    private bool isActive;

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
        isActive = true;
    }


    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        isActive = false;
    }

    public bool IsActive()
    {
        return isActive;
    }
}