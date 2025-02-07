# Old Phone Keypad Input Decoder

## Overview
This project implements a C# program that simulates old mobile phone keypads, where multiple presses on a key produce different letters. The function `OldPhonePad` converts a string of keypad inputs into a decoded text output.

## Features
- Simulates multi-tap input from old mobile phone keypads.
- Supports backspace (`*`) to delete characters.
- Ends input with (`#`).

## How It Works
1. Each number key (0-9) corresponds to a set of letters:
    - `2` → "ABC"
    - `3` → "DEF"
    - `4` → "GHI"
    - `5` → "JKL"
    - `6` → "MNO"
    - `7` → "PQRS"
    - `8` → "TUV"
    - `9` → "WXYZ"
    - `0` → " " (space)
2. Repeated key presses cycle through the characters assigned to that key.
3. The `*` key deletes the last entered character.
4. The `#` key marks the end of input.

## Installation
1. Clone this repository:
   ```sh
   git clone https://github.com/your-username/OldPhoneKeyInput.git
   ```
2. Open the project in your preferred C# development environment.
3. Compile and run the program.

## Usage
Run the program and provide an input string representing keypress sequences. Example:
```csharp
string result = OldPhonePad("4433555 555666#");
Console.WriteLine(result);
```
Expected Output:
```
HELLO
```

## Code Explanation
- The `OldPhonePad` method processes the input string by counting repeated key presses.
- It maps the key sequences to corresponding letters.
- The `*` key removes characters, and the `#` key signals the end of input.

## Author
[Shine Wai TUn] - [GitHub Profile](https://github.com/shinewaitun)
