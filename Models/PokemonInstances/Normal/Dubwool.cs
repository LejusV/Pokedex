using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dubwool PokemonInstance Class
	#region Dubwool
	public class Dubwool : PokemonInstance
	{
		#region Dubwool Constructors
		/// <summary>
		/// Dubwool Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dubwool(string nickname, int level)
		: base(
				DubwoolSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dubwool Constructor only waiting for a Level
		/// </summary>
		public Dubwool(int level)
		: this( "Dubwool", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dubwool Constructor waiting for no params
		/// </summary>
		/*
		public Dubwool() : this( "Dubwool", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}