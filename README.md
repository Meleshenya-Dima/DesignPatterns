## _DesignPatterns_
Design Patterns in C#

Before I start, I will say that I tried to talk about design patterns as broadly as possible. Examples can be found in the project. 
Okey, let's go!
# Factory Method
#### What is it?
First Pattern in this article is Factory method. Factory method - generating patterns. What i mean? I mean, it's a pattern which abstract the process of generating classes and objects. I hope you have understood this. In other words, simplifying the further maintenance of the project and its improvement. 
_Factory method defines the interface where the object creation method is located, but the object itself is not defined. The definition, of which object to create is assigned to the classes that implement the interface._ This is my definition, but it fully describes the operation of this pattern.
This can be understood as follows: You were told to do the task, but the task itself is not definite.
#### When to use this pattern?
Try to use this patter when:
- The class does not know what objects it will have to create;
- The work of the program should be independent of the creation of objects; 
- The creation of objects needs to be delegated somewhere.

I hope this is clear. Let's move on.

# Strategy
#### What is it?
Pattern strategy. Strategy - patterns of behavior. Patterns of behavior - design patterns that define algorithms and ways to implement the interaction of various objects and classes. From these two definitions, it can be concluded that the strategy pattern solves problems with the degree of connectivity of the system. For many, this is not a problem at all, but in this case one object would have to store a huge number of references to other objects. Unpleasant, isn't it? And now to the definition this pattern:
_A design pattern that defines a set of algorithms, encapsulates each of them and ensures their interchangeability._
This can be understood as follows: Instead of shooting, the main character decided to fight with a knife. In this case, two methods were defined: shooting and fighting with a knife, and with the help of the strategy pattern, we easily and without compulsion change the two methods in places.
#### When to use this pattern?
Try to use this patter when:
- The behavior of objects needs to be changed while the program is running.
- To reduce the number of classes. If you have many classes that are similar to each other, then highlighting the main and secondary classes, as well as using this pattern, can make it easier to write code.
- You need to change the behavior of each instance of the class.

A little more is written, but I'm sure everything is clear.
# Observer
#### What is it?
Pattern Observer. Observer - pattern of behavioral. The pattern is of the same type as Strategy, so we will not dwell on this and go straight to the definition.
Definitio: _The meaning of this pattern is that it shows a one-to-many relationship. There is an observable object, and there are observers._ It's not difficult, is it? 
Imagine how 5 people are watching a giraffe and when the giraffe moves around the room, the crowd is surprised. The same thing.
#### When to use this pattern?
Try to use this patter when:
- it is necessary to observe the objects so that they are in a consistent state;
- the process of the program may change.

# Adapter
#### What is it?
Pattern Adapter. Adapter - structural design pattern. This type of pattern involves the creation of a larger structure of objects and classes. Let's move on to the definition:
_Pattern adapter designed to transform the interface of one class into the interface of another._
This definition can be interpreted in different ways, for example, as organizing the use of functions of an object that is not available for modification through a specially created interface. In my example, I used the above definition and made a car out of an animal.
This can be understood as follows: Combining two classes with different interfaces under one common class. I hope you understand the essence.
#### When to use this pattern?
Try to use this patter when:
- There is a need to use a ready-made class, but its interface does not fit the requirements.
- There are two classes and more classes and there should be interaction between them.

Lets go to the next point, Fluent Builder.
# Fluent Builder
#### What is it?
Pattern Fluent Builder. This pattern refers to additional patterns, which means at what point you will use them does not depend on anything. I wrote this particular pattern because it 'explicitly' shows the creation and filling of object fields.
Previously, it made a lot of sense because of the overload of constructors, but now it is rather a visible filling with the values of the class object. Therefore, there will be no reason to use it.

# Singleton
#### What is it?
#### When to use this pattern?
