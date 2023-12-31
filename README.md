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
![UsingBridge](https://github.com/YuktaS14/Bridge-Design-Pattern/assets/85993659/ffcf275f-a156-4c1c-91c0-0c065c69497b)



### Using Bridge Pattern
![Bridge](https://github.com/YuktaS14/Bridge-Design-Pattern/assets/85993659/4e00c508-9604-44c1-b769-c0b9be955183)


### Class Diagram 
![WhatsApp Image 2023-09-17 at 15 51 44](https://github.com/YuktaS14/Bridge-Design-Pattern/assets/85993659/d833aa46-0c89-48b7-8f42-cc4d6b0b97fc)




### Environment
The project builds and runs with Visual Studio Community 2022 when the required workloads are installed.
