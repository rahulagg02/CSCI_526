using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackholeController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 2.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        // 根据输入移动玩家
        transform.Translate(movement * speed * Time.deltaTime);

        
    }
}
