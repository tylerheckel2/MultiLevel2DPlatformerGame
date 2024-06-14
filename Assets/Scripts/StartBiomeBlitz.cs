using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBiomeBlitz : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("BB Start Screen");
    }
}
