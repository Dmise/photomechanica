using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewTasks;
using System.Collections;
using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Xunit;

namespace IntersectArraysTests
{
	// Task: implement one positive test-case for IntersectArrays.IntersectTwoArrays().
	// Restrictions: you CAN use any Unit Testing Framework you like.

    // [TestClass]
    public class IntersectArraysTests
    {
      

        [Fact] //[TestMethod]
        public static void IntersectArrays_IntersectTwoArrays_set1_ReturnBool()
        {

            //Arrange
            var arr1 = DataStorage.data1.set1.ToArray();
            var arr2 = DataStorage.data1.set2.ToArray();
            var fact = DataStorage.data1.rightValue.ToArray();

            //Act                
            var result = IntersectArrays.IntersectTwoArraysHash(arr1, arr2);
            Array.Sort(result);

            //Assert
            if (fact.Length != result.Length)
                throw new Exception("FAILED");

                
            for (int i = 0;i < fact.Length;i++) 
            {
                if (result[i] != fact[i])
                    throw new Exception("FAILED");
            }                 
        }


        [Fact] 
        public static void IntersectArrays_IntersectTwoArrays_set2_ReturnBool()
        {

            //Arrange
            var arr1 = DataStorage.data2.set1.ToArray();
            var arr2 = DataStorage.data2.set2.ToArray();
            var fact = DataStorage.data2.rightValue.ToArray();

            //Act                
            var result = IntersectArrays.IntersectTwoArraysHash(arr1, arr2);
            Array.Sort(result);

            //Assert
            if (fact.Length != result.Length)
                throw new Exception("FAILED");

            for (int i = 0; i < fact.Length; i++)
            {
                if (result[i] != fact[i])
                    throw new Exception("FAILED");
            }
        }

        [Fact]
        public static void IntersectArrays_IntersectTwoArrays_set3_ReturnBool()
        {

            //Arrange
            var arr1 = DataStorage.data3.set1.ToArray();
            var arr2 = DataStorage.data3.set2.ToArray();
            var fact = DataStorage.data3.rightValue.ToArray();

            //Act                
            var result = IntersectArrays.IntersectTwoArraysHash(arr1, arr2);
            Array.Sort(result);

            //Assert
            if (fact.Length != result.Length)
                throw new Exception("FAILED");

            for (int i = 0; i < fact.Length; i++)
            {
                if (result[i] != fact[i])
                    throw new Exception("FAILED");
            }
        }

        [Fact]
        public static void IntersectArrays_IntersectTwoArrays_set4_ReturnBool()
        {

            //Arrange
            var arr1 = DataStorage.data4.set1.ToArray();
            var arr2 = DataStorage.data4.set2.ToArray();
            var fact = DataStorage.data4.rightValue.ToArray();

            //Act                
            var result = IntersectArrays.IntersectTwoArraysHash(arr1, arr2);


            //Assert

            if (fact.Length != result.Length)
                throw new Exception("FAILED");

            for (int i = 0; i < fact.Length; i++)
            {
                if (result[i] != fact[i])
                    throw new Exception("FAILED");
            }
        }

        [Fact]
        public static void IntersectArrays_IntersectTwoArraysHash_set1_ReturnBool()
        {

            //Arrange
            var arr1 = DataStorage.data1.set1.ToArray();
            var arr2 = DataStorage.data1.set2.ToArray();
            var fact = DataStorage.data1.rightValue.ToArray();

            //Act                
            var result = IntersectArrays.IntersectTwoArraysHash(arr1, arr2);


            //Assert

            if (fact.Length != result.Length)
                throw new Exception("FAILED");

            for (int i = 0; i < fact.Length; i++)
            {
                if (result[i] != fact[i])
                    throw new Exception("FAILED");
            }
        }
    }
}
