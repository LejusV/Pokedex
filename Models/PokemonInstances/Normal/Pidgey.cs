using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pidgey PokemonInstance Class
	#region Pidgey
	public class Pidgey : PokemonInstance
	{
		#region Pidgey Constructors
		/// <summary>
		/// Pidgey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pidgey(string nickname, int level)
		: base(
				PidgeySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgey Constructor only waiting for a Level
		/// </summary>
		public Pidgey(int level)
		: this( "Pidgey", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgey Constructor waiting for no params
		/// </summary>
		/*
		public Pidgey() : this( "Pidgey", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}