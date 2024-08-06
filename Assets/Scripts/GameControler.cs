using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    [SerializeField] private Text timer_text;
    [SerializeField] private GameObject convest_win;
    [SerializeField] private GameObject convest_lose;
    public float ticccc;
    public float ticccc1;
    private float timer = 30;
    private void Awake()
    {
        convest_win.SetActive(false);
        convest_lose.SetActive(false);
    }
    private void Update()
    {
        Timers_Update();
        timer_text.text = timer.ToString();
        if (timer <= 0)
            convest_lose.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Time.timeScale = 0f;
            convest_win.SetActive(true);
        }
    }

    public void Timers_Update()
    {
        if (!convest_win.active)
        {
            ticccc1 = ticccc;
            ticccc = MathF.Round(Time.time);
            if (ticccc1 < ticccc) timer--;
            if (timer < 0)
                timer_text.text = "0";
            else
                timer_text.text = timer.ToString();
        }
    }
}
