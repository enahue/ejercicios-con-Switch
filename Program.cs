//Ejercicio 2 - Switch

//Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

//Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
Console.WriteLine("Hola mundo en diferentes lenguajes de programación:\n");
Console.WriteLine("a.- C# \nb.- Java\nc.- C++"+"\n");
Console.Write("Selecciona una opción: ");

string language = Console.ReadLine().ToLower();

switch (language)
{
    case "a":
        {
            Console.WriteLine("Console.Writeline(\"Hola mundo\");\n");
        };
        break;
    case "b":
        {
            Console.WriteLine("System.out.println(\"Hola Mundo\");");
        }
        break;
        case "c":
        {
            Console.WriteLine("int main () \r\n{\r\n    std::cout << \"Hola, mundo\";\r\n    return 0;\r\n}");
        }
        break;
        default: {
            Console.WriteLine("Ingresa una opcion válida");
        };
        break;

}