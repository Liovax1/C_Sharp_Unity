using UnityEngine;

public class GetSpeedPlayer : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetSpeed();
        }
    }

    void GetSpeed()
    {
        GameObject Player;
        Player = GameObject.Find("Player");
        Player.GetComponent<Movement>().speed = 0;

        // La m�me chose
        GameObject.Find("Player").GetComponent<Movement>().speed = 0;
    }
}
