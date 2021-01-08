using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Originator
{
    private string article;



    // Sets the value for the article

    

    public void set(string newArticle)
    {

        //System.out.println("From Originator: Current Version of Article\n" + newArticle + "\n");

        this.article = newArticle;
        storeInMemento();
    }



    // Creates a new Memento with a new article



    public Memento storeInMemento()
    {

        // System.out.println("From Originator: Saving to Memento");

        return new Memento(article);

    }



    // Gets the article currently stored in memento



    public string restoreFromMemento(Memento memento)
    {




        article = memento.getSavedArticle();




        // System.out.println("From Originator: Previous Article Saved in Memento\n" + article + "\n");




        return article;




    }
}
