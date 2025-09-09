using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float xStartPos = 4.0f;

    private Transform ballTransform;

    private Vector3 enemyPosition;

    // Start is called before the first frame update
    void Start()
    {
        // temporary - to replace with gameController setting these up
        ballTransform = GameObject.Find("TheBall").transform;

        transform.position.Set(xStartPos, 0.0f, 0.0f);
        enemyPosition = new Vector3(xStartPos, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        enemyPosition.y = ballTransform.position.y;
        transform.position = enemyPosition;
    }
}
