using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Exeggutor Specie to store common natural stats of all Exeggutors
	#region SpecieExeggutor
	public class SpecieExeggutor : PokemonSpecie
	{
#nullable enable
		private static SpecieExeggutor? _instance = null;
#nullable restore
        public static SpecieExeggutor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieExeggutor();
                }
                return _instance;
            }
        }

		#region SpecieExeggutor Builder
		public SpecieExeggutor() : base(
			"Exeggutor",
			95, // HPs
			95, 85, // Attack & Defense
			125, 75, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Exeggutor Pokemon Class
	#region Exeggutor
	public class Exeggutor : Pokemon
	{
		#region Exeggutor Builders
		/// <summary>
		/// Exeggutor Builder waiting for a Nickname & a Level
		/// </summary>
		public Exeggutor(string nickname, int level)
		: base(
				103,
				SpecieExeggutor.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggutor Builder only waiting for a Level
		/// </summary>
		public Exeggutor(int level)
		: base(
				103,
				SpecieExeggutor.Instance, // Pokemon Specie
				"Exeggutor", level,
				Grass.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggutor Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Exeggutor() : base(
			103,
			SpecieExeggutor.Instance, // Pokemon Specie
			Grass.Instance, Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}