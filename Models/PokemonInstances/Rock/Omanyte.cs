using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Omanyte PokemonInstance Class
	#region Omanyte
	public class Omanyte : PokemonInstance
	{
		#region Omanyte Constructors
		/// <summary>
		/// Omanyte Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Omanyte(string nickname, int level)
		: base(
				OmanyteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omanyte Constructor only waiting for a Level
		/// </summary>
		public Omanyte(int level)
		: this( "Omanyte", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omanyte Constructor waiting for no params
		/// </summary>
		/*
		public Omanyte() : this( "Omanyte", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}