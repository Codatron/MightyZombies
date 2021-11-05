using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finaleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool activated;
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("SceneMenu");
    }
}
