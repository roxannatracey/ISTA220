#### Roxanna Barahona
#### Week 4

#### Chapter 4
- Recursion
 - Recursion is a general problem solving strategy.
 - what is recursion? its a method that calls itself
  - physically and figuratively it, recursion is a deep topic
  - what is a recursive method? a method that calls itself
  - 2 steps to recursion
  -- 1. find/decide the stopping point
  -- 2. decide what to do if you have
- for loop
- 3 components
#### Chapter 7, Chapter 8
- the new keyword goes to the heap and allocates sufficient amount of memory to hold an object of that type and return a memory address to the stack
- how does 'new' know how much memory to allocate? Because it calls the constructor and its the constructor that tells new how much space is needed and what the properties and methods are.
- what is the difference between class and object. A class is abstract while an instance is a concrete materialization of an object of that type
- syntax for a constructor: a construct's class name must match the class and cannot have a return time.
-- Example: PUBLIC CAR();
{
}
- the constructor actually constructs the object on the heap
- fields and properties are variables. you can think of them both doing something. what is an instance field or method? every object of that type you create has an independent copy of that field or method
what is a class field or method? each instance does not have an independent copy but all instances share that one class or method
example: you have a class MATH t

#### Chapter 8
- Variable : name location in the memory
- there are two ways you can pass methods to an argument:
-- 1. by value : a copy is made
-- 2. or by parameter
-- a static method is a class method and you can access(call it) it by calling the name of the class dot name of the method
-- how do you call an instance method? you have to instantiate an instance first then you call it instance dot method name

####SQL CH 7
- a set operator manipulates sets
- grouping sets: are the sets of expressions that you group the data by
- using an OVER clause with empty parentheses exposes a window of all rows from the underlying
query’s result set to the function

1 riddle
and one coding problem

#### More notes for C
-- This is the type of code you would write to connect to a server name
//pseudo code
conn = connect(servername, username, password);
query = makeQuery(...);
runQuery(Query);
result[] = getResult();
// Process the result set
---------------------------------------------------------------------------
 -'N is a unicode
- an interface is an abstraction
- class tells you what something does and how it does it
