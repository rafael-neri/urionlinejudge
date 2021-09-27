#!/usr/bin/env python3
# -*- coding: utf-8 -*-

"""
Fatorial Simples
"""

def fatorial(num):
    return num * fatorial(num -1) if num > 1 else 1
        
    
print(fatorial(int(input())))
