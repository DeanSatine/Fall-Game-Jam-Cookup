using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : Button
{
    private Button button;
    private Text text;
    private string defaultText;
    private string highlightText;
    void Start()
    {
        button = GetComponent<Button>();
        text = GetComponentInChildren<Text>();
        defaultText = text.text;
        highlightText = text.text + " <";
    }

    // Update is called once per frame
    void Update()
    {
        //if (text.text.Contains('<')) text.text = defaultText.Remove(defaultText.IndexOf('<'));

        if (IsHighlighted())
        {
            text.text = highlightText;
        }
        else
        {
            text.text = defaultText;
        }
    }
}
