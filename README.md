# 003_ThreadsExample
## Example of Using Threads in C#

This project is an example of a simple multithreaded program in C#, using the `System.Threading` library.

## Code Description

### `ThreadClass`

`ThreadClass` is an inner class that defines methods for working with threads.

#### `WriteChar(char ch, int count, ConsoleColor color)`

The `WriteChar` method prints the character `ch` the specified number of times (`count`) with the specified color (`color`) to the console. The output is done using a thread delay (`Thread.Sleep(20)`), creating a step-by-step output effect.

#### `Method2()`

The `Method2` method is an example of working with threads. It displays information about starting the secondary thread, calls the `WriteChar` method to print the character '2', and creates and starts a third thread by calling the `Method3` method.

#### `Method3()`

The `Method3` method displays information about starting the third thread and calls the `WriteChar` method to print the character '3'.

## Main Code

In the main code of the project, methods of the `ThreadClass` class are called to demonstrate working with threads.

### Main Thread

Information about starting the main thread is displayed, the `WriteChar` method is called to print the character '1', and a secondary thread is created and started by calling the `Method2` method. The main thread waits for the secondary thread to complete using the `Join` method, after which it prints the character '1' and information about the main thread's completion.
