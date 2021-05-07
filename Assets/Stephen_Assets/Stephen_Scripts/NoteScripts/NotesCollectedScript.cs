using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NotesCollectedScript : MonoBehaviour
{
    public static int infoCollected = 0;

    public Canvas canvas;

    public AudioSource source;

    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("EndMessage").GetComponent<Canvas>();

        canvas.enabled = false;
    }


    void Update()
    {

        if(infoCollected == 5)
        {
            StartCoroutine(EndofGame());

            StartCoroutine(NextScene());
        }

    }

    IEnumerator EndofGame()
    {

        canvas.enabled = true;

        source.Play();

        yield return new WaitForSeconds(10);

        

    }

    IEnumerator NextScene()
    {

        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    

}
