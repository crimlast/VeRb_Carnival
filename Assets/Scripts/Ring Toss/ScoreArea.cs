using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreArea : MonoBehaviour
{
    public TMPro.TextMeshProUGUI txt;
    public int score = 0;
    
    void OnTriggerEnter (Collider otherCollider) {

        if(otherCollider.name == "BasketBall") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder1") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder2") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder3") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder4") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder5") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder6") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder7") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder8") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder9") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder10") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder11") {
            score += 10;
            txt.text = score.ToString();
        }
        if(otherCollider.name == "Cylinder12") {
            score += 10;
            txt.text = score.ToString();
        }
    }
}
