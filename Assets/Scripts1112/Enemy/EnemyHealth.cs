using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float EnemyMaxHealth;
    public float EnemyCurrentHealth;
    public Image health;

   
    // Start is called before the first frame update
    void Start()
    {
        EnemyCurrentHealth = EnemyMaxHealth;

        // github test
    }
    void Update()
    {
        health.fillAmount = Mathf.Clamp(EnemyCurrentHealth / EnemyMaxHealth, 0, 1);
    }

    // Update is called once per frame
}
