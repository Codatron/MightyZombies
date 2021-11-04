using UnityEngine;
using System.Collections;
using TMPro;

public class DetectedTextScript : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    PlayerScript playerScript;
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }
    private void Update()
    {
        textMesh.text = string.Format("Detected: {0}", playerScript.detected);
    }
}
