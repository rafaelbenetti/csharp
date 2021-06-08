
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
* [Async Await](#async-await)
* [Inheritance Class Limitation](#inheritance-class-limitation)
* [Why string is immutable](#why-string-is-immutable)
* [StringBuilder](#stringbuilder)
* [Stateful vs Stateless](#stateful-vs-stateless)
* [Joins](#joins)
    * [Inner Join](#inner-join)
    * [Left Join](#left-join)
    * [Right Join](#right-join)
    * [Full Join](#full-join)
* [Index](#index)
    * [Clustered Index](#clustered-index)
    * [Nonclustered Index](#nonclustered-index)
* [References](#references)

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

## Why string is immutable
 - **Security:** parameters are typically represented as String in network connections, database connection urls, usernames/passwords etc. If it were mutable, these parameters could be easily changed.
 - **Synchronization and concurrency:** making String immutable automatically makes them thread safe thereby solving the synchronization issues.
 - **Performance:** strings are reference types and being immutable means that they change only the reference, incresing the performance.
 
 ```c
 string str = "hello";
 string str1 = "hello";
 // Both strings are using the same reference, that is why string is immutable.
 ```

 - When we change the value we are creating a new reference for that object with a new value.
 - All strings are getting from the String Pool.

## StringBuilder
 - StringBuilder is mutable so it can change its values.
 - They are not Thread Safe.
 - They must be used as local variables.
 - They increse performance when you have to manipulate parts of strings in runtime.

## Contructor and types
 - The constructor is used to initialize the object with some default values.
 - Types: default constructor, parameterized constructor, copy constructor, static constructor, private constructor.

 ```c# 
 public class Student
{
	private int rollNumber { get; set; }
	private string fullName { get; set; }         
	
	//default constructor          
	public Student()          
	{
	}          
	
	//parameterized constructor          
	public Student(int rNum, string fName)          
	{              
		this.rollNumber = rNum;              
		this.fullName = fName;          
	}          
	
	//static constructor          
	static Student()          
	{          
	}          
	
	//copy constructor          
	public Student(Student student)          
	{              
		rollNumber = student.rollNumber;              
		fullName = student.fullName;          
	}   
}
 ```

## Namespaces
 - A namespace is a way of organizing classes of the same group or functionality under the same name.
 - Its not mandatory to set a namespace.

 ```c# 
 namespace todoApi.models
{
    class TodoItem
    {
    }
}
 ```

## Static 
- We use the “static” keyword to create a static class, a static method, or static properties
- Static means that we cannot create the instance of that class. That class can be used directly like ClassName.methodName.

```c#
public static class Logger
{
	public static int log(string message)
	{
		Console.WriteLine(message);
	}
}

Logger.log("I am a static method");
```

## Continue vs Break
- continue keyword will skip the current iteration.
- break will stop the loop.

## Access Modifiers
- Public: Can be accessed anywhere without any restriction
- Protected: Access is limited up to the class, which inherits this class.
- Internal: Can be accessed only within the current assembly.
- Private: Cannot be accessed outside of class.

## Anonymous Types
- Anonymous types allow us to create new types without defining them. 

```c#
public void print()
{
	var data = new
	{
			FirstName = "John",
			SurName = "lastname"
	};

	Console.WriteLine("First Name : " + data.FirstName);
}
```

## Exceptions
- Try, catch, finally, and throw. These are the keywords used to handle the exception.

```c#
try
{

}
catch (Exception)
{
	throw;
}
finally
{

}
```

## Stateful vs Stateless
## Stateful
 - The program has a memory that represents the state.
 - Web Forms was Stateful, because it keeps some states of the components.
 - MVC is stateless, but you can manage the state manually using Session, ViewBag, TempData

 ```c
private int _number = 0;

public int AddOne()
{
	_number++;
return _number;
}
 ```

## Stateless
 - The program has NO memory to represents the state.
 - HTTP is statelss because it doesn't keep any state of the data.

 ```c
public int AddOne(int number)
{
	number++;
	return number;
}
 ```

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
 - [Advantages] Provides a way to improve the performance of your Queries.
 - [Advantages] They are one of the best ways to improve performance in a database application.
 - [Advantages] Putting in the columns that are queried together will improve your response time.
 - [Advantages] Increse the performance for JOINs.
 - [Disadvantages] Too many indices may actually decrease performance.
 - [Disadvantages] They decrease performance on inserts, updates, and deletes.
 - You should only create indexes when they are actually needed.

### Clustered Index 
 - A clustered index alters the way that the rows are stored. 
    - With a clustered index the rows are stored physically on the disk in the same order as the index.
 - Every table can have exactly one clustered index.
 - By default Primary Key is clustered.
 - You can have clustered for Primary Key and others nonclustered indexes.
 - You can create a clustered index that covers more than one column. For example: create Index index_name(col1, col2, col.....).

 ```sql
 CREATE CLUSTERED INDEX IX_TABLE_COLUMN
    ON dbo.TABLE (COLUMN);   
 ```

### Nonclustered Index
 - Does not alter the way the rows are stored in the table.
 - There is a second list that has pointers to the physical rows.
 - You can have many non clustered indexes.
    - Although each new index will increase the time it takes to write new records.

 ```sql
 CREATE INDEX IX_TABLE_COLUMN
    ON dbo.TABLE (COLUMN);   
 ```

 ## References 
  - https://tutorials.eu/50-interview-questions-for-your-csharp-interview/
