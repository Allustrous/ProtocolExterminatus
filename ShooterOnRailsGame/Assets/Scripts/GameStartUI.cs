using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameStartUI : MonoBehaviour
{
    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
