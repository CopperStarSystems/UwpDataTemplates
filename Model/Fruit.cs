//  --------------------------------------------------------------------------------------
// UwpDataTemplates.Fruit.cs
// 2016/11/27
//  --------------------------------------------------------------------------------------

namespace UwpDataTemplates.Model
{
    public abstract class Fruit
    {
        protected Fruit(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public string Name { get; private set; }
    }
}