﻿using FacadeDesignPattern.BaseExample.Subsystems;

namespace FacadeDesignPattern.BaseExample
{
    internal class Facade
    {
        protected readonly Subsystem1 _subsystem1;

        protected readonly Subsystem2 _subsystem2;
        
        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";

            result += _subsystem1.Operation1();
            result += _subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += _subsystem1.OperationN();
            result += _subsystem2.OperationN();

            return result;
        }
    }
}
