

# Mock Remote Assessment Three

## BIRKBECK (University of London)

## Software Design and Programming - COIY062H7
## Software and Programming III - BUCI056H6

### Duration - Three hours

1. Candidates should attempt **ALL** questions on the paper.
2. The number of marks varies from question to question.
3. You are advised to look through the entire examination paper before getting started to plan your strategy.
4. Simplicity and clarity of expression in your answers is important.
5. You may answer questions using only the `C#` programming language.
6. You should avoid the use of mutable state or mutable collections in your solutions whenever possible.
7. You should use the solution and project files that are provided. 
	Each "text" solution can be provided in a plain text or pdf file within the appropriate question folder.
8. If you have any issues then please raise them in the `Slack` channel.

------

1. **[6 marks]**
   Demonstrate that *named* and *default* arguments can be used with methods. 
   Create a class `Box` that takes two class arguments: a `string` for the `name` and a `double` for `price`.

   Add a method `CostOfTheBox` which has named arguments for `grocery`,(`bool`), `medication` (`bool`), and `taxRate` (`double`). Default `grocery` and `medication` to `false`, and `taxRate` to `0.10`.

   In this scenario, groceries and medications are not taxable. Return the total cost of the item by calculating the appropriate tax. Your code should satisfy the following:

   ```csharp
   var flour = new Box(name="flour", 4); 
   Debug.Assert(flour.CostOfTheBox(grocery=true) == 4);
   var sunscreen = new Box(name="sunscreen", 3);
   Debug.Assert(sunscreen.CostOfTheBox() == 3.3);
   var tv = new Box(name="television", 500);
   Debug.Assert(tv.CostOfTheBox(rate = 0.06) == 530);
   ```

2. **[10 marks]**
   Certain types of online community networks are specialised in holding photos in the cloud. The principle is simple: users upload photos, which all others can view but only friends can download or comment on. What types of design patterns might be employed in this type of scenario? You should justify your answers and provide appropriate examples from this scenario.
	Answer: The proxy pattern
3. **[10 marks]**
   We wish to know if a class is using dynamic or static typing. Write some code utilising the reflection API to solve this problem.

4. **[5 marks]**
   Why is the `new` operator considered by some to be harmful? Use appropriate examples to justify your answer.
	Because it's harder later to change implementation, extend and reuse previously designed components as the entities used are hard-coded and tightly coupled with each other.
	Another reason is because it's harder to test the existing code in isolation or mock certain entities used as they're already decided in the code.
5. **[10 marks]**
   By use of appropriate code examples illustrate how dependency injection can aid the flexibility of your code.

6. **[6 marks]**
   One way to extend a software system is to find a suitable superclass, and to subclass it. You can achieve a similar effect, without extending the class, by copying some of the operations of one class into a new second class and then delegating calls to an enclosed instance of the first class. Both of these extension techniques, however, require that you know at compile time what behaviour you want to add.
   What are the two techniques that we have just described? Indicate clearly “which is which”.
   The first is inheritance and the second is  aggregation.

7. **[20 marks]**
   A refrigerator has a motor, a temperature sensor, a light, and a door. The motor turns on and off primarily as prescribed by the temperature sensor. However, the motor stops when the door is opened. The motor restarts when the door is closed assuming the temperature is too high. The light is turned on when the door is opened and is turned off when the door is closed.

   (a) Identify the classes in the preceding description of a refrigerator, 
   (b) identify the methods for each of your classes, and
   (c) Provide implementations for each class in `C#`.

8. **[20 marks]**
   Implement an inheritance hierarchy for the different types of employees at a company. An abstract base class will represent a generic employee. The three derived classes represent the various types of concrete employees: programmers, managers, and interns. Each class has some fields, a constructor, and a `ToString` method.

   1. Code a class to represent an `Employee`. Include two protected fields: a string for the name and a double for the salary.
   2. Derive a `Programmer` class from `Employee`. A protected double field to store the average overtime worked by the programmer.
   3. Derive a `Manager` class from `Employee`. Add a protected string field to store the name of the manager’s assistant.
   4. Derive an `Intern` class from `Employee`. Add a protected integer field to store the number of months of the internship. Provide a public constructor that sets the name, salary, and internship length.

9. **[13 marks]**
   You are maintaining a system which is impossible to modify (e.g., a bunch of binary files for which you do not have the source code). The system functions perfectly and you do not want to tamper with it. The system accepts several parameters, performs a simulation, and returns an image with a graph illustrating the results of the simulation.

   Your are given the task of designing an extension to the system that preserves the same interface as the original system; the extension superimposes a grid on top of the graph output.

   1. What design pattern should be applied here? The decorator pattern 
   2. Provide a supporting argument for your choice in part (1). As it allows to add additional behaviour to an entity without changing that entity by enclosing that entity in a class (decorator) that implements the same interface
   the original entity implements and adding the additional functionality into the decorator. 
   3. How will you ensure that the SOLID principles are not violated?

------

END OF PAPER