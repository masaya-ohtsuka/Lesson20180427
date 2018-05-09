using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyObject : MonoBehaviour {

    public GameObject effectPrefab1;
    public GameObject effectPrefab2;
    public int objectHP;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Shell")) {
            objectHP -= 1;
            
            if (objectHP > 0) { 
                //Destroy(gameObject);
                Destroy(other.gameObject);
                GameObject effect1 = (GameObject)Instantiate(effectPrefab1, transform.position, Quaternion.identity);
                Destroy(effect1, 1.0f);
            }
            else{
                Destroy(gameObject);
                Destroy(other.gameObject);
                GameObject effect2 = (GameObject)Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect2, 1.0f);

            }

        }

    }
}
