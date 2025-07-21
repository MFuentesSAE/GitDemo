using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Color enemyColor = Color.yellow;
    private string message = "Waza";
    private string byeMessage = "SeeYa";
    public Material enemyMaterial;

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
