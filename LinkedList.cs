using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SinglyLinkedList
{
	public class LinkedList
	{
		public NodeClass headNode;

		public LinkedList()
		{
			headNode = null;
		}

		public void AddHead( int data )
		{
			NodeClass newNode = new NodeClass(data);
			newNode.next = headNode;
			headNode = newNode;
		}

		public void AddTail(int data)
		{
			NodeClass newNode = new NodeClass(data);

			if(headNode == null)
			{
				headNode = newNode;
			}
			else
			{
				NodeClass curNode = newNode;
				while(curNode.next != null)
				{
					curNode = curNode.next;
				}
				curNode.next = newNode;
			}
		}

		public bool RemoveData(int data)
		{
			if(headNode == null)
				return false;

			if(headNode.data == data)
			{
				headNode = headNode.next;
				return true;
			}

			NodeClass curNode = headNode;

			while(curNode.data == data)
			{
				return true;

				if(curNode.next.data == data)
				{
					curNode.next.data = curNode.next.next.data;
                }
                curNode = curNode.next;
            }
				return false;
		}

        public NodeClass AddIndex( int index )
        {
			if(index < 0)
			{
                return null;
			}

			NodeClass curNode = headNode;

			for(int i = 0; i < index && curNode != null; i++)
            {
                curNode = curNode.next;
            }
            return curNode;
        }

		


    }
}

