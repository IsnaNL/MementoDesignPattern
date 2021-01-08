using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Handler : MonoBehaviour
{
    public TMP_InputField InputField;
    //public TextMeshProUGUI text;
    private int curArticle = 0;
    private bool firstSave = true;
    // Start is called before the first frame update

    Originator originator = new Originator();
    Caretaker caretaker = new Caretaker();

    public void Save()
    {
        if (firstSave)
        {

            firstSave = false;
        }
        else
        {
            curArticle++;
        }
       
        originator.set(InputField.text); 
        caretaker.addMemento(originator.storeInMemento());
        Debug.Log(originator.restoreFromMemento(caretaker.getMemento(curArticle)));
        
        //curArticle
    }
    public void Undo()
    {
        
        if(curArticle <= 0)
        {
            curArticle = 0;
            return;
        }
        curArticle--;
        originator.set(originator.restoreFromMemento(caretaker.getMemento(curArticle)));
        Debug.Log(originator.restoreFromMemento(caretaker.getMemento(curArticle)));
        // text.text = originator.restoreFromMemento(caretaker.getMemento(curArticle));
        InputField.text = originator.restoreFromMemento(caretaker.getMemento(curArticle));
       
    }
    public void Redo()
    {
        if (curArticle == caretaker.mementos.Count -1 )
        {

            return;
        }
        curArticle++;
        originator.set(originator.restoreFromMemento(caretaker.getMemento(curArticle)));
        Debug.Log(originator.restoreFromMemento(caretaker.getMemento(curArticle)));
        InputField.text = originator.restoreFromMemento(caretaker.getMemento(curArticle));
    }
}
