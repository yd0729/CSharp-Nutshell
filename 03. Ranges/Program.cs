char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

char[] firstTwo = vowels[..2]; // 'a', 'e'
char[] lastThree = vowels[2..]; // 'i', 'o', 'u'
char[] middleOne = vowels[2..3]; // 'i'

char[] lastTwo = vowels[^2..]; // 'o', 'u'

Range firstTwoRange = 0..2;
char[] firstTwo2 = vowels[firstTwoRange]; // 'a', 'e'

firstTwo2[0] = 'p';

Console.WriteLine(vowels[0]); // 'a'