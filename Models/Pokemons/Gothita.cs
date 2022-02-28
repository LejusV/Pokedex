using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gothita Specie to store common natural stats of all Gothitas
	#region SpecieGothita
	public class SpecieGothita : PokemonSpecie
	{
#nullable enable
		private static SpecieGothita? _instance = null;
#nullable restore
        public static SpecieGothita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGothita();
                }
                return _instance;
            }
        }

		#region SpecieGothita Builder
		public SpecieGothita() : base(
			"Gothita",
			45, // HPs
			30, 50, // Attack & Defense
			55, 65, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Gothita Pokemon Class
	#region Gothita
	public class Gothita : Pokemon
	{
		#region Gothita Builders
		/// <summary>
		/// Gothita Builder waiting for a Nickname & a Level
		/// </summary>
		public Gothita(string nickname, int level)
		: base(
				574,
				SpecieGothita.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothita Builder only waiting for a Level
		/// </summary>
		public Gothita(int level)
		: base(
				574,
				SpecieGothita.Instance, // Pokemon Specie
				"Gothita", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothita Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Gothita() : base(
			574,
			SpecieGothita.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}