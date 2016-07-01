# FontAwesome-For-WinForms-CSharp
Simple use of FontAwesome font inside a C# winforms Application. Only the class file, and the TTF font is required.

Make sure that the FontAwesome font is in the path where your compiled program is running from.

For example, while building in Debug, you will want to copy 'fontawesome-webfont.ttf' to the following
location inside the project folder (FontAwesomeDemo)

    ./bin/Debug/

This rule applies to all distributions including re-use.

You can change this path inside the `Fonts.cs` file by changing the value for `FontAwesomeTTF` .
