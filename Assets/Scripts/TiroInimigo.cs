using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{
  public GameObject tiro;
    void Start()
    {
      InvokeRepeating("Disparar", 0 , Random.Range(1,4));
    }
    void Disparar()
    {
        Instantiate(tiro, this.transform.position, Quaternion.identity);
    }
}
