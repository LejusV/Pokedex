using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Exeggcute Specie to store common natural stats of all Exeggcutes
	#region SpecieExeggcute
	public class SpecieExeggcute : PokemonSpecie
	{
#nullable enable
		private static SpecieExeggcute? _instance = null;
#nullable restore
        public static SpecieExeggcute Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieExeggcute();
                }
                return _instance;
            }
        }

		#region SpecieExeggcute Builder
		public SpecieExeggcute() : base(
			"Exeggcute",
			60, // HPs
			40, 80, // Attack & Defense
			60, 45, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Exeggcute Pokemon Class
	#region Exeggcute
	public class Exeggcute : Pokemon
	{
		#region Exeggcute Builders
		/// <summary>
		/// Exeggcute Builder waiting for a Nickname & a Level
		/// </summary>
		public Exeggcute(string nickname, int level)
		: base(
				102,
				SpecieExeggcute.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggcute Builder only waiting for a Level
		/// </summary>
		public Exeggcute(int level)
		: base(
				102,
				SpecieExeggcute.Instance, // Pokemon Specie
				"Exeggcute", level,
				Grass.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggcute Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Exeggcute() : base(
			102,
			SpecieExeggcute.Instance, // Pokemon Specie
			Grass.Instance, Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}