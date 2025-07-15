using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Color enemyColor = Color.green;
    private string message = "Hello";
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
