using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class New_Lewel : MonoBehaviour
{
    [SerializeField] private int naxt_lewel;
    public void Change_Lewel()
    {
        SceneManager.LoadScene(naxt_lewel);
    }
}
