using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float MaxHealth;
    public float CurrentHealth;
    public Image HealthBar;

    public GameManager gameManager;
    private bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;

        // github test
    }
    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(CurrentHealth / MaxHealth, 0, 1);

        if(CurrentHealth <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);
            gameManager.GameOver();
            Debug.Log("Dead");
        }
    }

    // Update is called once per frame
}
