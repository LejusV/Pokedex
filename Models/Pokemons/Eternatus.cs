using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eternatus Specie to store common natural stats of all Eternatuss
	#region SpecieEternatus
	public class SpecieEternatus : PokemonSpecie
	{
#nullable enable
		private static SpecieEternatus? _instance = null;
#nullable restore
        public static SpecieEternatus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEternatus();
                }
                return _instance;
            }
        }

		#region SpecieEternatus Builder
		public SpecieEternatus() : base(
			"Eternatus",
			140, // HPs
			85, 95, // Attack & Defense
			145, 95, // Special Attack & Defense
			130			
		) {}
		#endregion
	}
	#endregion

	//Eternatus Pokemon Class
	#region Eternatus
	public class Eternatus : Pokemon
	{
		#region Eternatus Builders
		/// <summary>
		/// Eternatus Builder waiting for a Nickname & a Level
		/// </summary>
		public Eternatus(string nickname, int level)
		: base(
				890,
				SpecieEternatus.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eternatus Builder only waiting for a Level
		/// </summary>
		public Eternatus(int level)
		: base(
				890,
				SpecieEternatus.Instance, // Pokemon Specie
				"Eternatus", level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eternatus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Eternatus() : base(
			890,
			SpecieEternatus.Instance, // Pokemon Specie
			Poison.Instance, Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}