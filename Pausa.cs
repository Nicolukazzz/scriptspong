using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public void salirAlMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
