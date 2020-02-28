using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystemWithChoice : MonoBehaviour
{
    public GameObject textbox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;

    public void ChoiceOption()
    {
        textbox.GetComponent<Text>().text = "Aw that so cute of your Dear. Looks like you made the first choice.";
        ChoiceMade = 1;
    }

    public void ChoiceOption2()
    {
        textbox.GetComponent<Text>().text = "Its just a precautions Dear. Looks like you chose the second option";
        ChoiceMade = 2;
    }

    public void ChoiceOption3()
    {
        textbox.GetComponent<Text>().text = "Dont leave with out taking your prize <3. Looks like you made the last choice";
        ChoiceMade = 3;
    }
    void Update()
    {
        if(ChoiceMade >= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(false);
        }
    }
}
