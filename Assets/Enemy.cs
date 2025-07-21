using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Color enemyColor = Color.red;
    private string message = "Waza";
    private string byeMessage = "SeeYa";

    void Start()
    {
        Greetings();
    }


    void Update()
    {
        
    }

    void Greetings()
    {
        Debug.Log(message);
    }
}
