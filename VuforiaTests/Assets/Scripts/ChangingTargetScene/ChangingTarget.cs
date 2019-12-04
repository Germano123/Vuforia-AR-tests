using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingTarget : MonoBehaviour
{
    // reference to the vuforia image target script component
    [SerializeField] private MyDefaultTrackableBehaviour _trackableParent;
    [SerializeField] private MyDefaultTrackableBehaviour _trackableWhereTo;

    // variable to control cube speed
    public float speed = 5f;

    // vairable to control if is moving
    private bool isMoving = false;
    // variable to control where to go
    private Vector3 _direction = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        // check if parent is active
        if (_trackableParent.IsActive())
        {
            OnClick();
        }
    }

    void FixedUpdate()
    {
        if (_trackableParent.IsActive())
        {
            if (isMoving)
                MoveTo(_direction);
        }
    }

    private void OnClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray, out hit, LayerMask.GetMask("ImageTarget")))
            {
                Debug.Log("Hit something");
                _direction = hit.transform.position;
                Debug.Log(_direction);

            }
        }
    }

    private void MoveTo(Vector3 position)
    {
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
        isMoving = (transform.position == position) ? true : false;
    }
}