using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Right : MonoBehaviour
{
    private float timer = 0.5f;
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                if (touch.position.x - touch.rawPosition.x > 100)
                    if (touch.deltaPosition.y < 50)
                        if (touch.deltaPosition.y > -50)
                            Debug.Log("Свайп в право!");
                timer = 0.5f;
            }
        }
    }
}
