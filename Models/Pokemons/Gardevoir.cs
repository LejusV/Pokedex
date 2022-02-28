using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gardevoir Specie to store common natural stats of all Gardevoirs
	#region SpecieGardevoir
	public class SpecieGardevoir : PokemonSpecie
	{
#nullable enable
		private static SpecieGardevoir? _instance = null;
#nullable restore
        public static SpecieGardevoir Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGardevoir();
                }
                return _instance;
            }
        }

		#region SpecieGardevoir Builder
		public SpecieGardevoir() : base(
			"Gardevoir",
			68, // HPs
			65, 65, // Attack & Defense
			125, 115, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Gardevoir Pokemon Class
	#region Gardevoir
	public class Gardevoir : Pokemon
	{
		#region Gardevoir Builders
		/// <summary>
		/// Gardevoir Builder waiting for a Nickname & a Level
		/// </summary>
		public Gardevoir(string nickname, int level)
		: base(
				282,
				SpecieGardevoir.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gardevoir Builder only waiting for a Level
		/// </summary>
		public Gardevoir(int level)
		: base(
				282,
				SpecieGardevoir.Instance, // Pokemon Specie
				"Gardevoir", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gardevoir Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Gardevoir() : base(
			282,
			SpecieGardevoir.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}