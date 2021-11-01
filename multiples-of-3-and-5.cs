    static int Solution(int value)
    {
        int sum = 0;
        for (int i = value-1; i > 0; i--)
        {
        if ((i % 5 == 0)||(i % 3 == 0))
            sum += i;
        }
        return sum;
    }

    static int Solution2(int value)
    {
        return Enumerable.Range(0, value)
                        .Where(x => x % 3 == 0 || x % 5 == 0)
                        .Sum();
    }

    static int Solution3(int value)
    {
        var sum = 0;
        for(int i = 3; i < value; i++)
        {
            if(i % 3 == 0 || i % 5 == 0) sum += i;
        }
        return sum;
    }