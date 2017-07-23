
# Some basic review of the language

* [Value Types](#value-types)
    * [Struct](#struct)
* [Reference Types](#reference-types)
* [Stack memory](#stack-memory)
* [Heap memory](#heap-memory)
* [Boxing](#boxing)
* [Unboxing](#unboxing)
* [Garbage Collection](#garbage-collection)
* [Joins](#joins)
    * [Inner Join](#inner-join)
    * [Left Join](#left-join)
    * [Right Join](#right-join)
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
- It's an area of memory to store value types.
- It's cleaned when the scope of the value type declared ends.
- TODO - Explain more???

## Heap memory
- It's an area of memory to store reference types.
- It's cleaned when Garbage Collections identity that it's no longer needed.
- TODO - Explain more???

## Boxing
- It's when a value type is converted into a reference type.
- TODO: What are the problems???

## Unboxing
- It's when a reference type is converted into a value type.
- TODO: What are the problems???

## Garbage Collection

## Joins

## Index