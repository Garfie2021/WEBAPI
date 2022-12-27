## WindowsForm/Src_Static/
Even if a method is declared static, variables declared within the method are not shared among multiple threads, and static member variables of the class are shared.

Variables declared inside a static method are not shared between multiple threads, just like variables declared inside a while loop cannot be used outside of the variable scope specification.

From this, we can see that it is safe to use static methods that are executed in stack memory in multithreaded applications.

[Source code explanation page](https://blog.unikktle.com/c%e3%83%9e%e3%83%ab%e3%83%81%e3%82%b9%e3%83%ac%e3%83%83%e3%83%89%e3%81%ab%e3%81%8a%e3%81%91%e3%82%8bstatic%e5%a4%89%e6%95%b0%e3%81%ae%e3%82%b9%e3%82%b3%e3%83%bc%e3%83%97/)

---

## WindowsForm/Src_Stub/
How to make a stub.
When developing an application that operates a third-party product that costs tens of millions of yen or more, the work environment is limited, such as being able to connect to the third-party product only locally, and not being able to connect to the third-party product from the local PC where the development work is performed. , it often happens that the debugging process does not proceed as expected.
In that case, by creating a Stub that matches the I/F specifications of the other company's product and using the Stub to proceed with debugging and testing on the local PC where the development work is performed, the speed and accuracy of the development work can be increased and The problem can only be a defect on the side of the other company's product.

If you pick up only the public methods from the I/F library (DLL) for operating the other company's product, which is provided as a set with the other company's product, and create a Stub that implements only the I/F side. , you can proceed with debugging and testing even locally where you cannot connect to other companies' products.

I/F libraries for connecting to other companies' products costing tens of millions of yen or more are often provided as DLLs.

It's not a mock (Moq), it's a stub.
There are too many people who can't tell the difference between a mock and a stub, and say, "That's a mock, right?" when talking about creating a stub.

I made it based on .Net Core, but it will be the same implementation in .Net Framework.

[Source code explanation page](https://blog.unikktle.com/%e3%82%b9%e3%82%bf%e3%83%96%ef%bc%88stub%ef%bc%89%e3%81%ae%e4%bd%9c%e3%82%8a%e6%96%b9/)

---

## WindowsForm/Src_Stub_v2/
The application implemented in [How to create a stub](https://blog.unikktle.com/%e3%82%b9%e3%82%bf%e3%83%96%ef%bc%88stub%ef%bc%89%e3%81%ae%e4%bd%9c%e3%82%8a%e6%96%b9/) has a fixed return value of the stub, and every time I changed the return value and tested it, I had to modify the source code and build again.
This time, we have added a separate application (stub controller) that can dynamically change the return value of the stub even while the main application is running, allowing for more flexible testing.

From Visual Studio 2022 + .NET 6.0, it is now possible to develop Windows Forms applications like .Net Framework.
Visual Studio 2022 is not quite stable, and recently, I have finally implemented a Windows Forms app with Visual Studio 2022 + .NET 6.0, and am no longer annoyed by strange movements.
In the development of Windows Forms apps in Visual Studio 2019 + .NET 5.0, the Binding of DataGridView was incomplete and unusable, but in Visual sStudio 2022 + .NET 6.0, Visual Studio 2019 + .Net Framwork 4.8. About 1 environment, you can implement a Windows Forms application crisply.

[Source code explanation page](https://blog.unikktle.com/%e3%82%b9%e3%82%bf%e3%83%96%ef%bc%88stub%ef%bc%89%e3%81%ae%e4%bd%9c%e3%82%8a%e6%96%b9-v2/)

---

