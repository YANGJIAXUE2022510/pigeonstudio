using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnterCity : MonoBehaviour
{    public TMP_Text cityText; // 引用 TextMeshPro 对象
    public Button button; // 引用按钮对象
    // Start is called before the first frame update
    void Start()
    {
         
            button = GetComponent<Button>();

        // 添加按钮点击事件监听器
        button.onClick.AddListener(OnClick);
        }

     
    void OnClick()
    {
              if(cityText != null)
        {
          
            cityText.text =GlobalVariables.currentLocation;
        }
        else
        {
            Debug.LogWarning("TextMeshPro 对象未分配，请在Inspector面板中分配。");
        }  
    }
}
