using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Froslass PokemonInstance Class
	#region Froslass
	public class Froslass : PokemonInstance
	{
		#region Froslass Constructors
		/// <summary>
		/// Froslass Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Froslass(string nickname, int level)
		: base(
				FroslassSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froslass Constructor only waiting for a Level
		/// </summary>
		public Froslass(int level)
		: this( "Froslass", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froslass Constructor waiting for no params
		/// </summary>
		/*
		public Froslass() : this( "Froslass", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}