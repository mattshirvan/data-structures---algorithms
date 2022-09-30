#!/usr/bin/env python
# coding: utf-8

# In[21]:


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
                
    def peep(self):
        runner = self.head
        while runner:
            print(runner.value, end='->')
            runner = runner.next
            
    def length(self):
        runner = self.head
        count = 0
        while runner:
            runner = runner.next
            count += 1
        return count
    
new = LinkedList()
new.add(5)
new.add(6)
new.add(7)
new.add(8)
new.add(9)

def maxi(node):
    maximum = node.head
    while maximum:
        if maximum.next.value > maximum.value:
            maximum = maximum.next
        else:
            return maximum.value
        
print(maxi(new))


# In[71]:


def mini(node):
    runner = node.head
    
    while runner:
        if runner.value > runner.next.value:
            runner = runner.next
            
        if not runner.next: 
            return runner.value
        
print(mini(new))


# In[77]:


def average(node):
    runner = node.head
    total = 0
    while runner:
        total += runner.value
        runner = runner.next
        if not runner.next:
            return total // node.length()
print(average(new))


# In[ ]:




