using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    int level = 0;
    public int xp = 0;
    int xpToLevel = 100;
    int maxLevel = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (xp >= xpToLevel)
        {
            if (level < maxLevel)
            {

                level++;
                Debug.Log("Ding! you reached level " + level);
                xp = xp - xpToLevel;
                xpToLevel += 50;
            }
        }
    }
}
