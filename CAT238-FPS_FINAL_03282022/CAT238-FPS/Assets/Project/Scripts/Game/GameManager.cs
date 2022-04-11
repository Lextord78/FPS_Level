using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Game")]
    public GameObject enemySpawner;

    public Player player;
    [Header("UI")]
    public Text ammoText;
    public Text healthText;
    public Text enemyText;
    public Text InfoText;
    
    // Start is called before the first frame update
    void Start()
    {
        InfoText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = "Ammo: " + player.Ammo;
        healthText.text = "Health: " + player.Health;
        

        int killedEnemies = 0;

        foreach(Enemy enemy in enemySpawner.GetComponentsInChildren<Enemy>())
        {
            if(enemy.Killed == false)
            {
                killedEnemies++;
            }
        }
        enemyText.text = "Enemies: " + killedEnemies;

        if(killedEnemies == 0)
        {
            InfoText.gameObject.SetActive(true);
        }

        if(player.Killed == true)
        {
            InfoText.gameObject.SetActive(true);
            InfoText.text = "you lose!";
        }
                
    }
}
