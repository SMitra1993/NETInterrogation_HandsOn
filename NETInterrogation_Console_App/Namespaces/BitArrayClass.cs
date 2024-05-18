using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class BitArrayClass
    {
        // Using the default constructor to create an empty BitArray of size 8 (all bits set to false)
        BitArray featureFlags = new BitArray(8);

        // Using the constructor to create a BitArray from an array of bool values
        public void CreateBitArrayFromBool()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
        }

        // Using the constructor to create a BitArray from an integer value (32 bits)
        public void CreateBitArrayFromInt()
        {
            BitArray featureFlagsFromInt = new BitArray(new int[] { 42 }); // Binary: 101010
        }

        // Using the constructor to create a BitArray from another BitArray
        public void CreateBitArrayFromAnother()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
            BitArray copiedFlags = new BitArray(featureFlagsFromArray);
        }

        // Displaying the values in the BitArray
        public void DisplayInitialFlag()
        {
            Console.WriteLine("Initial feature flags:");
            PrintBitArray(featureFlags);
        }
        public void DisplayFlagFromArray()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
            Console.WriteLine("Feature flags from bool array:");
            PrintBitArray(featureFlagsFromArray);
        }
        public void DisplayFlagFromInt()
        {
            BitArray featureFlagsFromInt = new BitArray(new int[] { 42 }); // Binary: 101010
            Console.WriteLine("Feature flags from integer:");
            PrintBitArray(featureFlagsFromInt);
        }
        public void DisplayCopiedFlag()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
            BitArray copiedFlags = new BitArray(featureFlagsFromArray);
            Console.WriteLine("Copied feature flags:");
            PrintBitArray(copiedFlags);
        }

        // Using the Length property to get and set the length of the BitArray
        public void GetSetBitArrayLength()
        {
            Console.WriteLine($"Length of featureFlags: {featureFlags.Length}");
            featureFlags.Length = 16; // Resizing the BitArray
            Console.WriteLine($"New length of featureFlags: {featureFlags.Length}");
            PrintBitArray(featureFlags);
        }

        // Using the Get and Set methods to access individual bits
        public void GetIndividualBits()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
            bool firstFeature = featureFlagsFromArray.Get(0);
            Console.WriteLine($"First feature flag: {firstFeature}");
        }
        public void SetIndividualBits()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
            featureFlagsFromArray.Set(1, true);
            Console.WriteLine("Feature flags after setting the second bit to true:");
            PrintBitArray(featureFlagsFromArray);
        }

        // Using the Not method to invert all bits
        public void InvertAllBits()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
            featureFlagsFromArray.Not();
            Console.WriteLine("Feature flags after NOT operation:");
            PrintBitArray(featureFlagsFromArray);
        }

        // Using the And method to perform bitwise AND operation
        public void PerformBitwiseANDOperation()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
            BitArray featureFlagsFromInt = new BitArray(new int[] { 42 }); // Binary: 101010
            featureFlagsFromInt.Length = initialFlags.Length;
            BitArray andResult = featureFlagsFromArray.And(featureFlagsFromInt);
            Console.WriteLine("Result of AND operation:");
            PrintBitArray(andResult);
        }

        // Using the Or method to perform bitwise OR operation
        public void PerformBitwiseOROperation()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
            BitArray featureFlagsFromInt = new BitArray(new int[] { 42 }); // Binary: 101010
            featureFlagsFromInt.Length = initialFlags.Length;
            BitArray orResult = featureFlagsFromArray.Or(featureFlagsFromInt);
            Console.WriteLine("Result of OR operation:");
            PrintBitArray(orResult);
        }

        // Using the Xor method to perform bitwise XOR operation
        public void PerformBitwiseXOROperation()
        {
            bool[] initialFlags = { true, false, true, true, false, false, true, false };
            BitArray featureFlagsFromArray = new BitArray(initialFlags);
            BitArray featureFlagsFromInt = new BitArray(new int[] { 42 }); // Binary: 101010
            featureFlagsFromInt.Length = initialFlags.Length;
            BitArray xorResult = featureFlagsFromArray.Xor(featureFlagsFromInt);
            Console.WriteLine("Result of XOR operation:");
            PrintBitArray(xorResult);
        }

        // Using the CopyTo method to copy BitArray to an array
        public void CopyBitArrayToArray()
        {
            bool[] boolArray = new bool[16];
            featureFlags.CopyTo(boolArray, 0);
            Console.WriteLine("Copied BitArray to bool array:");
            foreach (bool bit in boolArray)
            {
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();
        }

        static void PrintBitArray(BitArray bitArray)
        {
            foreach (bool bit in bitArray)
            {
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();
        }
    }
}
