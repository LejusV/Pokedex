using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Qwilfish PokemonInstance Class
	#region Qwilfish
	public class Qwilfish : PokemonInstance
	{
		#region Qwilfish Constructors
		/// <summary>
		/// Qwilfish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Qwilfish(string nickname, int level)
		: base(
				QwilfishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Qwilfish Constructor only waiting for a Level
		/// </summary>
		public Qwilfish(int level)
		: this( "Qwilfish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Qwilfish Constructor waiting for no params
		/// </summary>
		/*
		public Qwilfish() : this( "Qwilfish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}