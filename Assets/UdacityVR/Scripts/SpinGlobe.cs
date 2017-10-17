using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinGlobe : MonoBehaviour {

    private bool spinEnabled = false;
    private bool lookEnabled = false;
    public float speed = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(lookEnabled)
        {
            if (GvrControllerInput.ClickButtonDown || Input.GetMouseButtonDown(0))
                toggleSpin();
        }
        if (spinEnabled)
            transform.Rotate(Vector3.down * Time.deltaTime * speed); 
    }

    public void toggleSpin()
    {
        spinEnabled = !spinEnabled;
        Debug.Log("Spin is now " + spinEnabled);
    }

    public void enableLook(bool isLookEnabled)
    {
        lookEnabled = isLookEnabled;
        Debug.Log("Look is now " + isLookEnabled);
    }
}
