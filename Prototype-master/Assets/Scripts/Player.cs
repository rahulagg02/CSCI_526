using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 



public class Player : MonoBehaviour
{
    public string victorySceneName = "WinScene"; // 胜利场景的名称，设置为"WinScene"
    private bool hasWon = false;
    private void Update()
    {
        if (!hasWon)
        {
            // 获取玩家当前位置的X和Y坐标
            float playerX = transform.position.x;
            float playerY = transform.position.y;

            // 检查玩家位置是否在指定范围内
            if (playerX >= 2.5f && playerX <= 4.3f && playerY >= -4.8f && playerY <= -3.5f)
            {
                hasWon = true;
                ShowVictoryPage();
            }
        }
    }

    private void ShowVictoryPage()
    {
        // 激活游戏胜利页面，可以根据你的情况使用SetActive或其他方式
        SceneManager.LoadScene(victorySceneName);
    }
}
