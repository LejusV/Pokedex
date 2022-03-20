using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Scolipede PokemonInstance Class
	#region Scolipede
	public class Scolipede : PokemonInstance
	{
		#region Scolipede Constructors
		/// <summary>
		/// Scolipede Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Scolipede(string nickname, int level)
		: base(
				ScolipedeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scolipede Constructor only waiting for a Level
		/// </summary>
		public Scolipede(int level)
		: this( "Scolipede", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scolipede Constructor waiting for no params
		/// </summary>
		/*
		public Scolipede() : this( "Scolipede", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}