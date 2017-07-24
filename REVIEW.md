
# Some basic review of the language

* [Value Types](#value-types)
    * [Struct](#struct)
* [Reference Types](#reference-types)
* [Equals](#Equals)
* [GetHashCode](#gethashcode)
* [Stack memory](#stack-memory)
* [Heap memory](#heap-memory)
* [Boxing](#boxing)
* [Unboxing](#unboxing)
* [Garbage Collection](#garbage-collection)
* [Dispose](#dispose)
* [Finalize](#finalize)
* [Task](#task)
* [Thread](#thread)
* [Thread Syncronization](#thread-syncronization)
    * [Lock](#lock)
    * [Mutex](#mutex)
* [Async Await](#async-await)
* [Inheritance Class Limitation](#inheritance-class-limitation)
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
- They have a reference to the heap and if assign a reference type to another, the reference will be the same.
- The heap it's only cleaned when the Garbage collection determines it is no longer needed.

```c
Car car = new Car();
```

## Equals
 - For reference types it compares the reference in the HEAP except for String.
 - For value types it compares the value and type.
 - For STRUCT it compares the value and type.

## GetHashCode
 - TODO - Why is it important to override?

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
- Boxing are expensive processes. 
- When a value type is boxed, an entirely new object must be created. 
- Boxing can take up to 20 times longer than an assignment.
- In this process a "box" is created in the heap memory to control a value type.

## Unboxing 
- It's when a reference type is converted into a value type.
- The cast required for unboxing is expensive.
- The cast required for unboxing is dangerous because can throw an InvalidCastException.
- When unboxing, the casting process can take four times more then an assignment.

# Garbage Collection
 - It's responsible for automatic memory management.
 - Allocates and Desalocates memory.
 - Garbage collector is the class and Garbage collection is the process.
 - Garbage collection calls the Finalize method.

 ```c
GC.Collect();
```

### Generation 0
 - This is the youngest generation and contains the newly created objects. 
 - Has short-lived objects and collected frequently.
 - The objects that survive the Generation 0 are promoted to Generation 1.
 - Example : A temporary object.

### Generation 1
 - This generation contains the longer lived objects that are promoted from generation 0. 
 - Basically this generation serves as a buffer between short-lived objects and longest-lived objects. 
 - The objects that survive the Generation 1 are promoted to Generation 2. 

### Generation 2
 - This generation contains the longest lived objects that are promoted from generation 1 and collected infrequently.
 - Example : An object at application level that contains static data which is available for the duration of the process. 

## Garbage Collector Phases

### Marking Phase
 - In this phase garbage collector finds and creates a list of all live objects. 

### Marking Phase
 - In this phase garbage collector updates the references to the objects that will be compacted.

### Compacting Phase
 - In this phase garbage collector reclaims the memory occupied by the dead objects and compacts the surviving objects. The compacting phase moves the surviving objects toward the older end of the memory segment.

## Dispose
 - It's a safety way to manage your own objects such as DataBaseManager for example.
    - You have to implement the IDispose interface.
 - It's cleaned when you use the using statement.
  ```c
   using(var context = new DataContext()) {

   } // In this line Dispose will be called.   
  ```

## Finalize
 - You implement finalize using the ~Destructor.
 - It's good call the Dispose inside your Finalize method.
 - The finalizer method is called when your object is garbage collected and you have no guarantee when this will happen (you can force it, but it will hurt performance).
 - Are they good to use? Because ther are called a long time after the execution?
    - I think it's better use Dispose and maybe use Try Catch Finally to ensure the Dispose.

## Task 
 - It's a promise of a result in the future.
 - Task.Run() really say "I want you to execute this code separately".
 - Tasks returns a Result property but it's blocking, it's better use async/await keywords.

## Thread
 - Is a lower-level concept when you start a new one it will be a separeted thread.
 - Doesn't executes in the thread pool.
 - Each thread you have consumes an amount of memory for its stack.
 - And adds additional CPU overhead as the processor context-switch between threads.
 - Operations: you can Abort() or Suspend() or Resume()

## Thread Syncronization
 - TODO

## Lock
 - TODO

## Mutex
 - TODO
 
## Async Await
 - It's a way of work asynchronously in c#.
 - Must return a Task<T> or be void.
 - Async is used to mark a method as asynchronous.
 - Await keyword is used to say that some operation is running asynchronously without blocking the current thread.

## Inheritance Class Limitation
- Only one class can inheritance from another.
- Executes on the thread pool.
- It's from the Task Parallel Library.
- Interface can solve this problem.

# Database

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
 - TODO

### Clustered Index
 - TODO

### Nonlustered Index
 - TODO
