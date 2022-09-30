#!/usr/bin/env python
# coding: utf-8

# In[20]:


"""
Back/Remove/Add
"""

class Node():
    def __init__(self, value):
        self.value = value
        self.next = None
    
class LinkedList():
    def __init__(self):
        self.head = None
        self.tail = None
        
    def prepend(self, value):
        if not self.head:
            self.head = Node(value = value)
        else:
            temp = self.head
            self.head = Node(value = value)
            self.head.next = temp
    
    def append(self, value):
        if not self.tail:
            self.tail = Node(value = value)
            self.next = None
        elif self.tail: 
            self.tail = self.tail
            self.tail.next = Node(value = value)
            self.next = None
    def pop(self):
        if self.tail:
            del self.tail
        return self
    
    def prints(self):
        runner = self.head
        while runner:
            print(runner.value, end='->')
            runner = runner.next
            
            
link = LinkedList()
link.prepend(1)
link.append(2)
link.append(3)
link.append(4)
link.append(5)
link.append(6)
link.append(7)
link.prepend(8)

link.prints()


# In[ ]:





# In[ ]:




