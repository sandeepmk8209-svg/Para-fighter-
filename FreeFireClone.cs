using UnityEngine;

public class FreeFireClone : MonoBehaviour
{
    // Player ki raftar aur jaan (Health)
    public float speed = 8.0f;
    public float health = 100f;

    void Update()
    {
        // Keyboard se character ko aage-piche aur left-right move karne ke liye
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        
        transform.Translate(moveX, 0, moveZ);

        // Fire karne ka logic (agar mouse click ho)
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Goli Chali!");
        }
    }

    // Jab dushman goli maare to health kam karne ke liye
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Debug.Log("Game Over! Aap mar gaye.");
        }
    }
}
