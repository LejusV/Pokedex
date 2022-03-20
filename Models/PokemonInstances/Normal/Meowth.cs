using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Meowth PokemonInstance Class
	#region Meowth
	public class Meowth : PokemonInstance
	{
		#region Meowth Constructors
		/// <summary>
		/// Meowth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Meowth(string nickname, int level)
		: base(
				MeowthSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowth Constructor only waiting for a Level
		/// </summary>
		public Meowth(int level)
		: this( "Meowth", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowth Constructor waiting for no params
		/// </summary>
		/*
		public Meowth() : this( "Meowth", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}