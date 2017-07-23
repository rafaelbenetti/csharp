
# Some basic review of the language

* [Value Types](#value-types)
    * [Struct](#struct)
* [Reference Types](#reference-types)
* [Stack memory](#stack-memory)
* [Heap memory](#heap-memory)
* [Boxing](#boxing)
* [Unboxing](#unboxing)
* [Garbage Collection](#garbage-collection)
* [Dispose](#dispose)
* [Finalize](#finalize)
* [Task](#task)
* [Thread](#thread)
* [Async Await](#async-await)
* [Joins](#joins)
    * [Inner Join](#inner-join)
    * [Left Join](#left-join)
    * [Right Join](#right-join)
    * [Full Join](#full-join)
* [Index](#index)
    * [Clustered Index](#clustered-index)
    * [Nonclustered Index](#nonclustered-index)


## Value Types
- Are stored in an area of memory called stack.
- After the execution of the value type declararion the value is discarded from the stack.
- They are limitated to share data between classes.

### Struct
- Struct is a value type, it means that you can create new value types.
- TODO - When is it good?

```c
 int age = 25;
```

## Reference Types
- String is a reference type.
- They are storead in an area of memory called the heap.
- The heap it's only cleaned when the Garbage collection determines it is no longer needed.

```c
Car car = new Car();
```

## Stack memory
- It's stored on the RAM memory just like the HEAP.
- It's an area of memory to store value types.
- It's cleaned when the scope of the value type declared ends.

## Heap memory
- It's stored on the RAM memory just like the Stack.
- It's an area of memory to store reference types.
- It's cleaned when Garbage Collections identity that it's no longer needed.
- Used to satisfy dynamic memory allocation.

## Boxing
- It's when a value type is converted into a reference type.
- Boxing are expensive processes. When a value type is boxed, a new object must be allocated and constructed.
- In this process a "box" is created in the heap memory to control a value type.
- When a value type is boxed, an entirely new object must be created. This can take up to 20 times longer than an assignment.

## Unboxing
- It's when a reference type is converted into a value type.
- The cast required for unboxing is expensive.
- The cast required for unboxing is dangerous because can throw an InvalidCastException.
- When unboxing, the casting process can take four times more then an assignment.

## Garbage Collection

## Dispose

## Finalize
 - Are they good to use? Because ther are called a long time after the execution?
 - I think it's better use Dispose and maybe use Try Catch Finally to ensure the Dispose.

# Inheritance Class Limitation
- Only one class can inheritance from another.
- Interface can solve this problem.

## Joins
 - It's used to join two structures of data.

### Inner Join
 - Get all data from two structures that have relationship.
 - Both sides must have data.
 
### Left Join
 - Get all data from the LEFT side but the RIGHT side can be NULL.
 - Only LEFT side is required.

### Right Join
 - Get all data from the RIGHT side but the LEFT side can be NULL.
 - Only RIGHT side is required.

### Full Join
 - Get all data from both sides and both can NULL.
 - None of sides are required.

## Index