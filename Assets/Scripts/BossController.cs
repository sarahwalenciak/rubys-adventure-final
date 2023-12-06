// Sarah did this script!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossController : MonoBehaviour
{
    
    public Color loadToColor = Color.white;
    
    public int maxHealth = 5;


    public int health { get { return currentHealth; }}
    int currentHealth;

    public float timeInvincible = 1.0f;
    bool isInvincible;
    float invincibleTimer;
    
    // Start is called before the first frame update
    void Start()
    {
      currentHealth = maxHealth;  
    }

 void OnCollisionEnter2D(Collision2D other)
    {
       RubyController player = other.gameObject.GetComponent<RubyController >();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }

    // Update is called once per frame
    void Update()
    {
       if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        } 

        if (currentHealth == 0)
        {
           Initiate.Fade("WinScene",loadToColor,1.0f); 
        }
    }

public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
                return;

            isInvincible = true;
            invincibleTimer = timeInvincible;
        }    
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
        
       UIBossHealthBar.instance.SetValue(currentHealth / (float)maxHealth);  
        
    }


 
}

