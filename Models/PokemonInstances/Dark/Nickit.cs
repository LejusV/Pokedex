using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nickit PokemonInstance Class
	#region Nickit
	public class Nickit : PokemonInstance
	{
		#region Nickit Constructors
		/// <summary>
		/// Nickit Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Nickit(string nickname, int level)
		: base(
				NickitSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nickit Constructor only waiting for a Level
		/// </summary>
		public Nickit(int level)
		: this( "Nickit", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nickit Constructor waiting for no params
		/// </summary>
		/*
		public Nickit() : this( "Nickit", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}