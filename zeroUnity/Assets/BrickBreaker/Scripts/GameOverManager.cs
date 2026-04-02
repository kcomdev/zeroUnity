using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("GameOver");
            collision.gameObject.SetActive(false);
        }
    }
}
