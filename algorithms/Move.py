#!/usr/bin/env python
# coding: utf-8

# In[8]:


"""
Single Linked List to do 2
"""

class Node():
    def __init__(self, value):
        self.value = value
        self.next = None
        
class LinkedList():
    def __init__(self):
        self.head = None
        self.count = 0 
        
    def prepend(self, value):
        if not self.head:
            self.head = Node(value)
            self.count += 1
        else:
            temp = self.head
            self.head = Node(value)
            self.next = temp
            self.count += 1
            
    def append(self, value):
        if not self.head:
            self.head = Node(value)
            self.count += 1
        else:
            runner = self.head
            while runner:
                if not runner.next:
                    runner.next = Node(value)
                    self.count += 1
                    return
                runner = runner.next
    
    def show(self):
        runner = self.head
        while runner:
            print(runner.value, end='->')
            if not runner.next:
                return
            runner = runner.next
            
            
    
new = LinkedList()
new.append(1)
new.append(2)
new.append(3)
new.append(4)
new.append(5)
new.append(6)
new.append(7)
new.append(8)
new.show()


# In[27]:


def mini(node):
    runner = node.head
    mini = node.head
    while runner:
        print(runner.value)
        if not runner.next:
            node.prepend(mini.value)
            return mini.value
        if mini.value > runner.value:
            mini = runner.value
        runner = runner.next
            
print(mini(new))


# In[13]:


def maxi(node):
    runner = node.head
    while runner:
        if not runner.next:
            node.append(runner.value)
            return runner.value
        if runner.value < runner.next.value:
            runner = runner.next
print(maxi(new))


# In[ ]:




