#!/usr/bin/env python
# coding: utf-8

# In[6]:


"""
Rotate

Implement rotateArr(arr, shiftBy) that accepts array and offset. Shift arr’s values to the right by that amount. 
‘Wrap-around’ any values that shift off array’s end to the other side, so that no data is lost. 
Operate in-place: given ([1,2,3],1), change the array to [3,1,2]. Don’t use built-in functions.
Second: allow negative shiftBy (shift L, not R).
Third: minimize memory usage. With no new array, handle arrays/shiftBys in the millions.
Fourth: minimize the touches of each element.
"""

def rotate(arr, k):
    temp = arr[0]
    for i in range(k-1):        
        arr[i] = arr[i + 1]
    arr[-1] = temp
    return arr
print(rotate([1,2,3,4,5,6,7,8], 3))
    


# In[13]:


"""
Filter Range

Alan is good at breaking secret codes. 
One method is to eliminate values that lie within a specific known range. 
Given arr and values min and max, retain only the array values between min and max. 
Work in-place: return the array you are given, with values in original order. 
No built-in array functions.
"""

def filters(arr, minimum, maximum):
    return [x for x in arr if x >= minimum and x <= maximum]
            
print(filters([1,2,3,4,5,6,7,8], 2, 5))
               


# In[7]:


"""
Concat

Create a standalone function that accepts two arrays. 
Return a new array containing the first array’s elements, 
followed by the second array’s elements. Do not alter the original arrays. 
Ex.: arrConcat( ['a','b'], [1,2] ) should return new array ['a','b',1,2].
"""

def concat(arr, arr_two):
    return arr + arr_two
print(concat([1,2],[3,4]))


# In[ ]:




