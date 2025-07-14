using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Color enemyColor = Color.green;
    void Start()
    {
        Greetings();
    }


    void Update()
    {
        
    }

    void Greetings()
    {
        Debug.Log("Hello");
    }
}
