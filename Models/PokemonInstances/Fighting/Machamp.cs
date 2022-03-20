using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Machamp PokemonInstance Class
	#region Machamp
	public class Machamp : PokemonInstance
	{
		#region Machamp Constructors
		/// <summary>
		/// Machamp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Machamp(string nickname, int level)
		: base(
				MachampSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machamp Constructor only waiting for a Level
		/// </summary>
		public Machamp(int level)
		: this( "Machamp", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machamp Constructor waiting for no params
		/// </summary>
		/*
		public Machamp() : this( "Machamp", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}