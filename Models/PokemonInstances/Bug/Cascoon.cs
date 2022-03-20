using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cascoon PokemonInstance Class
	#region Cascoon
	public class Cascoon : PokemonInstance
	{
		#region Cascoon Constructors
		/// <summary>
		/// Cascoon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cascoon(string nickname, int level)
		: base(
				CascoonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cascoon Constructor only waiting for a Level
		/// </summary>
		public Cascoon(int level)
		: this( "Cascoon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cascoon Constructor waiting for no params
		/// </summary>
		/*
		public Cascoon() : this( "Cascoon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}