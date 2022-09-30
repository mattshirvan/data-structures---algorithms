#!/usr/bin/env python
# coding: utf-8

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
            
        def pop(self, value):
            if self.empty():
                return
            temp = self.top
            self.top = temp.next
            self.count -= 1
            if not self.top:
                self.bottom = None
                
        def empty(self):
            return self.top == None
        
        def contains(self):            
            runner = self.top
            while runner:
                if runner.value == value:
                    return True
                runner = runner.next
            return False
            
        def size(self):
            return self.count
        
        def prints(self):
            runner = self.top
            while runner:
                print(f'|{runner.value}|')
                runner = runner.next
        


# In[ ]:




