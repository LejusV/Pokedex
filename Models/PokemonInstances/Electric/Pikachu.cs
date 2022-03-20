using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pikachu PokemonInstance Class
	#region Pikachu
	public class Pikachu : PokemonInstance
	{
		#region Pikachu Constructors
		/// <summary>
		/// Pikachu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pikachu(string nickname, int level)
		: base(
				PikachuSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikachu Constructor only waiting for a Level
		/// </summary>
		public Pikachu(int level)
		: this( "Pikachu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikachu Constructor waiting for no params
		/// </summary>
		/*
		public Pikachu() : this( "Pikachu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}