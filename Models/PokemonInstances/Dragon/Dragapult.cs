using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dragapult PokemonInstance Class
	#region Dragapult
	public class Dragapult : PokemonInstance
	{
		#region Dragapult Constructors
		/// <summary>
		/// Dragapult Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dragapult(string nickname, int level)
		: base(
				DragapultSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragapult Constructor only waiting for a Level
		/// </summary>
		public Dragapult(int level)
		: this( "Dragapult", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragapult Constructor waiting for no params
		/// </summary>
		/*
		public Dragapult() : this( "Dragapult", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}