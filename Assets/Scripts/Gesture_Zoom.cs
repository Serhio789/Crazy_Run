using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gesture_Zoom : MonoBehaviour
{
    [SerializeField] private bool if_remut;
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touch1 = new Vector2(150, 150);

            Vector2 touch_last_poz = touch.position - touch.deltaPosition;

            float distance_touch = (touch_last_poz - touch1).magnitude;
            float courren_distance = (touch1 - touch.position).magnitude;

            if (courren_distance > distance_touch)
                Debug.Log("Zoom");
        }
    }
}
