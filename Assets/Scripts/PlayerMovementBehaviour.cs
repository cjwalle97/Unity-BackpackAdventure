using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovementBehaviour : MonoBehaviour
{

    public float _speed = 25f;
    // Update is called once per frame
    void Update()
    {
        var oldpos = transform.localPosition;
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        transform.localPosition += new Vector3(h, 0, v) * _speed * Time.deltaTime;
        var newpos = transform.localPosition;
        if (oldpos != newpos)
            OnPlayerMoved.Invoke();
    }

    public static UnityEvent OnPlayerMoved = new UnityEvent();
       
}
