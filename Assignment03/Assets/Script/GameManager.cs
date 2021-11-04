using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector4 playerStart;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        playerStart = player.transform.position;
    }

    public void Reset()
    {
        StartCoroutine("ResetCo");
    }

    public IEnumerator ResetCo()
    {
        player.gameObject.SetActive(false);
        yield return new WaitForSeconds(0f);
        player.transform.position = playerStart;
        player.gameObject.SetActive(true);
        
    }

}
