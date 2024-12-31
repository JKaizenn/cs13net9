# Chapter 03 Notes:
#### Controlling Flow, Converting Types, and Handling Exceptions:


### Operating on Variables
Operators apply simple operations such as addition and multiplication to operands such as variables and literal values.

- Most operators are binary, meaning they work on two operands.
- Examples of binary operators:
  ```
  int x = 5;
  int y = 3;
  int resultofAdding = x+y;
  int resultOfMultiplying = x * y;
  ```

# Exercise 3.3 - Test Your Knowledge

1. **What happens when you divide an `int` variable by 0?**

   When you divide an `int` by 0, it throws a `System.DivideByZeroException` at runtime. This is a runtime error that must be handled with appropriate exception handling.

2. **What happens when you divide a `double` variable by 0?**

   When dividing a `double` by 0, the result depends on the numerator:
   * Positive number divided by 0 returns `Infinity`
   * Negative number divided by 0 returns `-Infinity`
   * Zero divided by 0 returns `NaN` (Not a Number)

3. **What happens when you overflow an `int` variable, that is, set it to a value beyond its range?**

   By default, integer overflow in C# wraps around using two's complement representation (e.g., `int.MaxValue + 1` becomes `int.MinValue`). However, if the code is running in a `checked` context, it will throw an `OverflowException`.

4. **What is the difference between `x = y++;` and `x = ++y;`?**

   * `x = y++;` (post-increment): First assigns the current value of `y` to `x`, then increments `y`
   * `x = ++y;` (pre-increment): First increments `y`, then assigns the new value of `y` to `x`

5. **What is the difference between `break`, `continue`, and `return` when used inside a loop statement?**

   * `break`: Exits only the current loop
   * `continue`: Skips the remaining code in the current iteration and moves to the next iteration
   * `return`: Exits the entire method, regardless of how many nested loops you're in

6. **What are the three parts of a `for` statement and which of them are required?**

   The three parts are:
   * Initialization (optional)
   * Condition (optional)
   * Iteration/Update (optional)
   
   While all parts are optional, you must keep the semicolons that separate them.

7. **What is the difference between the `=` and `==` operators?**

   * `=` is the assignment operator, used to assign a value to a variable
   * `==` is the equality comparison operator, used to check if two values are equal

8. **Does the following statement compile?**

   ```csharp
   for ( ; ; ) ;
   ```
   Yes, this statement compiles. It creates an infinite loop with an empty body. All three parts of the for loop are omitted but the semicolons are maintained.

9. **What does the underscore (_) represent in a switch expression?**

   The underscore (_) in a switch expression represents the default case - it matches any value that wasn't matched by previous cases. It's similar to the `default:` case in a traditional switch statement.

10. **What interface must an object "implement" to be enumerated over by using the foreach statement?**

    An object must implement the `IEnumerable` or `IEnumerable<T>` interface to be used in a foreach statement. This interface provides the capability to iterate over a collection of items.
