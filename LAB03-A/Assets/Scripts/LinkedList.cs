//lista enlazada generica

using System;
using UnityEngine;

public class LinkedList<T> : MonoBehaviour 
{
    public Node<T> head = null;
    public int Count;
    public virtual void Add(T value)
    {
        Node<T> tempNode = new(value);
        //-> cuando head es igual a uno
        if (head == null)
        {
            head = tempNode;
        }
        else
        {
            Node<T> Evaluator = head;

            while (Evaluator.Next != null)
            {
                Evaluator = Evaluator.Next;
            }

            Evaluator.SetNext(tempNode);
        }
        Count++;
    }
    public void RemoveLast()
    {
        Node<T> Evaluator = head;

        if (Count == 0)
        {
            Debug.Log("Lista Vacia");
            return;
        }
        else if (Count == 1)
        {
            head = null;

        }
        else if (Count == 2)
        {
            head.SetNext(null);

        }
        else if (Count > 2)
        {
            while (Evaluator != null)
            {
                if (Evaluator.Next.Next == null)
                {
                    break;
                }

                Evaluator = Evaluator.Next;
            }
            Evaluator.SetNext(null);
        }
    }
    public void RemoveFirst()

    {
        if(Count <=1)
        {
            head = null;
            return;
            
        }
        Node<T> Evaluator = head.Next;

        head.SetNext(null);

        head = Evaluator;
    }

    public void Traverse(Action<Node<T>> action)
    {
        Node<T> Evaluator = head;
        while (Evaluator != null)
        {
            action(Evaluator);

            //Debug.Log(Evaluator.Value);

            Evaluator = Evaluator.Next;
        }
    }
}

