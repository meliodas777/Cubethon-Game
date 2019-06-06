using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public  PlayerMovment  movement;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        } 
    }
}
