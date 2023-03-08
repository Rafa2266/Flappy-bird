using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
  public void Resetgame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
