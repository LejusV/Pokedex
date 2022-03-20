using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sandile PokemonInstance Class
	#region Sandile
	public class Sandile : PokemonInstance
	{
		#region Sandile Constructors
		/// <summary>
		/// Sandile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sandile(string nickname, int level)
		: base(
				SandileSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandile Constructor only waiting for a Level
		/// </summary>
		public Sandile(int level)
		: this( "Sandile", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandile Constructor waiting for no params
		/// </summary>
		/*
		public Sandile() : this( "Sandile", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}