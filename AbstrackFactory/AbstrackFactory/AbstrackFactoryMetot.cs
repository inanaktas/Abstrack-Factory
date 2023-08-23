using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrackFactory
{
    internal class AbstrackFactoryMetot
    {
    }
    internal abstract class ContinentFactory
    {
        internal abstract Car GenerateCar();
        internal abstract Motorcycle GenerateMotorcycle();

    }

    internal abstract class Car
    {
        internal abstract void GetAirbagCount();
    }
    internal abstract class Motorcycle
    {
        internal abstract void GetProductMaterial();
    }

    internal class FordRanger : Car
    {
        internal override void GetAirbagCount()
        {

        }
    }
    internal class FordFocus : Car
    {
        internal override void GetAirbagCount()
        {

        }
    }
    internal class HondaRally : Motorcycle
    {
        internal override void GetProductMaterial()
        {

        }
    }
    internal class HondaDioScooter : Motorcycle
    {
        internal override void GetProductMaterial()
        {

        }
    }

    internal class GenerateCenter
    {
        private readonly Car _car;
        private readonly Motorcycle _motorcycle;

        internal GenerateCenter(ContinentFactory factory)
        {
            _car = factory.GenerateCar();
            _motorcycle = factory.GenerateMotorcycle();
        }

        internal void ShowMassage()
        {
            Console.WriteLine("Üretim Merkezi Çalışıyor.");
        }

    }

    internal class EuropeFactory : ContinentFactory
    {

        internal override Car GenerateCar()
        {
            return new FordFocus();
        }

        internal override Motorcycle GenerateMotorcycle()
        {
            return new HondaDioScooter();
        }
    }

    internal class AmericaFactory : ContinentFactory
    {
        internal override Car GenerateCar()
        {
            return new FordRanger();

        }
        internal override Motorcycle GenerateMotorcycle()
        {
            return new HondaRally();
        }
    }
}
