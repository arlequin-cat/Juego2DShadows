using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Llegada : MonoBehaviour
{
    public int scena;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(scena);
    }
}
