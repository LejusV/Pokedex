using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Jellicent PokemonInstance Class
	#region Jellicent
	public class Jellicent : PokemonInstance
	{
		#region Jellicent Constructors
		/// <summary>
		/// Jellicent Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Jellicent(string nickname, int level)
		: base(
				JellicentSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jellicent Constructor only waiting for a Level
		/// </summary>
		public Jellicent(int level)
		: this( "Jellicent", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jellicent Constructor waiting for no params
		/// </summary>
		/*
		public Jellicent() : this( "Jellicent", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}