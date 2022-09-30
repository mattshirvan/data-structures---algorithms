#!/usr/bin/env python
# coding: utf-8

# In[1]:


class Node():
    def __init__(self, value):
        self.value = value
        self.previous = None
        self.next = None
        
def LinkedList():
    def __init__(self):
        self.head = self.tail = None
        self.count = 0
        
    def push(self, value):
        node = Node(value)
        if not self.head:
            self.head = self.tail = node
            self.count += 1
            return
        temp = self.tail
        self.tail = node
        self.next = None
        self.previous = temp
        self.count += 1
    
    def pop(self):
        if self.empty():
            return
        temp = self.tail
        self.tail = self.previous
        self.count -= 1
        return temp.value
    
    def prepend(self, value):
        node = Node(value)
        if not self.head:
            self.head = self.tail = node
            self.count += 1
            return
        temp = self.head
        self.head = node
        temp.previous = self.head
        self.next = temp
        self.count += 1
    
    def amend(self):
        if self.empty():
            return
        temp = self.head
        self.head = self.next
        self.previous = None
        self.count -= 1
        return temp.value
    
    def front(self):
        return self.head
    
    def back(self):
        return self.tail
    
    def contains(self, value):
        runner = self.head
        while runner:
            if runner.value == value:
                return runner.value == value
            runner = runner.next
        return False
    
    def empty(self):
        return self.head == None
    
    def size(self):
        return self.count


# In[ ]:




