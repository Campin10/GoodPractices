namespace Employess.Core
{
 class ConcreteHourlySalary: Creator
    {
        public override IContract FactoryMethod()
        {
            return new HourlySalary();
        }
    }
}