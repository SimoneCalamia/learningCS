// RECORDS
// It's a data model (such as a class or a struct) but with specific syntax and behaviour to better work with ceratin kind of data.
// In fact, records are use moslty with types (that define data models) which purpose is to store data. In particular if the data model depends on value euqality or if the objects of that type are immutable.
// Records provide an override of the ToString() method and their members support value equality
//
// Value euality:
// 	Value equality for two different istances of a record match in types and all their property and field values compare equals.
//
// Reference equality:
// 	Reference equality means that two variable of a class type refers to the same object.
// 	For reference types, such as classes, the default equality is the reference equality, unless value equality is implemented
//
// 	Takeaway: records differ from classes in terms of the default equality check they can be object of.
//
//
// Immutability:
// 	There might be some cases where you need variable's property and field values not to change in thread. For example for an hash table:
// 		an hash table is a data stracture of key-value pairs where an input key is given and a hash code is generated from the hash function,
// 		the hash code represent the position of the key-value pair in the hash table.
// 	So in this case, for example, you want the hash codes to remain always the same, otherwise if the hash code of a key-value pair changes, then
// 	the key supposed to lead to that value will result in another value;
//

public class NamedItem {

    private string? _name;
    private int _age = 25;
    private string? _address = "Los Angeles";

    static void Main() {

        NamedItem NamedItem = new NamedItem();
        NamedItem namedItem = NamedItem;

        namedItem.Name = "Tondelaya";

        Console.WriteLine($"{namedItem.Name} is {namedItem.Age} years old and lives in {namedItem.Address}\n");
    }

    public string? Name {
        set { _name = value; }
        get { return _name; }
    }
    public int Age => _age;
    public string? Address {
        set { _address = value; }
        get { return _address; }
    }
}
