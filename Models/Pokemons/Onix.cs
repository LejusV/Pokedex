using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Onix Specie to store common natural stats of all Onixs
	#region SpecieOnix
	public class SpecieOnix : PokemonSpecie
	{
#nullable enable
		private static SpecieOnix? _instance = null;
#nullable restore
        public static SpecieOnix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOnix();
                }
                return _instance;
            }
        }

		#region SpecieOnix Builder
		public SpecieOnix() : base(
			"Onix",
			8.8,
			210.0,
			35, // HPs
			45, 160, // Attack & Defense
			30, 45, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Onix Pokemon Class
	#region Onix
	public class Onix : Pokemon
	{
		#region Onix Builders
		/// <summary>
		/// Onix Builder waiting for a Nickname & a Level
		/// </summary>
		public Onix(string nickname, int level)
		: base(
				95,
				SpecieOnix.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Onix Builder only waiting for a Level
		/// </summary>
		public Onix(int level)
		: base(
				95,
				SpecieOnix.Instance, // Pokemon Specie
				"Onix", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Onix Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Onix() : base(
			95,
			SpecieOnix.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}