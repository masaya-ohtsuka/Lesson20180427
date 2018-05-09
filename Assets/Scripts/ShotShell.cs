using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotShell : MonoBehaviour {

    public GameObject shellPrefab;
    public AudioClip shotSound;
    public float shotSpeed;
    public int shotCount;
    public Text shellLabel;

	// Use this for initialization
	void Start () {
        shellLabel.text = "SHELL:" + shotCount;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Shot")) {

            if (shotCount < 1) {
                return;
            }

            shotCount -= 1;
            shellLabel.text = "SHELL:" + shotCount;

            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity) as GameObject;
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
            shellRb.AddForce(transform.forward * shotSpeed);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);

            Destroy(shell, 2.0f);
        }	
	}
}
