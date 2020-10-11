using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RemptyTool.ES_MessageSystem;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ES_MessageSystem))]
public class UsageCase : MonoBehaviour
{
    private ES_MessageSystem msgSys;
    public UnityEngine.UI.Text uiText;
    public TextAsset textAsset;
    private List<string> textList = new List<string>();
    private int textIndex = 0;

    void Start()
    {
        msgSys = this.GetComponent<ES_MessageSystem>();
        if (uiText == null)
        {
            Debug.LogError("UIText Component not assign.");
        }
        else
            ReadTextDataFromAsset(textAsset);

        //add special chars and functions in other component.
        msgSys.AddSpecialCharToFuncMap("solar", CustomizedFunction);
        msgSys.AddSpecialCharToFuncMap("massdriver", massdriver);
        msgSys.AddSpecialCharToFuncMap("MPD", MPD);
        msgSys.AddSpecialCharToFuncMap("NEMP", NEMP);
        msgSys.AddSpecialCharToFuncMap("Bussard", Bussard);
        msgSys.AddSpecialCharToFuncMap("wormhole", wormhole);
    }

    private void CustomizedFunction()
    {
        SceneManager.LoadScene(2);
    }

    private void massdriver()
    {
        SceneManager.LoadScene(3);
    }
    private void MPD()
    {
        SceneManager.LoadScene(4);
    }

    private void NEMP()
    {
        SceneManager.LoadScene(5);
    }

    private void Bussard()
    {
        SceneManager.LoadScene(6);
    }

    private void wormhole()
    {
        SceneManager.LoadScene(31);
    }

    private void ReadTextDataFromAsset(TextAsset _textAsset)
    {
        textList.Clear();
        textList = new List<string>();
        textIndex = 0;
        var lineTextData = _textAsset.text.Split('\n');
        foreach (string line in lineTextData)
        {
            textList.Add(line);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //You can sending the messages from strings or text-based files.
            if (msgSys.IsCompleted)
            {
                msgSys.SetText("Send the messages![lr] HelloWorld![w]");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Continue the messages, stoping by [w] or [lr] keywords.
            msgSys.Next();
        }

        //If the message is complete, stop updating text.
        if (msgSys.IsCompleted == false)
        {
            uiText.text = msgSys.text;
        }

        //Auto update from textList.
        if (msgSys.IsCompleted == true && textIndex < textList.Count)
        {
            msgSys.SetText(textList[textIndex]);
            textIndex++;
        }
    }
}
