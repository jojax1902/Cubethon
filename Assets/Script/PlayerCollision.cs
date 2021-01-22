using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Transform player;
    public bool Moving = true;
    public bool gamestart = false;

    public void Start()
    {
        movement.enabled = false;
    }


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }        
    }

    private void FixedUpdate()
    {
        if (player.transform.position.y < 0)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if (Input.GetKey("space") && gamestart == false)
        {
            movement.enabled = true;
            gamestart = true;
        }
    }

    void RestartGame()
    {
        Moving = false;
    }
}
