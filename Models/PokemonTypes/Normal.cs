﻿namespace Pokedex.Models.Types
{
    public class Normal : PokemonType
    {
#nullable enable
        private static Normal? _instance = null;
#nullable disable
        public static Normal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Normal();
                }
                return _instance;
            
            }
        }
        private Normal() : base("Normal", "Brown")
        {

        }
    }
}