using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject[] buttonsToToggle; // 存储需要收缩/展开的按钮

    void Start()
    {
        // 隐藏所有需要收缩/展开的按钮
        foreach (GameObject button in buttonsToToggle)
        {
            button.SetActive(false);
        }
    }

    public void ToggleButtons()
    {
        // 循环遍历所有需要收缩/展开的按钮
        foreach (GameObject button in buttonsToToggle)
        {
            // 切换按钮的激活状态（显示/隐藏）
            button.SetActive(!button.activeSelf);
        }
    }
}
