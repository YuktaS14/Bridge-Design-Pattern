# Bridge Design Pattern
The Bridge Design Pattern is a structural design pattern that allows developer to separate the abstraction from the implementation.
* Since Abstraction and Implementation are decoupled, it enables both of them to be developed independently.
* We can change the abstraction's implementor at run-time by changing the reference to the implementer in the abstraction.  

In the context of this project, we have implemented bridge design pattern for a case where diverse applications seek to integrate common functionalities such as file sharing and call-making into their user interfaces.

### Elements of the Bridge Design pattern in our example:
* Abstraction: Encapsulates the implementer reference within the 'Feature' class, facilitating a bridge between the abstraction and the implementer.
* Refined Abstraction: Builds upon the abstraction, concealing intricate details from the implementer. For instance, the 'SendFiles' and 'MakeCall' classes serve as refined abstractions for our abstract class, Features.
* Implementer: The 'IApplication' interface defines the contract for implementation classes, ensuring a consistent structure for functionalities.
* Concrete Implementation: These classes execute the functionalities and methods specified by the implementer. In our project, these are the various application, each able to manifest distinct features and actions.


### Without Using Bridge Pattern
![UsingBridge](https://github.com/YuktaS14/BridgeDesignPattern/assets/85993659/fcce92d7-3102-4805-8cd3-ccd7868a5392)


### Using Bridge Pattern
![Bridge](https://github.com/YuktaS14/BridgeDesignPattern/assets/85993659/4619c7e4-deda-4f1f-a530-e4553d3bbc1b)

### Class Diagram 
![ClassDiagram](https://github.com/YuktaS14/BridgeDesignPattern/assets/85993659/0bd1c534-3d91-4fb7-b7d2-d62cdfbf4799)


### Environment
The project builds and runs with Visual Studio Community 2022 when the required workloads are installed.
