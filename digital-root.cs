  public int DigitalRoot(long n)
  {
    char[] numbers = n.ToString().ToCharArray();
    long sum = 0;

    if (n < 10) return (int) n;

    for (int i = 0; i < numbers.Length; i++)
    {
        sum = sum + numbers[i] - '0';
    }
    
    return DigitalRoot(sum);   
  }