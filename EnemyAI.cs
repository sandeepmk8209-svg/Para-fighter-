using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // Player ki location
    public float chaseSpeed = 3.0f; // Dushman ke doudne ki speed

    void Update()
    {
        if (player != null)
        {
            // Dushman player ki taraf dekhega
            transform.LookAt(player);

            // Dushman player ki taraf badhega
            transform.Translate(Vector3.forward * chaseSpeed * Time.deltaTime);
        }
    }
}
