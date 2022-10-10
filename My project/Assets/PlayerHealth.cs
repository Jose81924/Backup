using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    public TextMeshProUGUI HealthText;
    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Health:" + health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherName = collision.gameObject.name;
        if (otherName == "Damage")
        {
            health--;
            Debug.Log(health);
            if(health <= 0)
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }
}