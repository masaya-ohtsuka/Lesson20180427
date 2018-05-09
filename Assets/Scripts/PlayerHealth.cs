using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public GameObject effectPrefab1;
    public GameObject effectPrefab2;
    public int PlayerHP;
    public Text HPLabel;
    private Slider slider;

    void Start(){
        HPLabel.text = "HP:" + PlayerHP;
        slider = GameObject.Find("HPSlider").GetComponent<Slider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyShell"))
        {
            PlayerHP -= 1;
            HPLabel.text = "HP:" + PlayerHP;
            slider.value = PlayerHP;

            if (PlayerHP > 0)
            {
                //Destroy(gameObject);
                Destroy(other.gameObject);
                GameObject effect1 = (GameObject)Instantiate(effectPrefab1, transform.position, Quaternion.identity);
                Destroy(effect1, 1.0f);
            }
            else
            {
                //Destroy(gameObject);
                this.gameObject.SetActive(false);
                GameObject effect2 = (GameObject)Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect2, 1.0f);

                Invoke("ReStart", 3.0f);

            }

        }

    }

    void ReStart() {
        SceneManager.LoadScene("Main");
        //Application.LoadLevel("Main");
    }
}
