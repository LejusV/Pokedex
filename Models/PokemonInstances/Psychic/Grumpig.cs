using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Grumpig PokemonInstance Class
	#region Grumpig
	public class Grumpig : PokemonInstance
	{
		#region Grumpig Constructors
		/// <summary>
		/// Grumpig Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Grumpig(string nickname, int level)
		: base(
				GrumpigSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grumpig Constructor only waiting for a Level
		/// </summary>
		public Grumpig(int level)
		: this( "Grumpig", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grumpig Constructor waiting for no params
		/// </summary>
		/*
		public Grumpig() : this( "Grumpig", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}