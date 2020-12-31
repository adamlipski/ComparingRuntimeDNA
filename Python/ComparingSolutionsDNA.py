# -*- coding: utf-8 -*-
"""
Created on Thu Dec 31 01:19:01 2020
Based on code from https://towardsdatascience.com/how-fast-is-c-compared-to-python-978f18f474c7")
Articel by Naser Tamimi

"""
import time

def convert(c):
    if (c == 'A'): return 'C'
    if (c == 'C'): return 'G'
    if (c == 'G'): return 'T'
    if (c == 'T'): return 'A'

print("Based on code from https://towardsdatascience.com/how-fast-is-c-compared-to-python-978f18f474c7")
print("Articel by Naser Tamimi")

startTimer = time.time();

print("Start")

opt = "ACGT"
s = ""
s_last = ""
len_str = 15

for i in range(len_str):
    s += opt[0]

for i in range(len_str):
    s_last += opt[-1]

"""pos = 0"""
counter = 1
while (s != s_last):
    counter += 1
    # You can uncomment the next line to see all k-mers.
    # print(s)
    change_next = True
    for i in range(len_str):
        if (change_next):
            if (s[i] == opt[-1]):
                s = s[:i] + convert(s[i]) + s[i+1:]
                change_next = True
            else:
                s = s[:i] + convert(s[i]) + s[i+1:]
                break

# You can uncomment the next line to see all k-mers.
# print(s)
print("Time elapsed: ", time.time() - startTimer, " seconds")
print("Number of generated k-mers: {}".format(counter))
print("Finish!")