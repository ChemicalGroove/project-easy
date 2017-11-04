using UnityEngine;
using System.Collections;

public class faceMouse : MonoBehaviour {

	Vector3 mousePos;

	public void face () {
    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
	}

}
