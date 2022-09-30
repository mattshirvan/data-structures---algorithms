#!/usr/bin/env python
# coding: utf-8

# In[20]:


class Node():
    def __init__(self, data):
        self.data = data
        self.next = None

class LinkedList():
    def __init__(self):
        self.head = None
        self.count = 0
        
    def append(self, value):        
        if not self.head:
            self.head = Node(value)                
            self.count += 1
            return
        
        runner = self.head
        while runner.next:
            runner = runner.next
        runner.next = Node(value)
        self.count += 1
            
    def prepend(self, value):
        if not self.head:
            self.head = Node(value)
            self.count += 1
            return 
        
        temp = self.head
        self.head = Node(value)
        self.next = temp
            
    def prints(self):
        runner = self.head
        while runner:
            print(runner.data, end="=>")
            runner = runner.next
                


# In[21]:


new = LinkedList()
new.append(1)
new.append(2)
new.append(3)
new.append(4)
new.append(5)
new.append(6)
new.append(7)
new.append(8)
new.prints()


# In[35]:


def concat(node1, node2):
    runner = node2.head
    while runner:
        node1.append(runner.data)
        runner = runner.next
    return node1
        
def negatives(node1, node2):
    runner = node2.head
    while runner:
        if runner.data > 0:
            node1.append(runner.data)
        runner = runner.next
    return node1
        
new1 = LinkedList()
new2 = LinkedList()
new1.append(1)
new1.append(2)
new1.append(3)
new1.append(4)
new2.append(5)
new2.append(6)
new2.append(7)
new2.append(8)
show = concat(new1, new2)
show.prints()
show2 = negatives(new1, new2)
show2.prints()


# In[39]:


def splits(node, n):
    temp = LinkedList()
    runner = node.head
    while runner:
        if runner.data == n:
            tmp = runner.data
            temp.append(tmp)
            runner.data = None
        runner = runner.next
    return temp

nodes = LinkedList()
nodes.append(1)
nodes.append(3)
nodes.append(5)
nodes.append(2)
nodes.append(4)
nodes.prints()
show = splits(nodes, 5)
nodes.prints()
print()
show.prints()


# In[ ]:




