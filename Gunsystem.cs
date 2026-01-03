using UnityEngine;

public class GunSystem : MonoBehaviour
{
    public float damage = 25f; // Ek goli ka damage
    public float range = 100f; // Kitni door tak goli jayegi
    public Camera fpsCam;      // Player ki aankh (Camera)

    void Update()
    {
        // Agar Mouse ka Left Button ya Fire button daba ho
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        // Check karna ki samne dushman hai ya nahi
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log("Goli lagi: " + hit.transform.name);

            // Agar dushman ko lagi, to use damage do
            EnemyAI enemy = hit.transform.GetComponent<EnemyAI>();
            if (enemy != null)
            {
                enemy.EnemyDie(); // Dushman ko khatam karne ka logic
            }
        }
    }
}
