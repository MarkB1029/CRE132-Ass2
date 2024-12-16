using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{ 
    public GameManager gameManager;
    private bool isDead;


    public float health;
    public float maxHealth;
    public Image healthBar;


    // Start is called before the first frame update
    void Start()
    {

        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    
        if (health <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);
            gameManager.GameOver();
            Debug.Log("Dead");
        }
    }
}
