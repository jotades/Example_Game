using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Property : MonoBehaviour
{
    // Start is called before the first frame update
    private int _score;
    public Text scoreText;
    private int _velocity;
    public Text velocityText;

    public int Score
    {
        get 
        {
            return _score;
        }
        set
        {
            _score = value;
            scoreText.text = _score.ToString();            
        }
    }
    public int Velocity
    {
        get
        { 
            return _velocity; 
        }
        set
        {
            _velocity = value;
            velocityText.text = _velocity.ToString();
        }
    }   
}
