#!/usr/bin/env python
# coding: utf-8

# In[1]:


class Node():
    def __init__(self, value):
        self.value = value
        self.next = None
        
class Queue():
    def __init__(self):
        self.head = self.tail = None
        self.count = 0
        
    def enqueue(self, value):
        node = Node(value)
        if not self.tail:
            self.head = self.tail = node
            self.count += 1
            return
        self.tail.next = node
        self.tail = node
        self.count += 1
            
    def dequeue(self):
        if self.empty():
            return
        temp = self.head
        self.head = temp.next
        self.count -= 1
        if not self.head:
            self.tail = None
        return temp.value    
        
    def front(self):
        return self.head.value
    
    def empty(self):        
        return self.head == None
    
    def size(self):
        return self.count
    
    def prints(self):
        runner = self.head
        while runner:
            print(f'|{runner.value}|')
            runner = runner.next
    
q = Queue()
q.enqueue(1)
q.enqueue(2)
q.enqueue(3)
q.enqueue(4)
print(q.front())
print(q.size())
print(q.dequeue())
print(q.front())
print(q.size())
q.prints()


# In[2]:


def evens(node1, node2):
    return node1.size() == node2.size()
    
q1 = Queue()
q2 = Queue()
q1.enqueue(1)
q1.enqueue(2)
q1.enqueue(3)
q1.enqueue(4)
q2.enqueue(1)
q2.enqueue(2)
q2.enqueue(3)
q2.enqueue(4)
print(evens(q1, q2))


# In[3]:


def contains(node, n):
    runner = node.head
    while runner:
        if runner.value == n:
            return True
        runner = runner.next
    return False

q1 = Queue()

q1.enqueue(1)
q1.enqueue(2)
q1.enqueue(3)
q1.enqueue(4)
print(contains(q1, 3))


# In[4]:


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

q1 = Queue()

q1.enqueue(1)
q1.enqueue(2)
q1.enqueue(3)
q1.enqueue(4)
q1.enqueue(-44)
q1.enqueue(-14)
q1.enqueue(-24)
q1.enqueue(4)
q1.prints()
mini = mini(q1)
mini.prints()


# In[18]:


def interleave(node):
    # dequeue then push first half to stack
    stack = []
    half = node.size() // 2
    
    for i in range(half):
        stack.append(node.dequeue())
        
    # pop from stack and enqueue
    for i in range(len(stack)):
        node.enqueue(stack.pop())
    
    # dequeue first half and enqueue
    for i in range(half):
        node.enqueue(node.dequeue())
        
    # dequeue then push first half to stack    
    for i in range(half):
        stack.append(node.dequeue())
        
    # pop from stack and enqueue
    for i in range(len(stack)):
        node.enqueue(stack.pop())
        
    # interleave queue and stack 
    for i in range(half):
        if len(stack) > 0:
            # pop then enqueue
            node.enqueue(stack.pop())
            
            # dequeue and enqueue
            node.enqueue(node.dequeue())
    return node
    
q = Queue()
for i in range(6):
    if i > 0:
        q.enqueue(i)

new = interleave(q)
new.prints()


# In[ ]:




