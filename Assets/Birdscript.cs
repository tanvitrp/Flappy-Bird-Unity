using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.linearVelocity = Vector2.up * 10;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}