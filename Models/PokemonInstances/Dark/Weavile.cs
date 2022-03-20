using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Weavile PokemonInstance Class
	#region Weavile
	public class Weavile : PokemonInstance
	{
		#region Weavile Constructors
		/// <summary>
		/// Weavile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Weavile(string nickname, int level)
		: base(
				WeavileSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weavile Constructor only waiting for a Level
		/// </summary>
		public Weavile(int level)
		: this( "Weavile", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weavile Constructor waiting for no params
		/// </summary>
		/*
		public Weavile() : this( "Weavile", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}