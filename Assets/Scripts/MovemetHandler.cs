using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemetHandler : MonoBehaviour
{
    [SerializeField] private InputHandler input_handler;
    void Start()
    {
        if (input_handler == null) Debug.LogError("InputHandler не назначен!!!");
    }
    private void MoveBall()
    {
        if (input_handler.IsThereTouchOnScreen())
        {
            Vector2 current_delta_position = input_handler.GetTouchDeltaPosition();
            Vector3 new_gravity_vector = new Vector3(current_delta_position.x, Physics.gravity.y, current_delta_position.y);
            Physics.gravity = new_gravity_vector;
        }
    }
    void Update()
    {
        MoveBall();
    }
}
