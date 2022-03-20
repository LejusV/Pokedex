using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Charizard PokemonInstance Class
	#region Charizard
	public class Charizard : PokemonInstance
	{
		#region Charizard Constructors
		/// <summary>
		/// Charizard Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Charizard(string nickname, int level)
		: base(
				CharizardSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charizard Constructor only waiting for a Level
		/// </summary>
		public Charizard(int level)
		: this( "Charizard", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charizard Constructor waiting for no params
		/// </summary>
		/*
		public Charizard() : this( "Charizard", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}