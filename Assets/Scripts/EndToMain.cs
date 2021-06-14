using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndToMain : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
