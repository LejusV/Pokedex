using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lilligant Specie to store common natural stats of all Lilligants
	#region SpecieLilligant
	public class SpecieLilligant : PokemonSpecie
	{
#nullable enable
		private static SpecieLilligant? _instance = null;
#nullable restore
        public static SpecieLilligant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLilligant();
                }
                return _instance;
            }
        }

		#region SpecieLilligant Builder
		public SpecieLilligant() : base(
			"Lilligant",
			70, // HPs
			60, 75, // Attack & Defense
			110, 75, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Lilligant Pokemon Class
	#region Lilligant
	public class Lilligant : Pokemon
	{
		#region Lilligant Builders
		/// <summary>
		/// Lilligant Builder waiting for a Nickname & a Level
		/// </summary>
		public Lilligant(string nickname, int level)
		: base(
				549,
				SpecieLilligant.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lilligant Builder only waiting for a Level
		/// </summary>
		public Lilligant(int level)
		: base(
				549,
				SpecieLilligant.Instance, // Pokemon Specie
				"Lilligant", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lilligant Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Lilligant() : base(
			549,
			SpecieLilligant.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}