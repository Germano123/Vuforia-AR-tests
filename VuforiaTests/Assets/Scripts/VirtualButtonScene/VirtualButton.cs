using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject virtualBtn;
    public GameObject cube;

    private bool rotate;

    // Start is called before the first frame update
    void Start()
    {
        virtualBtn = GameObject.Find("VirtualButton");
        virtualBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        CheckRotate();
    }

    private void CheckRotate()
    {
        if (rotate)
        {
            cube.transform.Rotate(0.0f, 45.0f * Time.deltaTime, 0.0f);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Pressed");
        rotate = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Released");
        rotate = false;
    }
}
