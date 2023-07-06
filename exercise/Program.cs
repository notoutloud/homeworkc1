/* //задание 2
    Console.WriteLine("Введите первое число: ");
    int frst = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int scnd = Convert.ToInt32(Console.ReadLine());
    if (frst > scnd) {
        Console.WriteLine("max = " + frst);
    }
    else {
        Console.WriteLine("max = " + scnd);
    } */
    
    //задание 4 
    /*
    Console.WriteLine("Введите первое число: ");
    int frst = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int scnd = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    int thrd = Convert.ToInt32(Console.ReadLine());
    if (frst > scnd && frst > thrd) Console.WriteLine("max = " + frst);
    if (scnd > frst && scnd > thrd) Console.WriteLine("max = " + scnd);
    if (thrd > frst && thrd > scnd) Console.WriteLine("max = " + thrd);
    */
    //задание 6
    /*
    Console.WriteLine("Введите число: ");
    int frst = Convert.ToInt32(Console.ReadLine());
    if (frst % 2 == 0) {
        Console.WriteLine("Число четное");
    }
    else Console.WriteLine("Число нечетное");
    */
    //задание 8
    Console.WriteLine("Введите число: ");
    int frst = Convert.ToInt32(Console.ReadLine());
    int a = 1;
    while (a <= frst) {
        if ( a % 2 == 0) {
            Console.Write(a + ",");
        } 
        a = a + 1;
    }