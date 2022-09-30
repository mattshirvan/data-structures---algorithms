#!/usr/bin/env python
# coding: utf-8

# In[68]:


class Node():
    def __init__(self, value):
        self.value = value
        self.next = None
        
class Stack():
    def __init__(self):
        self.top = self.bottom = None
        self.count = 0
        
    def push(self, value):
        if not self.bottom:
            self.top = self.bottom = Node(value)
            self.count += 1
            return
        temp = self.top
        self.top = Node(value)
        self.top.next = temp
        self.count += 1
    
    def pop(self):
        if self.empty():
            return
        temp = self.top
        self.top = temp.next
        self.count -= 1
        return temp.value         
        
    def size(self):
        return self.count
    
    def prints(self):
        runner = self.top
        while runner:
            print(f'|{runner.value}|')
            runner = runner.next
        
    
    def contains(self, value):
        runner = self.top
        while runner:
            if runner.value == value:
                return runner.value == value
            runner = runner.next
        return "Value not in Stack"
    
    def empty(self):
        return self.top == None
    
    
class Queue(Stack):  
    def __init__(self):
        super().__init__()

    def enqueue(self, value):
        node = Node(value)
        if not self.bottom :
            self.top = self.bottom = node
            self.count += 1
            return 
        self.bottom.next = node
        self.bottom = node
        self.count += 1

    def dequeue(self):
        if self.empty():
            return
        temp = self.top
        self.top = temp.next
        self.count -= 1
        if not self.top:
            self.bottom = None
        return temp.value                         
        


# In[69]:


new = Stack()
new.push(1)
new.push(2)
new.push(3)
new.push(4)
new.push(5)
new.prints()
new.size()


# In[70]:


def copy(stack):
    stack2 = Stack()
    queue = Queue()
    
    while stack.size() > 0:
        stack2.push(stack.pop()) 
    
    while stack2.size() > 0:
        queue.enqueue(stack2.pop())
        
    while queue.size() > 0:
        stack2.push(queue.dequeue())
    return stack2

copy_of = copy(new)
copy_of.prints()


# In[71]:


class Q():
    def __init__(self, stack, stack2):
        self.stack = stack
        self.stack2 = stack2

    def enqueue(self):        
        while self.stack.size() > 0:        
            self.stack2.push(self.stack.pop())
        
    def dequeue(self):
        return self.stack2.pop()
    
    def prints(self):
        runner = self.stack2.top
        while runner:
            print(f'|{runner.value}|')
            runner = runner.next

new = Stack()
new.push(1)
new.push(2)
new.push(3)
new.push(4)
new.push(5)
new2 = Stack()
two_stacks = Q(new, new2)
two_stacks.enqueue()
two_stacks.prints()


# In[72]:


def palindrome(queue):
    copy = queue
    runner = queue.top
    runner2= copy.top
    palin = False
    while runner:
        if runner.value == runner2.value:
            palin = True
        runner = runner.next
        runner2 = runner2.next
    return palin
    
pali = Queue()
pali.enqueue('B')
pali.enqueue('o')
pali.enqueue('B')
p = palindrome(pali)
print(p)


# In[1]:


class Node():
    def __init__(self, value):
        self.value = value
        self.next = None
        
class Stack():
    def __init__(self):
        self.top = self.bottom = None
        self.count = 0
        
    def push(self, value):
        if not self.bottom:
            self.top = self.bottom = Node(value)
            self.count += 1
            return
        temp = self.top 
        self.top = Node(value)
        self.top.next = temp
        self.count += 1
        
    def pop(self):
        if self.empty():
            return
        temp = self.top
        self.top = temp.next
        self.count -= 1
        
    def prints(self):
        runner = self.top
        while runner:
            print(f'|{runner.value}|')
            runner = runner.next
    
    def size(self):
        return self.count
    
    def empty(self):
        return self.top == None
    
    def front(self): 
        return self.top
    
    def back(self):
        return self.bottom
    
    def contains(self, value):
        runner = self.top
        while runner:
            if runner.value == value:
                return runner.value == value
            runner = runner.next
        return False
        
class Deque(Stack):
    def __init__(self):
        super().__init__()
        
    def down(self):
        if self.empty():
            return
        
        temp = self.bottom
        self.bottom = self.next
        self.count -= 1
        
    def bottomup(self, value):
        node = Node(value)
        if not self.bottom:
            self.top = self.bottom = node 
            self.count += 1
            return
        self.bottom.next = node
        self.bottom = node
        self.count += 1


# In[2]:


def mini(node):
    minimum = node.head.value
    runner = node.head
    while runner:
        if runner.value < minimum:
            minimum = runner.value
        runner = runner.next
    new = Queue()
    print(f'Removed minimum: {minimum}')
    current = node.head
    while current:
        if current.value != minimum:
            new.enqueue(current.value)
        current = current.next
    return new


# In[ ]:




