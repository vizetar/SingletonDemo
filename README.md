# SingletonDemo
This is about one of the Creational Design pattern which is Singleton - Basic Architecture.

Creational design pattern deals with objects creation mechanism, it expalins creation of object in the manner which is suitable to a given situation.
Singleton use when we ensure that only one object of particular class should be instantiated. That single instance will be responsible to coordinate actions across the applications.
client1,client2,client3 -> all want to work with SINGLETON INSTANCE -> this instance work with tasks in application.
Singleton controls concurrent access of resources & ensure only one instance of class created by declaring all constructor of class to be private.
To control singleton access we need to provide a static property that returns single instance to the client objects.
Provide global access by  - declaring all constructor private
 			                    - provide static methods that returns reference to the instance
			                    - that instance stored as a private static variable
                          
Accroding to this dummy project we have Program.cs as,
            Singleton s1 = new Singleton();
            s1.DisplayFunc("This is first msg");
            s1.DisplayFunc("This is Second msg");
            Console.ReadLine(); 
            
 So, with single instance we are able to invoke Displayfunc 2 times but if we have to call same Displayfunc from multiple other classes, then it will be something like,
 
            Singleton s1 = new Singleton();
            s1.DisplayFunc("This is first msg");

            Singleton s2 = new Singleton();
            s2.DisplayFunc("This is Second msg");
            Console.ReadLine();
            
This means whenever we need to call Displayfuc from multiple classes it will end up creating multiple objects. Even though we calling a common method we are ended up creating multiple instances of same singleton class 
so its unnecessary to create new instances of an object for common methods like displayfunc.
So we can avoid it by restricting multiple instance creation. And we can achieve it by , making all constructor private and class as sealed so that it won't be inherited anymore.
Now, we have changed public constructor into private so we are not able to instantiate the class from anywhere. It will give compile time error that class is inaccessible due to its protection level.
So, we need to provide an alternative where we can perform singleton object creation. This is how we can create a single instance of this singleton class,
- create a static get property which return Singleton instance
still it will create multiple objects
- so create one static variable of type Singleton class as null.
and into get property we will create instance only when this static variable is null, so put if condition into get property as,

 private static Singleton instance = null;
        public static Singleton ReturnInstance
        {
            get {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

and now remove that compile time error which still exists because we still have private constructor and still trying to instantiate singleton class in Program.cs

So, now instead of creating new instance of that class, use get property that we created into that class. So, instaed of creating new instance we can achieve same behavior through returninstance property and by this we can ensure that only one instance of the object created across the operations.
Now if we run it finally , we can see only one time constructor will be called for first instance and we got the Displayfuc working from multiple classe & we have successfully achieve this pattern with this demo project.


This will work well if single thread will try to create instance of this class , this verion is not efficient to handle multiple threads as it will run into a raise condition situation.
For multiple threading situation we should use lock property of thread so that while one thread is busy with instance till then other thread will be in queue and wait for the instance to get free.

Thats All.

Thanks

            
            

