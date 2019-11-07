using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{ 
    public Text scoreText;

    private void Update()
    {
        scoreText.text = "Score " + DistanceChecker.points.ToString();
    }
}
 