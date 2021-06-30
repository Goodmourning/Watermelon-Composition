using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    private int _score;
    public Text scoreTxt;
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            scoreTxt.text = _score.ToString();
        }
    }
}
