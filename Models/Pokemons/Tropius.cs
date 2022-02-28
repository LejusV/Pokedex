using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tropius Specie to store common natural stats of all Tropiuss
	#region SpecieTropius
	public class SpecieTropius : PokemonSpecie
	{
#nullable enable
		private static SpecieTropius? _instance = null;
#nullable restore
        public static SpecieTropius Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTropius();
                }
                return _instance;
            }
        }

		#region SpecieTropius Builder
		public SpecieTropius() : base(
			"Tropius",
			99, // HPs
			68, 83, // Attack & Defense
			72, 87, // Special Attack & Defense
			51			
		) {}
		#endregion
	}
	#endregion

	//Tropius Pokemon Class
	#region Tropius
	public class Tropius : Pokemon
	{
		#region Tropius Builders
		/// <summary>
		/// Tropius Builder waiting for a Nickname & a Level
		/// </summary>
		public Tropius(string nickname, int level)
		: base(
				357,
				SpecieTropius.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tropius Builder only waiting for a Level
		/// </summary>
		public Tropius(int level)
		: base(
				357,
				SpecieTropius.Instance, // Pokemon Specie
				"Tropius", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tropius Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Tropius() : base(
			357,
			SpecieTropius.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}