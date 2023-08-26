var numbers = new[] { 1, 5, 7, 3, 9, 13, 23, 56, 87, 98, 34, 54, 65 };
for (int outer = 0; outer < numbers.Length - 1; outer++)
{
    var minNumberIndex = outer;
    for (int inner = outer; inner < numbers.Length; inner++)
    {
        if (numbers[inner] < numbers[minNumberIndex])
            minNumberIndex = inner;
    }

    var temp = numbers[minNumberIndex];
    numbers[minNumberIndex] = numbers[outer];
    numbers[outer] = temp;
}

Console.WriteLine(string.Join(", ", numbers));