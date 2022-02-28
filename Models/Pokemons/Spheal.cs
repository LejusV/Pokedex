using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spheal Specie to store common natural stats of all Spheals
	#region SpecieSpheal
	public class SpecieSpheal : PokemonSpecie
	{
#nullable enable
		private static SpecieSpheal? _instance = null;
#nullable restore
        public static SpecieSpheal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpheal();
                }
                return _instance;
            }
        }

		#region SpecieSpheal Builder
		public SpecieSpheal() : base(
			"Spheal",
			70, // HPs
			40, 50, // Attack & Defense
			55, 50, // Special Attack & Defense
			25			
		) {}
		#endregion
	}
	#endregion

	//Spheal Pokemon Class
	#region Spheal
	public class Spheal : Pokemon
	{
		#region Spheal Builders
		/// <summary>
		/// Spheal Builder waiting for a Nickname & a Level
		/// </summary>
		public Spheal(string nickname, int level)
		: base(
				363,
				SpecieSpheal.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spheal Builder only waiting for a Level
		/// </summary>
		public Spheal(int level)
		: base(
				363,
				SpecieSpheal.Instance, // Pokemon Specie
				"Spheal", level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spheal Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Spheal() : base(
			363,
			SpecieSpheal.Instance, // Pokemon Specie
			Ice.Instance, Water.Instance			
		) {}
		#endregion
	}
	#endregion
}