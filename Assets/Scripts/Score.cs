using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
  public int cont=0;
  public Text score;

    public void Pontuar(){
        cont+=1;
        score.text = "SCORE: " + cont.ToString();
    }
}
