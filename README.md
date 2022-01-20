<b>String Calculator TDD Kata</b> <br/><br/>
Create a simple String calculator with a method signature:

int Add(string numbers)
The method can take up to two numbers, separated by commas, and will return their sum.

For example "" or "1" or "1,2" as inputs. (for an empty string it will return 0)

Hints:

Start with the simplest test case of an empty string and move to one and two numbers
Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
Remember to refactor after each passing test
Allow the Add method to handle an unknown amount of numbers

Allow the Add method to handle new lines between numbers (instead of commas).

The following input is ok: "1\n2,3" (will equal 6)
The following input is NOT ok: "1,\n" (not need to prove it - just clarifying)
Support different delimiters

To change a delimiter, the beginning of the string will contain a separate line that looks like this: "//[delimiter]\n[numbers…]" for example "//;\n1;2" should return three where the default delimiter is ";"
The first line is optional. all existing scenarios should still be supported
Calling Add with a negative number will throw an exception "negatives not allowed" - and the negative that was passed.

If there are multiple negatives, show all of them in the exception message.

![Test_AddNewLine](https://user-images.githubusercontent.com/52338464/150368809-d8ee0b99-9ad6-4033-b58b-8cb2588de043.png)

![Test_AddSIngleNumber](https://user-images.githubusercontent.com/52338464/150368833-ecb906d5-5f4f-44f0-9faa-877aaf39c850.png)
![Test_SumOfTwoNumbers](https://user-images.githubusercontent.com/52338464/150368851-ef0194a4-db96-4070-9498-9350c1ecf570.png)
![Test_FailDelimiters](https://user-images.githubusercontent.com/52338464/150368869-5768fe2b-f2e0-49be-ba15-a388f196bb2e.png)
![Test_EmptyString](https://user-images.githubusercontent.com/52338464/150368936-2d67716c-b3cf-47ee-b713-55fe9185713d.png)
