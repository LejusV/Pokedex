using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Psyduck PokemonInstance Class
	#region Psyduck
	public class Psyduck : PokemonInstance
	{
		#region Psyduck Constructors
		/// <summary>
		/// Psyduck Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Psyduck(string nickname, int level)
		: base(
				PsyduckSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Psyduck Constructor only waiting for a Level
		/// </summary>
		public Psyduck(int level)
		: this( "Psyduck", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Psyduck Constructor waiting for no params
		/// </summary>
		/*
		public Psyduck() : this( "Psyduck", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}