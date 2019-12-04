using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingEnableTarget : DefaultTrackableEventHandler
{
    // variable to check if the parent target is active
    private bool isActive = false;

    #region Unity_Monobehaviour_Methods
    protected override void Start()
    {
        base.Start();
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Reading if the target is active: ");
        Debug.Log(isActive);
    }

    #endregion

    #region TRACKING_METHODS
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

    #endregion

}