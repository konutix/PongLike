using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float xStartPos = -4.0f;

    private Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position.Set(xStartPos, 0.0f, 0.0f);
        playerPosition = new Vector3(xStartPos, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        transform.position = playerPosition;
    }
}
