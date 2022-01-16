using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            LoadingNewScene();
        }
    }
    public void LoadingNewScene()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
