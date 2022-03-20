using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Impidimp PokemonInstance Class
	#region Impidimp
	public class Impidimp : PokemonInstance
	{
		#region Impidimp Constructors
		/// <summary>
		/// Impidimp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Impidimp(string nickname, int level)
		: base(
				ImpidimpSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Impidimp Constructor only waiting for a Level
		/// </summary>
		public Impidimp(int level)
		: this( "Impidimp", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Impidimp Constructor waiting for no params
		/// </summary>
		/*
		public Impidimp() : this( "Impidimp", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}