using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMaxScore : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField in_txt;
    string maxScore = "MaxScore";
    public int max;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        string maxscore = in_txt.text;
        Debug.Log(int.Parse(maxscore));
        PlayerPrefs.SetInt(maxScore, int.Parse(maxscore));
        PlayerPrefs.Save();
    }
}
