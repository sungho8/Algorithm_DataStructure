using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public int Data { get; set; }
        public Node nextNode;

        // 생성자_1 : 가르키는 노드가 없을때
        public Node(int Data)
        {
            this.Data = Data;
            this.nextNode = null;
        }
        // 생성자_2 : 가르키는 노드가 있을때
        public Node(int Data, Node nextNode)
        {
            this.Data = Data;
            this.nextNode = nextNode;
        }

        public void PrintData()
        {
            Console.Write(Data + " - ");
        }
    }

    class List
    {
        private Node firstNode;
        private int length;

        public List(int Data)
        {
            firstNode = new Node(Data);
            length = 1;
        }

        // 지정한 position의 node를 반환
        public Node GetNodePos(int position)
        {
            Node currentNode = firstNode;

            if (length < position)  // list보다 더 큰값을 요구했을때
                return null;

            for (int i = 0; i < position - 1; i++)
            {
                currentNode = currentNode.nextNode;
            }
            return currentNode;
        }

        // Add : 지정한 위치뒤에 node 삽입
        public void Add(int data, int position)
        {
            if (position == 0)
            {
                Node newNode = new Node(data);
                newNode.nextNode = firstNode;
                firstNode = newNode;
                length++;
            }
            else if (length + 1 >= position)  // list의 크기에 알맞는 값을 요구했을때
            {
                Node newNode = new Node(data);
                Node frontNode = GetNodePos(position);

                newNode.nextNode = frontNode.nextNode;
                frontNode.nextNode = newNode;

                length++;
            }
            else
            {
                Console.WriteLine("잘못된 삽입입니다.");
            }
        }

        // Remove : 내가 정한 값을 찾아서 삭제
        public void Remove(int Data)
        {
            Node removeNode = firstNode;
            Node preNode = firstNode;

            for (int i = 0; i < length; i++)
            {
                if (removeNode.Data == Data)
                    break;
                preNode = removeNode;
                removeNode = removeNode.nextNode;
            }
            preNode.nextNode = removeNode.nextNode;
            length--;
        }

        // Search : 내가 정한 값을 검색
        public Node Search(int Data)
        {
            Node currentNode = firstNode;

            for (int i = 0; i < length; i++)
            {
                if (currentNode.Data == Data)
                {
                    Console.WriteLine("해당 값은 리스트에 있습니다.");
                    return currentNode;
                }
                currentNode = currentNode.nextNode;
            }
            Console.WriteLine("해당 값은 리스트에 없습니다.");
            return null;
        }
        public void RemoveAll()
        {
            firstNode = null;
            length = 0;
        }

        public void PrintAll()
        {
            Console.Write("List : ");
            Node currentNode = firstNode;
            for (int i = 0; i < length; i++)
            {
                currentNode.PrintData();
                currentNode = currentNode.nextNode;
            }
            Console.WriteLine("Null");
        }
    }
}
