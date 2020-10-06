﻿using LearningClasses;

    class Program
    {
  
static void Main2342()
    {
        var person1 = new Person("Ramesh", "Bhaktapur", 23);
        var person2 = new Person("Ram", "Bhaktapur", 20);
        var person3 = new Person("Ram", "Bhaktapur", 40);

        var person4 = new Person();

//Static members accessing
       var x = Person.ScientificName;
       Person.Do();
       var y = Math.sqrt(122);

        var s1 = Calculator.Sum<int>(23, 34);
        var s2 = Calculator.Sum<decimal>(2377.1m, 34143.2m);


    }
