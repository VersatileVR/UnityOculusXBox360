using UnityEngine;
using System.Collections;

public class PlayClipOnLook : MonoBehaviour {

    public Canvas dialogue;
    private bool seen = false;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	    if(gameObject.GetComponent<Renderer>().isVisible && !seen)
        {
            seen = true;
            gameObject.GetComponent<AudioSource>().Play();
            dialogue.enabled = true;
        }
	}
}
