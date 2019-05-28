 namespace Employess.Core
{
  class ConcreteMonthlySalary: Creator
    {
        public override IContract FactoryMethod()
        {
            return new MonthlySalary();
        }
    }
}