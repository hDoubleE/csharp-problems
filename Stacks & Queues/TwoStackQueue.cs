public class MyQueue<T>
    {
        Stack<T> eStack, dStack;

        // eStack = newest on top
        // dStack = oldest on top

        public MyQueue()
        {
            eStack = new Stack<T>();
            dStack = new Stack<T>();
        }

        public int Count()
        {
            return eStack.Count + dStack.Count;
        }

        public void Enqueue(T value)
        {
            eStack.Push(value);
        }

        public T Dequeue()
        {
            FlipStacks();
            return dStack.Pop();
        }

        public T Peek()
        {
            FlipStacks();
            return dStack.Peek();
        }

        private void FlipStacks()
        {
            if (dStack.Count == 0)
            {
                while (eStack.Count > 0)
                {
                    dStack.Push(eStack.Pop());
                }
            }
        }
    }