using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestLinkedList
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void If_add_3_elements_count_is_updated()
        {
            var t = new LinkedList<string>();
            t.Add("s1");
            t.Add("s1");
            t.Add("s1");
            t.Add("s1");
            t.Add("s1");
            Assert.AreEqual(5, t.Count);
        }
        [TestMethod]
        public void If_use_getMethod_return_expected_value()
        {
            var t = new LinkedList<string>();
            t.Add("s1");
            t.Add("s1");
            t.Add("s1");
            t.Add("c");
            t.Add("s1");

            t.Get(3);
            Assert.AreEqual(t.Get(3), "c" );
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Cannot_get_from_an_empty_list()
        {
            var t = new LinkedList<string>();
            t.Get(3);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Cannot_remove_from_an_empty_list()
        {
            var t = new LinkedList<string>();
            t.Remove("c");
        }

        [TestMethod]
        public void If_add_and_remove_same_type()
        {
            var t = new LinkedList<string>();
            t.Add("s1");
            t.Remove("s1"); 
            
            Assert.AreEqual(0,t.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Inserted_in_wrong_index()
        {
            var t = new LinkedList<string>();
            t.Insert("s1",-1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void If_add_and_remove_different_type()
        {
            var t = new LinkedList<string>();
            t.Add("s1");
            t.Remove("t1");
            
        }
    }
}
