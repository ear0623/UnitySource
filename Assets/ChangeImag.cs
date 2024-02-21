using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Button SampleButton;
    public Image ChangedImage;
    public float Offset_Width;
    public float Offset_Height;

    // Start is called before the first frame update
    void Start()
    {
     SampleButton =GetComponent<Button>();
     SampleButton.onClick.AddListener(Clicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Clicked()
    {
        RectTransform rectTransform = ChangedImage.rectTransform;
        rectTransform.sizeDelta = new Vector2(Offset_Width, Offset_Height);
    }
}
