#!/usr/bin/env python
# coding: utf-8

# In[4]:


"""
Linked Lists Fronts
"""

class Node():
    def __init__(self, value):
        self.value = value
        self.next = None
    
class LinkedList():
    def __init__(self):
        self.head = None
        self.tail = None
        
    def add(self, value):
        if not self.head:
            self.head = Node(value = value)
        else:
            temp = self.head
            self.head = Node(value = value)
            self.head.next = temp
            
    def remove(self):
        temp = self.head.next
        del self.head
        self.head = temp
        
    def show(self):
        if self.head:
            return self.head.value
        else:
            return None
        
    def find(self, value):
        if self.head.value == value:
            return True
        else:
            while self.head.next:
                if self.head.next == value:
                    return True
                else:
                    return False
        
new = LinkedList()
new.add(5)
new.add(6)
new.add(7)
print(new.show())
new.remove()
print(new.show())
new.remove()
print(new.show())
print(new.find(5))


# In[ ]:




