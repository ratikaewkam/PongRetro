using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGoalController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GameObject.Find("GameManager").GetComponent<GameManagerController>().ManageLeftScore();
        }
    }
}
