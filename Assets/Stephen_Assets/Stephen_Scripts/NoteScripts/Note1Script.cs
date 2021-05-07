using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note1Script : MonoBehaviour
{
    public Image Note1;

    void Start()
    {
        Note1.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Note1.GetComponent<Image>().enabled = true;
        NotesCollectedScript.infoCollected++;

        Destroy(this.gameObject);
        Debug.Log(NotesCollectedScript.infoCollected);
    }

}
