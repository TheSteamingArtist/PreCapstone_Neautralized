using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note2Script : MonoBehaviour
{
    public Image Note;

    void Start()
    {
        Note.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Note.GetComponent<Image>().enabled = true;
        NotesCollectedScript.infoCollected++;
        Destroy(this.gameObject);
        Debug.Log(NotesCollectedScript.infoCollected);
    }
}
