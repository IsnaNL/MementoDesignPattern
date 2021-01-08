using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memento 
{
    // Start is called before the first frame update
  
     

    // The article stored in memento Object
   
    private string article;
    // Save a new article String to the memento Object
    public Memento(string articleSave) { article = articleSave; }

    // Return the value stored in article
    public string getSavedArticle() { return article; }


}
