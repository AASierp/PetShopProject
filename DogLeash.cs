using System;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace PetShopPart1

{
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material {  get; set; }

        //public DogLeash(int aQuantity, string aMaterial, int aLength) 
        //{ 
        //    Quantity = aQuantity;
        //    Material = aMaterial;   
        //    LengthInches = aLength;
        //}
    }

    
}
