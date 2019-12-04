using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllerForPc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                hit.transform.gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }
}
