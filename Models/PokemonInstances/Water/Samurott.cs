using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Samurott PokemonInstance Class
	#region Samurott
	public class Samurott : PokemonInstance
	{
		#region Samurott Constructors
		/// <summary>
		/// Samurott Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Samurott(string nickname, int level)
		: base(
				SamurottSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Samurott Constructor only waiting for a Level
		/// </summary>
		public Samurott(int level)
		: this( "Samurott", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Samurott Constructor waiting for no params
		/// </summary>
		/*
		public Samurott() : this( "Samurott", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}