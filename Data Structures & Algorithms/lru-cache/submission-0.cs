public class LRUCache 
{
    // Обычный узел списка, ничего лишнего
    public class Node 
    {
        public int Key;
        public int Value;
        public Node Prev;
        public Node Next;

        public Node(int key, int value) 
        {
            this.Key = key;
            this.Value = value;
        }
    }

    public int Capacity;
    public Dictionary<int, Node> Cache = new Dictionary<int, Node>();
    
    // Наши невидимые заглушки
    public Node Head = new Node(0, 0);
    public Node Tail = new Node(0, 0);

    public LRUCache(int capacity) 
    {
        this.Capacity = capacity;
        
        // Связываем заглушки между собой
        Head.Next = Tail;
        Tail.Prev = Head;
    }

    public int Get(int key) 
    {
        // Проверяем, есть ли ключ в словаре
        if (Cache.ContainsKey(key) == false) 
        {
            return -1; 
        }

        // Если есть — достаем узел
        Node node = Cache[key];
        
        // Омолаживаем его: вырезаем и кидаем в начало
        RemoveNode(node);       
        InsertToHead(node); 

        return node.Value;
    }

    public void Put(int key, int value) 
    {
        // Если такой ключ уже был — удаляем старую версию узла
        if (Cache.ContainsKey(key)) 
        {
            RemoveNode(Cache[key]);
        }

        // Создаем новый узел и добавляем его в словарь и в голову списка
        Node newNode = new Node(key, value);
        Cache[key] = newNode;
        InsertToHead(newNode);

        // Если кэш переполнился
        if (Cache.Count > Capacity) 
        {
            // Самый старый узел — тот, что прямо перед хвостом
            Node oldestNode = Tail.Prev;
            
            RemoveNode(oldestNode);       // Удаляем из списка
            Cache.Remove(oldestNode.Key); // Удаляем из словаря
        }
    }

    // Понятное вырезание узла
    public void RemoveNode(Node node) 
    {
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
    }

    // Понятная вставка узла в самое начало (после Head)
    public void InsertToHead(Node node) 
    {
        Node currentFirst = Head.Next;

        Head.Next = node;
        node.Prev = Head;
        
        node.Next = currentFirst;
        currentFirst.Prev = node;
    }
}
