using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_miya
{
    class Inventory<S> : IEnumerable<S>
    {
        S[] products = new S[10];
        int count = 0;

        public void Add(S product)
        {
            products[count] = product;
            count++;
        }
        public void Remove(S product)
        {
            //S[] temp = new S[count - 1];
            //foreach(product in products)
            //{
            //    if()
            //    {

            //    }
                
            //}
        }
        public IEnumerator<S> GetEnumerator()
        {
            for (int i=0; i<count; i++)
            {
                yield return products[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            //throw new NotImplementedException();
        }
    }
}
//create inventory class and product class
//garage will be like inventory
//car will be like product
