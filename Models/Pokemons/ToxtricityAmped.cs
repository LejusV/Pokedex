using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Toxtricity-Amped Specie to store common natural stats of all Toxtricity-Ampeds
	#region SpecieToxtricity-Amped
	public class SpecieToxtricityAmped : PokemonSpecie
	{
#nullable enable
		private static SpecieToxtricityAmped? _instance = null;
#nullable restore
        public static SpecieToxtricityAmped Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToxtricityAmped();
                }
                return _instance;
            }
        }

		#region SpecieToxtricity-Amped Builder
		public SpecieToxtricityAmped() : base(
			"Toxtricity-Amped",
			1.6,
			40.0,
			75, // HPs
			98, 70, // Attack & Defense
			114, 70, // Special Attack & Defense
			75		
		)
		{}
		#endregion
	}
	#endregion

	//Toxtricity-Amped Pokemon Class
	#region Toxtricity-Amped
	public class ToxtricityAmped : Pokemon
	{
		#region Toxtricity-Amped Builders
		/// <summary>
		/// Toxtricity-Amped Builder waiting for a Nickname & a Level
		/// </summary>
		public ToxtricityAmped(string nickname, int level)
		: base(
				849,
				SpecieToxtricityAmped.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxtricity-Amped Builder only waiting for a Level
		/// </summary>
		public ToxtricityAmped(int level)
		: base(
				849,
				SpecieToxtricityAmped.Instance, // Pokemon Specie
				"Toxtricity-Amped", level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxtricity-Amped Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public ToxtricityAmped() : base(
			849,
			SpecieToxtricityAmped.Instance, // Pokemon Specie
			Electric.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}