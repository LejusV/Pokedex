using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Binacle Specie to store common natural stats of all Binacles
	#region SpecieBinacle
	public class SpecieBinacle : PokemonSpecie
	{
#nullable enable
		private static SpecieBinacle? _instance = null;
#nullable restore
        public static SpecieBinacle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBinacle();
                }
                return _instance;
            }
        }

		#region SpecieBinacle Builder
		public SpecieBinacle() : base(
			"Binacle",
			0.5,
			31.0,
			42, // HPs
			52, 67, // Attack & Defense
			39, 56, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Binacle Pokemon Class
	#region Binacle
	public class Binacle : Pokemon
	{
		#region Binacle Builders
		/// <summary>
		/// Binacle Builder waiting for a Nickname & a Level
		/// </summary>
		public Binacle(string nickname, int level)
		: base(
				688,
				SpecieBinacle.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Binacle Builder only waiting for a Level
		/// </summary>
		public Binacle(int level)
		: base(
				688,
				SpecieBinacle.Instance, // Pokemon Specie
				"Binacle", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Binacle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Binacle() : base(
			688,
			SpecieBinacle.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}