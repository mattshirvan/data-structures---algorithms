#!/usr/bin/env python
# coding: utf-8

# In[10]:


"""
Min to Front

Given an array of comparable values, move the lowest element to array’s front, 
shifting backward any elements previously ahead of it. 
Do not otherwise change the array’s order. Given [4,2,1,3,5], change it to [1,4,2,3,5] and return it. 
As always, do this without using built-in functions.
"""

def front(arr):
    minimum = arr[0]
    for i in range(len(arr)):
        if arr[i] < minimum:
            minimum = arr[i]
    j = 1
    
    for i in range(arr[arr.index(minimum)]):
        tmp = arr[j]
        arr[j] = arr[i]
        j += 1
        i += 2
        arr[i] = tmp
    arr[0] = minimum
    return arr
print(front([4,2,1,3,5]))


# In[ ]:





# In[ ]:




