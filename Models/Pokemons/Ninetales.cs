using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ninetales Specie to store common natural stats of all Ninetaless
	#region SpecieNinetales
	public class SpecieNinetales : PokemonSpecie
	{
#nullable enable
		private static SpecieNinetales? _instance = null;
#nullable restore
        public static SpecieNinetales Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNinetales();
                }
                return _instance;
            }
        }

		#region SpecieNinetales Builder
		public SpecieNinetales() : base(
			"Ninetales",
			73, // HPs
			76, 75, // Attack & Defense
			81, 100, // Special Attack & Defense
			100		
		)
		{
			this._height = 11;
			this._weight = 199;
		}
		#endregion
	}
	#endregion

	//Ninetales Pokemon Class
	#region Ninetales
	public class Ninetales : Pokemon
	{
		#region Ninetales Builders
		/// <summary>
		/// Ninetales Builder waiting for a Nickname & a Level
		/// </summary>
		public Ninetales(string nickname, int level)
		: base(
				38,
				SpecieNinetales.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninetales Builder only waiting for a Level
		/// </summary>
		public Ninetales(int level)
		: base(
				38,
				SpecieNinetales.Instance, // Pokemon Specie
				"Ninetales", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninetales Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ninetales() : base(
			38,
			SpecieNinetales.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}