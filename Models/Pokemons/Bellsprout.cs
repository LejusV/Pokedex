using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bellsprout Specie to store common natural stats of all Bellsprouts
	#region SpecieBellsprout
	public class SpecieBellsprout : PokemonSpecie
	{
#nullable enable
		private static SpecieBellsprout? _instance = null;
#nullable restore
        public static SpecieBellsprout Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBellsprout();
                }
                return _instance;
            }
        }

		#region SpecieBellsprout Builder
		public SpecieBellsprout() : base(
			"Bellsprout",
			50, // HPs
			75, 35, // Attack & Defense
			70, 30, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Bellsprout Pokemon Class
	#region Bellsprout
	public class Bellsprout : Pokemon
	{
		#region Bellsprout Builders
		/// <summary>
		/// Bellsprout Builder waiting for a Nickname & a Level
		/// </summary>
		public Bellsprout(string nickname, int level)
		: base(
				69,
				SpecieBellsprout.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellsprout Builder only waiting for a Level
		/// </summary>
		public Bellsprout(int level)
		: base(
				69,
				SpecieBellsprout.Instance, // Pokemon Specie
				"Bellsprout", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellsprout Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Bellsprout() : base(
			69,
			SpecieBellsprout.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}