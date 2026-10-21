namespace Session02_AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1
            // a) struct: value type, stored in stack, store small data, faster than class in retreving data, copy objects copies the
            // values not references, not support inheritance, allows 3 access modifiers: (public, internal, private), the compiler generates
            // the parameterless constructor even we generate a userdefined constructor or not, not support null unless we make it 
            // nullable, the keyword new is constructor choise, can not control object lifetime.
            // class: reference type, stored in heap and address in stack (not usually), store large data, slower than struct in retreving
            // data, copy objects copies the reference not values, support inheritance, allows all access modifiers, the compiler does not
            // generate the parameterless constructor if we generate a userdefined constructor, support null, keyword new is constructor
            // choice and create object in heap, adds the address in stack, initialize values to the data in the object, controls object
            // lifetime.

            // b) because it controls object lifetime, store large data, support inheritance.
            #endregion
            #endregion
        }
    }
}
