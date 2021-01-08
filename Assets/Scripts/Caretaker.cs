using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caretaker
{

    public List<Memento> mementos = new List<Memento>();
    
    // Start is called before the first frame update
    public void addMemento(Memento m) { mementos.Add(m) ; }
    public Memento getMemento(int index) { return mementos[index]; }


}
