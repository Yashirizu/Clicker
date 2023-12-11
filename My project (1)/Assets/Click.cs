using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Click : MonoBehaviour
{

    public Canvas Button;

    public TextMeshProUGUI text;

    public int score; 

    private void OnMouseDown()
    {

    }



    public void clic()
    {
        score++;
        text.text = "Cookies " + score.ToString();
    }





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
