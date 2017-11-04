using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

	bool stop;

	public faceMouse faceMouse;

	// Use this for initialization
	void Start () {
		stop = true;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.S)) {
			stop = !stop;
		}
		if (!stop) faceMouse.face();
	}
}
