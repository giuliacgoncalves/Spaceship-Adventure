using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject explosion;
    public string alvo;
    Score score;

    public void Awake(){
      score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    void OnTriggerEnter2D(Collider2D colision){
      if(colision.name.StartsWith(alvo)){
        Vector3 position = colision.transform.position;
        GameObject clone = (GameObject)Instantiate(explosion, position, Quaternion.identity);
        score.Pontuar();
        Destroy(colision.gameObject);
        Destroy(this.gameObject);
        Destroy(clone, 0.3f);
        if(colision.name.StartsWith("Player")){
          SceneManager.LoadScene(2);
        }
      }
    }
}
