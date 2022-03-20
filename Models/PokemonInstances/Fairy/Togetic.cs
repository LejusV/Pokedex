using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Togetic PokemonInstance Class
	#region Togetic
	public class Togetic : PokemonInstance
	{
		#region Togetic Constructors
		/// <summary>
		/// Togetic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Togetic(string nickname, int level)
		: base(
				TogeticSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togetic Constructor only waiting for a Level
		/// </summary>
		public Togetic(int level)
		: this( "Togetic", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togetic Constructor waiting for no params
		/// </summary>
		/*
		public Togetic() : this( "Togetic", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}