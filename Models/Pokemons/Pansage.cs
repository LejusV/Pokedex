using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pansage Specie to store common natural stats of all Pansages
	#region SpeciePansage
	public class SpeciePansage : PokemonSpecie
	{
#nullable enable
		private static SpeciePansage? _instance = null;
#nullable restore
        public static SpeciePansage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePansage();
                }
                return _instance;
            }
        }

		#region SpeciePansage Builder
		public SpeciePansage() : base(
			"Pansage",
			0.6,
			10.5,
			50, // HPs
			53, 48, // Attack & Defense
			53, 48, // Special Attack & Defense
			64		
		)
		{}
		#endregion
	}
	#endregion

	//Pansage Pokemon Class
	#region Pansage
	public class Pansage : Pokemon
	{
		#region Pansage Builders
		/// <summary>
		/// Pansage Builder waiting for a Nickname & a Level
		/// </summary>
		public Pansage(string nickname, int level)
		: base(
				511,
				SpeciePansage.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansage Builder only waiting for a Level
		/// </summary>
		public Pansage(int level)
		: base(
				511,
				SpeciePansage.Instance, // Pokemon Specie
				"Pansage", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansage Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pansage() : base(
			511,
			SpeciePansage.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}