using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    void Update()
    {

    }


    public void LoadNextScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }

    public void LoadNextMaid()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));

    }
    public void LoadNextMusic()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }
    public void LoadNextJoker()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 3));

    }
    public void LoadNextDrunk()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 4));

    }

    public void LoadMainMenu()
    {
        StartCoroutine(LoadLevel(0));

    }

    IEnumerator LoadLevel (int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}


