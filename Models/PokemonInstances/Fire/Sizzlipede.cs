using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sizzlipede PokemonInstance Class
	#region Sizzlipede
	public class Sizzlipede : PokemonInstance
	{
		#region Sizzlipede Constructors
		/// <summary>
		/// Sizzlipede Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sizzlipede(string nickname, int level)
		: base(
				SizzlipedeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sizzlipede Constructor only waiting for a Level
		/// </summary>
		public Sizzlipede(int level)
		: this( "Sizzlipede", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sizzlipede Constructor waiting for no params
		/// </summary>
		/*
		public Sizzlipede() : this( "Sizzlipede", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}