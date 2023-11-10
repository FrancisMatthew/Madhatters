using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class DialogueOption : MonoBehaviour
{
    public MeshRenderer textBox;

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.name == "Player")
        {
            textBox.enabled = true;
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.gameObject.name == "Player")
        {
            textBox.enabled = false;
        }
    }
}
