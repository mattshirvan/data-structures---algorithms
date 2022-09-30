#!/usr/bin/env python
# coding: utf-8

# In[1]:


"""
Push Front
"""

def push_front(n, arr):
    new_arr = [None] * (len(arr) + 1)
    new_arr[0] = n
    j = 0
    for i in range(len(new_arr)):
        if not new_arr[i]:
            new_arr[i] = arr[j]
            j += 1
    return new_arr

print(push_front(1, [2,3,4,5,6,7,8]))


# In[4]:


"""
Insert at
"""

def insert_at(n, val, arr):
    new_arr = [None] * (len(arr) + 1)
    new_arr[n] = val
    j = 0
    for i in range(len(new_arr)):
        if new_arr[i] != new_arr[n]:
            new_arr[i] = arr[j]
            j += 1
    return new_arr

print(insert_at(5, "inserted inside you", [2,3,4,5,6,7,8]))


# In[10]:


"""
Remove
"""

def remove(n, arr):
    removed = arr[n]
    arr[n] = None
    arr = [x for x in arr if x]
    return removed

print(remove(4, [-1,3,4,-5,4,7]))


# In[35]:


"""
Swap Pairs
"""

def pairs(arr):
    j = 1
    i = 0
    
    while i < len(arr):
        if len(arr) % 2 == 0:
            tmp = arr[i]
            arr[i] = arr[j]
            arr[j] = tmp
            i += 2
            j += 2
        else:
            if arr[i] == arr[-1]:
                return arr
            else:            
                tmp = arr[i]
                arr[i] = arr[j]
                arr[j] = tmp
                i += 2
                j += 2
        
    return arr
print(pairs([1,2,3,4,5]))


# In[55]:


"""
Remove Duplicates
"""

def duplicates(value, arr, low, high):
    if high >= 1:
        mid = low + ((high - low)//2)

        if arr[mid] == value:
            return arr[mid] 
        if arr[mid] > value:
            return duplicates(value, arr, mid, mid-1)
        else:
            return duplicates(value, arr, mid+1, high)

lst = ['artemis', 'charlie', 'dee', 'dennis', 'frank', 'matt', 'mcpoyle', 'streetrat']
print(duplicates("streetrat", lst, 0, len(lst)-1))


# In[ ]:




