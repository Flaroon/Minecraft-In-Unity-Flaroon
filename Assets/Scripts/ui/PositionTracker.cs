using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PositionTracker : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Player;

    private void FixedUpdate()
    {
        Text.text = "x: " + Mathf.RoundToInt(Player.transform.position.x).ToString() + " y: " + Mathf.RoundToInt(Player.transform.position.y).ToString() + " z: " + Mathf.RoundToInt(Player.transform.position.z).ToString();
    }
}
