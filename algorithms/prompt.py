#!/usr/bin/env python
# coding: utf-8

# In[15]:


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
        else:
            runner = self.head
            while runner.next:
                runner = runner.next
            runner.next = Node(value)
    def show(self):
        runner = self.head
        while runner:
            print(runner.value, end='->')
            runner = runner.next
    


# In[16]:


def prompt(node):
    while True:
        data = input("Enter your data: ")
        if data.lower() == "cancel":
            return node
        node.append(data)
        print("Data added!")
        
    
new = LinkedList()
prompt(new)
new.show()


# In[ ]:




