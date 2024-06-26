/**************************************************************************************************************
* <Logic Script> Class
*
* Logic manager that will update the UI with information such as collected items, health, 
* active powerup and duration etc.
* TODO: Add checks for null references and create powerup UI
* Created by: <Aidan McCarthy> 
* Date: <12/06/2024>
*
***************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    //UI References 
    public Text healthText;
    public Text powerupText;
    
    //Player Reference
    private Player player;
    
    void Start()
    {
        healthText = GameObject.Find("HealthText").GetComponent<Text>();
        powerupText = GameObject.Find("PowerupText").GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
       UpdateHealthUI(player.health);
       UpdatePowerupUI();
    }
    
    //Update the health UI with current player health 
    public void UpdateHealthUI(int health)
    {
       if (healthText != null)
        {
            healthText.text = $"Health: {health}";
        }
    }
     public void UpdatePowerupUI()
    {
       if (player.ActivePowerup != null)
       {
            powerupText.text = player.ActivePowerup;
       }
    }

}
