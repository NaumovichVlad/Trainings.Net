﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerLib.Ingredients.Onions
{
    public abstract class Onion : Ingredient
    {
        public Onion(double costPrice) : base(costPrice)
        { }

        public override IngredientTypes Type => IngredientTypes.Onion;
    }
}
