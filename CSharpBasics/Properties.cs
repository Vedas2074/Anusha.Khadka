class Person11

{
   
     byte age = 23;

    public byte Age
    {
        get
        {
            return age;

        }
        set
        {
            if (value > 20 && value < 30)
            age = value;
        }
    }

    //Autoimplemented property

    public string Name { get; set; }

//Read only property (set garnu nadine)
     public string Address { get;}
}