using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Igglybuff PokemonInstance Class
	#region Igglybuff
	public class Igglybuff : PokemonInstance
	{
		#region Igglybuff Constructors
		/// <summary>
		/// Igglybuff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Igglybuff(string nickname, int level)
		: base(
				IgglybuffSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Igglybuff Constructor only waiting for a Level
		/// </summary>
		public Igglybuff(int level)
		: this( "Igglybuff", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Igglybuff Constructor waiting for no params
		/// </summary>
		/*
		public Igglybuff() : this( "Igglybuff", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}