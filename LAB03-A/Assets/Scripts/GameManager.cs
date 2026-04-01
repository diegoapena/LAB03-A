using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    
    //LinkedList<string> ListaDeNombres = new();

    public CustomLinkedList HordaManagmet ;

    public Enemy EnemyPrefab;

    public void Start()
    {
        HordaManagmet .Set(EnemyPrefab);


        HordaManagmet.Add(new());
        HordaManagmet.Add(new());
        HordaManagmet.Add(new());
        HordaManagmet.Add(new());
        print(HordaManagmet.Count);

    }
    /*
    public void TestNodes()
    {
        Node<string> a = new("Juan");
        Node<string> b = new("Juan2");
        Node<string> c = new("Juan3");
        Node<string> d = new("Juan4");
        Node<string> e = new("Juan5");
        a.SetNext(b);
        b.SetNext(c);
        c.SetNext(d);
        d.SetNext(e);
        Node<string> Evaluator = a;

        while (Evaluator != null)
        {
            Debug.Log(Evaluator.Value);
            Evaluator = Evaluator.Next; 
        }


    }
    [Button]
    public void TestLinkedList( List<string> ListaNombres)
    {
        LinkedList<string> ListaDeNombres = new();
        foreach (string n in ListaNombres)
        {
            ListaDeNombres.Add(n);
        }
        ListaDeNombres.RemoveFirst();

        ListaDeNombres.RemoveLast();

        ListaDeNombres.Traverse(value => Debug.Log(value.Value));
    }
    */
    [Button]
    public void HordeSpawnTest()
    {
       
        HordaManagmet .SpawnHorde();
    }
}
