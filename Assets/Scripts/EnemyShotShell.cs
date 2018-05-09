using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour {

    public GameObject enemyShellPrefab;
    public float shotSpeed;
    public AudioClip shotSound;
    public int timeCount = 0;

	// Update is called once per frame
	void Update () {
        timeCount += 1;

        if (timeCount % 60 == 0) {
            GameObject enemyShell = Instantiate(enemyShellPrefab, transform.position, Quaternion.identity) as GameObject;

            Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody>();

            enemyShellRb.AddForce(transform.forward * shotSpeed);

            Destroy(enemyShell, 1.5f);

            AudioSource.PlayClipAtPoint(shotSound, transform.position);
        }
	}
}
