using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Decidueye Specie to store common natural stats of all Decidueyes
	#region SpecieDecidueye
	public class SpecieDecidueye : PokemonSpecie
	{
#nullable enable
		private static SpecieDecidueye? _instance = null;
#nullable restore
        public static SpecieDecidueye Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDecidueye();
                }
                return _instance;
            }
        }

		#region SpecieDecidueye Builder
		public SpecieDecidueye() : base(
			"Decidueye",
			1.6,
			36.6,
			78, // HPs
			107, 75, // Attack & Defense
			100, 100, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Decidueye Pokemon Class
	#region Decidueye
	public class Decidueye : Pokemon
	{
		#region Decidueye Builders
		/// <summary>
		/// Decidueye Builder waiting for a Nickname & a Level
		/// </summary>
		public Decidueye(string nickname, int level)
		: base(
				724,
				SpecieDecidueye.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Decidueye Builder only waiting for a Level
		/// </summary>
		public Decidueye(int level)
		: base(
				724,
				SpecieDecidueye.Instance, // Pokemon Specie
				"Decidueye", level,
				Grass.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Decidueye Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Decidueye() : base(
			724,
			SpecieDecidueye.Instance, // Pokemon Specie
			Grass.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}