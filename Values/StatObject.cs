﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Elebris.Library.Values
{

    public class StatObject : CharacterValue, IStatObject
    {
        public StatData statType;
        public AttributeObject[] referenceAttributes;


        public virtual void CalculateBaseValue(AttributeObject[] attributeObjects, int level)
        {
        }
        public override void DependantEventCalled(int level)
        {
            isDirty = true;
            CalculateBaseValue(referenceAttributes, level);

        }
    }



}