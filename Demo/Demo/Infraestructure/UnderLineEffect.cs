using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Demo.Infraestructure.CustomForms
{
    public class UnderLineEffect : RoutingEffect
    {
        public const string EffectNamespace = "Example.CustomForms";

        public UnderLineEffect():base($"{EffectNamespace}.{nameof(UnderLineEffect)}")
        {
        }
    }
}
