using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Feebas Specie to store common natural stats of all Feebass
	#region SpecieFeebas
	public class SpecieFeebas : PokemonSpecie
	{
#nullable enable
		private static SpecieFeebas? _instance = null;
#nullable restore
        public static SpecieFeebas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFeebas();
                }
                return _instance;
            }
        }

		#region SpecieFeebas Builder
		public SpecieFeebas() : base(
			"Feebas",
			20, // HPs
			15, 20, // Attack & Defense
			10, 55, // Special Attack & Defense
			80		
		)
		{
			this._height = 6;
			this._weight = 74;
		}
		#endregion
	}
	#endregion

	//Feebas Pokemon Class
	#region Feebas
	public class Feebas : Pokemon
	{
		#region Feebas Builders
		/// <summary>
		/// Feebas Builder waiting for a Nickname & a Level
		/// </summary>
		public Feebas(string nickname, int level)
		: base(
				349,
				SpecieFeebas.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feebas Builder only waiting for a Level
		/// </summary>
		public Feebas(int level)
		: base(
				349,
				SpecieFeebas.Instance, // Pokemon Specie
				"Feebas", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feebas Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Feebas() : base(
			349,
			SpecieFeebas.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}