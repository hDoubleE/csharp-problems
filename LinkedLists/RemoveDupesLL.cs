public void RemoveDupesWithMemory(Node<string> head)
        {
            Node<string> current = head;
            Node<string> previous = null;
            HashSet<string> set = new HashSet<string>();
            while (current != null)
            {
                if (set.Contains(current.Value))
                {
                    previous.Next = current.Next;
                }
                else
                {
                    set.Add(current.Value);
                    previous = current;
                }
                current = current.Next;
            }
        }

        public void RemoveDupesNoMemory(Node<string> head)
        {
            Node<string> slow = head;
            while (slow != null)
            {
                Node<string> fast = slow;
                while(fast.Next != null)
                {
                    if (fast.Next.Value == slow.Value)
                    {
                        fast.Next = fast.Next.Next;
                    }
                    else
                    {
                        fast = fast.Next;
                    }
                }
                slow = slow.Next;
            }
        }