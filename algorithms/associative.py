#!/usr/bin/env python
# coding: utf-8

# In[1]:


"""
Remove Blanks

Create a function that, given a string, returns all of that string’s contents, but without blanks. 
If given the string " Pl ayTha tF u nkyM usi c ", return "PlayThatFunkyMusic".
"""

def space(string):
    return string.replace(" ", "")
print(space("Pl ayTha tF u nkyM usi c"))


# In[4]:


"""
Get Digits

Given a string, return the integer made from the string’s digits. 
Given "0s1a3y5w7h9a2t4?6!8?0", should return the number 1357924680.
"""

def digits(string):
    result = ''
    for i in range(len(string)):
        if string[i].isdigit():
            result += string[i]
    return int(result)
print(digits("0s1a3y5w7h9a2t4?6!8?0"))
            
        


# In[18]:


"""
Acronyms
Given a string, returns the string’s acronym (first letters only, capitalized). 
Given " there's no free lunch - gotta pay yer way. ", return "TNFL-GPYW". 
Given "Live from New York, it's Saturday Night!", return "LFNYISN".
"""

def acro(string):
    result = ''
    not_first = True
    
    for i in range(len(string)):
        if string[i] == ' ':
            not_first = True
        elif string[i] != ' ' and not_first == True:
            result += string[i]
            not_first = False
    return result.upper()
print(acro("live from new york, it's saturday night"))


# In[9]:


"""
Count Non-Spaces

Given a string, return the number of non-space characters found in the string. 
For example, given "Honey pie, you are driving me crazy", return 29 (not 35).
"""

def space(string):
    result = 0
    for i in range(len(string)):
        if not string[i].isspace():
            result += 1
    return result
print(space("Honey pie, you are driving me crazy"))


# In[15]:


"""
Remove Shorter Strings
Given a string array and value (length), remove any strings shorter than the length from the array.
"""

def short(value, arr):
    i = 0
    while i < len(arr):
        if len(arr[i]) < value:
            arr.remove(arr[i])
        i += 1
    return arr
print(short(10, ["don't remove me please", "why would you do this", "as if", "It wasn't me", "Holy diver"]))


# In[ ]:




