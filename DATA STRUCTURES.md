# Data Structures and Algorithms

* [Data Structures](#data-structures)
* [Abstract Data Type](#abstract-data-type)
    * [Array](#array)
    * [Matriz](#matriz)    
    * [List](#list)
    * [Stack](#stack)
    * [Queue](#queue)
    * [Simple Linked List](#simple-linked-list)
    * [Double Linked List](#double-linked-list)
    * [Multi Linked List](#multi-linked-list)
    * [Circular Linked List](#circular-linked-list)    
    * [Hash Table](#hash-table)
    * [Tree](#tree)
    * [Binary Search Tree](#binary-search-tree)

* [Array Sorting Algorithm](#what-is-an-algorithm?)
    * [Bubble Sort](#bubble-sort)
    * [Insertion Sort](#insertion-sort)
    * [Merge Sort](#merge-sort)
    * [Quick Sort](#quick-sort)

## What is Data Structure?
- It's a way of organizing and storing data in a computer so that it can be accessed and modified.
- It's a collection of data values, the relationships among them, and the functions or operations that can be applied to the data.

## Abstract Data Types (ADT)
- Define data and operations, but no implementations.

## Array
- It's a linear and unidimensional structure.
- Consider the simplest one.
- You can acess the data using a key or index.

## Matriz
- They are similar to arrays.
- They can be n dimensional (bi-dimensional, tri-dimensional)

## List
- Its the abstract data type.
- They usually stores the same type of data. (Objects for example).

## Stack
- They are LIFO (Last in, First Out)
- It's one of the implementations of List.
- All the operations are on the TOP.
- Operations (TOP, PUSH, POP, PULL)

## Queue
- They are FIFO (First In, First Out)
- Operations (Enqueue, Dequeue)

## Simple Linked List
- They are linear and dinamic.
- They are compost for nodes.
- Each node has a link to the NEXT node.

## Double Linked List
- They are linear and dinamic.
- They are compost for nodes.
- Each node has a link to the PREVIUS and NEXT node.

## Multi Linked List
- They are linear and dinamic.
- They are compost for nodes.
- Each node has a link to the PREVIUS and NEXT node and more one configured link (Can be another order).

## Circular Linked List
- They are linear and dinamic.
- They are compost for nodes.
- The last node has a link for the first.

## Hash Table
- Each item has a hash or key.
- It increse the performance of search by only one comparasion.
- It's very used in computer science.

## Tree
- They are an abstract data type.
- The simulate a hierarchical tree structure.
- They have root, parent, child, siblings.

## Binary Search Tree
- It's a very used data structure.
- TODO

# What is an Algorithm?
- Used as a tool for mathematical computation.
- Algorithms are deeply connected with computer science, and with datastructures in particular. 
- An algorithm is a sequence of instructions that accomplishes a task in a finite period of time. 

## Bubble Sort
- It's a simple sorting algorithm.
- Compare a pair of adjacent items and swich them if wrong order.

## Insertion Sort
- It's a simple sorting algorithm.
- It's less eficient.
- It order item by item, putting in the correct position.

## Merge Sort
- Sorting technique based on divide and conquer.
- Divides the array into equals parts and then combine them in a sorted manner.

## Quick Sort
- It's an efficient sorting algorithm.
- Steps:
    1) Pick an element, called pivot.
    2) The elements less then pivot goes to the left side.
    3) The elements bigger then pivot goes to the right side.
    4) Works recursively in most of cases.