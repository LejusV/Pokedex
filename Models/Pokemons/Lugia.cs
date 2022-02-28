using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lugia Specie to store common natural stats of all Lugias
	#region SpecieLugia
	public class SpecieLugia : PokemonSpecie
	{
#nullable enable
		private static SpecieLugia? _instance = null;
#nullable restore
        public static SpecieLugia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLugia();
                }
                return _instance;
            }
        }

		#region SpecieLugia Builder
		public SpecieLugia() : base(
			"Lugia",
			106, // HPs
			90, 130, // Attack & Defense
			90, 154, // Special Attack & Defense
			110			
		) {}
		#endregion
	}
	#endregion

	//Lugia Pokemon Class
	#region Lugia
	public class Lugia : Pokemon
	{
		#region Lugia Builders
		/// <summary>
		/// Lugia Builder waiting for a Nickname & a Level
		/// </summary>
		public Lugia(string nickname, int level)
		: base(
				249,
				SpecieLugia.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lugia Builder only waiting for a Level
		/// </summary>
		public Lugia(int level)
		: base(
				249,
				SpecieLugia.Instance, // Pokemon Specie
				"Lugia", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lugia Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Lugia() : base(
			249,
			SpecieLugia.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}