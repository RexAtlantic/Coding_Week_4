using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    //variables

    public TextMeshProUGUI text;

    public InputActionReference e;

    public InputActionReference d;

    private int score;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = "Awooga";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + score;

        if (e.action.WasPressedThisFrame())
        {
            //++ adds one
            score++;
        }

        if (d.action.WasPressedThisFrame())
        {
            score--;
        }


        if (score >= 10)
        {
            text.color = Color.green;
        }

        else if (score < 0)
        { 
            text.color = Color.teal;
        }

        else 
        {
            text.color = Color.crimson;
        }

        
    }
}
